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

public partial class admin_flashPicManager : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        fun.quanxian("flashpic");
        fun.BindPage("select * from flashpic  order by  addtime desc", AspNetPager1, rpNews, 6);
    }
    protected void AspNetPager1_PageChanged(object sender, EventArgs e)
    {
        fun.BindPage("select * from flashpic  order by  addtime desc", AspNetPager1, rpNews, 6);
    }
    protected void Button1_Click(object sender, EventArgs e)
    {


        string Id_str = Request["ch"], sql = "";
        if (fun.CheckStr(Id_str))
        {
            sql = "delete from  flashpic where id in (" + Id_str + ")";
            fun.DoSql(this, sql, Request.Url.ToString(), "pic");
        }
        else
        {
            fun.AJAXalert(this, "请至少选择一项！");
        }
    }
}
