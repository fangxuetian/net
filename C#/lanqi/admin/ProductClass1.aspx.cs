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

public partial class admin_ProductClass1 : System.Web.UI.Page
{
    

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            
            fun.BindPage("select * from user_producttype2  ", AspNetPager2, rpNewClass2, 3);
           // fun.BindPage("select * from user_producttype3 ", AspNetPager3, rpNewClass3, 3);
           
            //fun.bind(DropDownList2, "select * from user_producttype2", "type", "id");
        }

    }
    protected void AspNetPager2_PageChanged(object sender, EventArgs e)
    {
        fun.BindPage("select * from user_producttype2  ", AspNetPager2, rpNewClass2, 3);
    }
    protected void AspNetPager3_PageChanged(object sender, EventArgs e)
    {
        //fun.BindPage("select * from user_producttype3  ", AspNetPager3, rpNewClass3, 3);
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        //string Id_str = Request["ch2"], sql = "";
        //if (Request["ch2"] != null && Id_str != "")
        //{
        //    string str = "0";
        //    DataTable dt = fun.GetDataTable("select * from user_producttype3 where sjid in (" + Id_str + ")");
        //    foreach (DataRow dr in dt.Rows)
        //    {
        //        str += "," + dr["id"].ToString();
        //    }


        //    string sqlstr = "delete from user_product where typeid in (" + str + ")";
        //    string sql2 = "delete from  user_producttype2 where id in (" + Id_str + ")";
        //    sql = "delete from  user_producttype3 where sjid in (" + Id_str + ")";


        //    fun.DoSqlAJAX(sqlstr);
        //    fun.DoSqlAJAX(sql);
        //    fun.DoSql(this, sql2, Request.Url.ToString());
        //    //fun.BindPage("select * from user_producttype3  ", AspNetPager3, rpNewClass3, 3);

        //}
        //else
        //{
        //    fun.AJAXalert(this, "alert('请至少选择一项！');");
        //}
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        //string Id_str = Request["ch3"], sql = "";
        //if (Request["ch3"] != null && Id_str != "")
        //{
        //    sql = "delete from  user_producttype3 where id in (" + Id_str + ")";
        //    string sqlstr = "delete from user_product where typeid in (" + Id_str + ")";
        //    fun.DoSqlAJAX(sqlstr);
        //    fun.DoSql(this, sql, Request.Url.ToString());
        //    //fun.BindPage("select * from user_producttype3  ", AspNetPager3, rpNewClass3, 3);

        //}
        //else
        //{
        //    fun.AJAXalert(this, "alert('请至少选择一项！');");
        //}
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        string name = TextBox2.Text;
        if (!fun.CheckStr(name))
        {
            fun.AJAXalert(this, "二级类别名称不能为空");
        }
        else
        {
            name = fun.GetSafeStr(name);
            if (fun.CheckName("user_productType2", "type", name))
            {
                fun.AJAXalert(this, "该类别已经存在");
            }
            else
            {
                string sql = string.Format("insert into user_productType2 (type) values ('{0}')", name);
                fun.DoSql(this, sql, Request.Url.ToString());

            }
        }
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        //string name = TextBox3.Text;
        //if (!fun.CheckStr(name))
        //{
        //    fun.AJAXalert(this, "三级类别名称不能为空");
        //}
        //else
        //{
        //    name = fun.GetSafeStr(name);
        //    if (fun.CheckName("user_productType3", "type", name))
        //    {
        //        fun.AJAXalert(this, "该类别已经存在");
        //    }
        //    else
        //    {
        //        string sql = string.Format("insert into user_productType3 (type,sjid) values ('{0}',{1})", name, Convert.ToInt32(DropDownList2.SelectedValue));
        //        fun.DoSql(this, sql, Request.Url.ToString());

        //    }
        //}
    }
}