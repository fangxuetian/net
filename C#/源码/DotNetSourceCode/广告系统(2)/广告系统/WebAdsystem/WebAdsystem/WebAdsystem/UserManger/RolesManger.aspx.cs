﻿using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using BBL.Inface;
using DAL.Model;
using BBL;

public partial class UserManger_RolesManger : System.Web.UI.Page
{
    IUserTypeInfo UserTypeInfo =BBLFactory.GetUserTypeInfo();
    UserType userType =new  UserType();
    protected void GvDataBind()
    {
        DataSet ds = UserTypeInfo.SelectUserTypeInfo();
        GridView1.DataSource = ds;
        GridView1.DataKeyNames = new string[] { "user_type_id" };
        GridView1.DataBind();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        Panel1.Visible = false;
        Panel2.Visible = false;
        if (!IsPostBack)
        {
            GvDataBind();
        }
        
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        
        Panel2.Visible = true ;
        Panel1.Visible = false;
        Label1.Text =TextBox1.Text ;
        Label2.Text =TextBox2.Text ;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Panel1.Visible =  true ;

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Panel1.Visible = false;
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        Panel2.Visible = true;
    }
   protected void  Button4_Click(object sender, EventArgs e)
   {
       userType.User_type_name= Label1.Text;
       userType .User_type_remark=Label2.Text ;
       bool i = UserTypeInfo.InsertUserTypeInfo(userType);
       if(i)
       {
           Response .Write ("<script>alert('增加成功');</script>");
       }
       else
       {
            Response .Write ("<script>alert('增加失败');</script>");
       }
       GvDataBind(); 
  }
    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {

        GridView1.EditIndex = -1;
        GvDataBind(); 
    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditRowStyle.Width = 700;
        GridView1.EditIndex = e.NewEditIndex;
        GvDataBind(); 
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int userID = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
        UserTypeInfo.DelUserTypeInfobyID(userID);

        GvDataBind();
    }
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {

        userType.User_type_id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
        userType.User_type_name = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[1].Controls[0])).Text.ToString().Trim();
        userType.User_type_remark = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[2].Controls[0])).Text.ToString().Trim(); 
        UserTypeInfo.UpdateUserTypeInfo(userType); 
        GridView1.EditIndex = -1;
        GvDataBind(); 

    }
}
