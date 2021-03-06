/*
	FluorineFx open source library 
	Copyright (C) 2007 Zoltan Csibi, zoltan@TheSilentGroup.com, FluorineFx.com 
	
	This library is free software; you can redistribute it and/or
	modify it under the terms of the GNU Lesser General Public
	License as published by the Free Software Foundation; either
	version 2.1 of the License, or (at your option) any later version.
	
	This library is distributed in the hope that it will be useful,
	but WITHOUT ANY WARRANTY; without even the implied warranty of
	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
	Lesser General Public License for more details.
	
	You should have received a copy of the GNU Lesser General Public
	License along with this library; if not, write to the Free Software
	Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
*/
using System;
using System.Collections;
using System.IO;
using System.Text;
using System.Web;

namespace FluorineFx.CodeGenerator.Parser
{
	class Token
	{
		public const int EOF 		= 0x0200000;
		public const int IDENTIFIER 	= 0x0200001;
		public const int DIRECTIVE 	= 0x0200002;
		public const int ATTVALUE	= 0x0200003;
		public const int TEXT	    	= 0x0200004;
		public const int DOUBLEDASH 	= 0x0200005;
		public const int CLOSING 	= 0x0200006;
	}

	class TemplateTokenizer
	{
		TextReader sr;
		int current_token;
		StringBuilder sb, odds;
		int col, line;
		int begcol, begline;
		int position;
		bool inTag;
		bool expectAttrValue;
		bool alternatingQuotes;
		bool hasPutBack;
		bool verbatim;
		bool have_value;
		bool have_unget;
		int unget_value;
		string val;
		
		public TemplateTokenizer (TextReader reader)
		{
			this.sr = reader;
			sb = new StringBuilder ();
			odds= new StringBuilder();
			col = line = 1;
			hasPutBack = inTag = false;
		}

		public bool Verbatim
		{
			get { return verbatim; }
			set { verbatim = value; }
		}

		public void put_back ()
		{
			if (hasPutBack)
				throw new HttpException ("put_back called twice!");
			
			hasPutBack = true;
			position -= Value.Length;
		}
		
		public int get_token ()
		{
			if (hasPutBack)
			{
				hasPutBack = false;
				position += Value.Length;
				return current_token;
			}

			begline = line;
			begcol = col;
			have_value = false;
			current_token = NextToken ();
			return current_token;
		}

		bool is_identifier_start_character (char c)
		{
			return (Char.IsLetter (c) || c == '_' );
		}

		bool is_identifier_part_character (char c)
		{
			//Zoli: Added c == '.' for web.config tags
			return (Char.IsLetterOrDigit (c) || c == '_' || c == '-' || c == '.' );
		}

		void ungetc (int value)
		{
			have_unget = true;
			unget_value = value;

			// Only '/' passes through here now.
			// If we ever let \n here, update 'line'
			position--;
			col--;
		}
		
		int read_char ()
		{
			int c;
			if (have_unget) 
			{
				c = unget_value;
				have_unget = false;
			} 
			else 
			{
				c = sr.Read ();
			}

			if (c == '\r' && sr.Peek () == '\n') 
			{
				c = sr.Read ();
				position++;
			}

			if (c == '\n')
			{
				col = -1;
				line++;
			}

			if (c != -1) 
			{
				col++;
				position++;
			}

			return c;
		}

		int ReadAttValue (int start)
		{
			int quoteChar = 0;
			bool quoted = false;

			if (start == '"' || start == '\'') 
			{
				quoteChar = start;
				quoted = true;
			} 
			else 
			{
				sb.Append ((char) start);
			}

			int c;
			int last = 0;
			bool inServerTag = false;
			alternatingQuotes = true;
			
			while ((c = sr.Peek ()) != -1) 
			{
				if (c == '%' && last == '<') 
				{
					inServerTag = true;
				} 
				else if (inServerTag && c == '>' && last == '%') 
				{
					inServerTag = false;
				} 
				else if (!inServerTag) 
				{
					if (!quoted && c == '/') 
					{
						read_char ();
						c = sr.Peek ();
						if (c == -1) 
						{
							c = '/';
						} 
						else if (c == '>') 
						{
							ungetc ('/');
							break;
						}
					} 
					else if (!quoted && (c == '>' || Char.IsWhiteSpace ((char) c))) 
					{
						break;
					} 
					else if (quoted && c == quoteChar && last != '\\') 
					{
						read_char ();
						break;
					}
				} 
				else if (quoted && c == quoteChar) 
				{
					alternatingQuotes = false;
				}

				sb.Append ((char) c);
				read_char ();
				last = c;
			}

			return Token.ATTVALUE;
		}

		int NextToken ()
		{
			int c;
			
			sb.Length = 0;
			odds.Length=0;
			while ((c = read_char ()) != -1)
			{
				if (verbatim)
				{
					inTag = false;
					sb.Append  ((char) c);
					return c;
				}

				if (inTag && expectAttrValue && (c == '"' || c == '\''))
					return ReadAttValue (c);
				
				if (c == '<')
				{
					inTag = true;
					sb.Append ((char) c);
					return c;
				}

				if (c == '>')
				{
					inTag = false;
					sb.Append ((char) c);
					return c;
				}

				if (current_token == '<' && "%/!".IndexOf ((char) c) != -1)
				{
					sb.Append ((char) c);
					return c;
				}

				if (inTag && current_token == '%' && "@#=".IndexOf ((char) c) != -1)
				{
					sb.Append ((char) c);
					return c;
				}

				if (inTag && c == '-' && sr.Peek () == '-')
				{
					sb.Append ("--");
					read_char ();
					return Token.DOUBLEDASH;
				}

				if (!inTag)
				{
					sb.Append ((char) c);
					while ((c = sr.Peek ()) != -1 && c != '<')
						sb.Append ((char) read_char ());

					return (c != -1 || sb.Length > 0) ? Token.TEXT : Token.EOF;
				}

				if (inTag && current_token == '=' && !Char.IsWhiteSpace ((char) c))
					return ReadAttValue (c);

				if (inTag && is_identifier_start_character ((char) c))
				{
					sb.Append ((char) c);
					while ((c = sr.Peek ()) != -1) 
					{
						if (!is_identifier_part_character ((char) c) && c != ':')
							break;
						sb.Append ((char) read_char ());
					}

					if (current_token == '@' && Directive.IsDirective (sb.ToString ()))
						return Token.DIRECTIVE;
					
					return Token.IDENTIFIER;
				}

				if (!Char.IsWhiteSpace ((char) c)) 
				{
					sb.Append  ((char) c);
					return c;
				}
				// keep otherwise discarded characters in case we need.
				odds.Append((char) c);
			}

			return Token.EOF;
		}

		public string Value 
		{
			get 
			{
				if (have_value)
					return val;

				have_value = true;
				val = sb.ToString ();
				return val;
			}
		}

		public string Odds 
		{
			get 
			{
				return odds.ToString();
			}
		}

		public bool InTag 
		{
			get { return inTag; }
			set { inTag = value; }
		}

		// Hack for preventing confusion with VB comments (see bug #63451)
		public bool ExpectAttrValue 
		{
			get { return expectAttrValue; }
			set { expectAttrValue = value; }
		}
		
		public bool AlternatingQuotes 
		{
			get { return alternatingQuotes; }
		}
		
		public int BeginLine 
		{
			get { return begline; }
		}

		public int BeginColumn 
		{
			get { return begcol; }
		}

		public int EndLine 
		{
			get { return line; }
		}

		public int EndColumn 
		{
			get { return col; }
		}

		public int Position 
		{
			get { return position; }
		}
	}
}