using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Data;
using czy.IFactory;
using czy.MyClass.CommandHelper;
 
namespace BBL
{
    public class Town
    {
       #region SelectData
       /// <summary>
       /// 查询
       /// </summary>
       public static DataSet Select()
       {
         string sql = SQLCommandBuilder.GetSelectSQL(new Models.Town(), "");
         return Factory.GetDataBase().GetDataSet(sql);
       }
       /// <summary>
       /// 查询
       /// </summary>
       public static List<Models.Town> SelectList()
       {
         return Select().Tables[0].TableToList<Models.Town>();
       }

       /// <summary>
       /// 查询
       /// </summary>
       /// <param name="id">跟据ID查询</param>
       public static DataSet Select(object id)
       {
         string sql = SQLCommandBuilder.GetSelectSQL(new Models.Town(), string .Format ( "t_id={0}",id.ToString()));
         return Factory.GetDataBase().GetDataSet(sql);
       }

       /// <summary>
       /// 查询
       /// </summary>
       /// <param name="id">跟据ID查询</param>
       public static List<Models.Town> SelectList(object id)
       {
          return Select(id).Tables[0].TableToList<Models.Town>();
       }

       /// <summary>
       /// 查询
       /// </summary>
       /// <param name="columnParams">列用,号隔开</param>
       /// <param name="filter">条件</param>
       public static DataSet Select(string columnParams, string filter)
       {
         string sql = SQLCommandBuilder.GetSelectSQL("Town",columnParams,filter);
         return Factory.GetDataBase().GetDataSet(sql);
       }

       /// <summary>
       /// 查询
       /// </summary>
       /// <param name="columnParams">列用,号隔开</param>
       /// <param name="filter">条件</param>
       public static List<Models.Town>  SelectList(string columnParams, string filter)
       {
         return Select( columnParams,  filter).Tables[0].TableToList<Models.Town> ();
       }

       #endregion

       #region Execute
       /// <summary>
       /// 插入
       /// </summary>
       /// <param name="Models.Town">模型</param>
       public static int Insert(Models.Town Town)
       {
         string sql = SQLCommandBuilder.GetInsertSQL(Town, "t_id");
         return Factory.GetDataBase().ExecuteNonQuery(sql);
       }

       /// <summary>
       /// 查询
       /// </summary>
       /// <param name="id">id</param>
       /// <param name="Mode.Town">模型</param>
       public static int Update(object id,Models.Town Town)
       {
         string sql = SQLCommandBuilder.GetUpdateSQL(Town, "t_id", "t_id=" + id.ToString());
         return Factory.GetDataBase().ExecuteNonQuery(sql);
       }

       /// <summary>
       /// 查询
       /// </summary>
       /// <param name="columns">列</param>
       /// <param name="values">值</param>
       /// <param name="filter">条件</param>
       public static int Update(string[] columns,string[] values,string filter)
       {
         string sql = SQLCommandBuilder.GetUpdateSQL("Town", columns, values,filter);
         return Factory.GetDataBase().ExecuteNonQuery(sql);
       }

       /// <summary>
       /// 删除
       /// </summary>
       /// <param name="id">id</param>
       public static int Delete(object id)
       {
         string sql = SQLCommandBuilder.GetDelSQL(new Models.Town(), "t_id=" + id);
         return Factory.GetDataBase().ExecuteNonQuery(sql);
       }


       #endregion

       #region 查询当前页数据
       /// <summary>
       /// 查询当前页数据
       /// </summary>
       /// <param name="cur">当前页</param>
       /// <param name="size">当前页大小</param>
       public static DataSet GetCurrentData(int cur, int size)
       {
         czy.SQLCommon.DataPagerHelper.DataPagerQueryParams PagerQueryParams = new czy.SQLCommon.DataPagerHelper.DataPagerQueryParams();PagerQueryParams.Size = size;
         PagerQueryParams.TableName = "Town";
         PagerQueryParams.TableId = "t_id";
         //Util.PagerQueryParams.Order = "Order by u_createDate";
         PagerQueryParams.KeyFieldOrder = "asc";
         PagerQueryParams.Colums = "*";
         DataSet ds = Factory.GetDataPager(PagerQueryParams).GetCurrentPageData(cur);
         return ds;
       }

       /// <summary>
       /// 查询当前页数据
       /// </summary>
       /// <param name="cur">当前页</param>
       /// <param name="size">当前页大小</param>
       /// <param name="order">当前页大小</param>
       /// <param name="keyFieldOrder">ID列排序方式[asc][desc]</param>
       /// <param name="columes">查询的列可为*</param>
       public static DataSet GetCurrentData(int cur, int size,string order,string keyFieldOrder,string columes)
       {
         czy.SQLCommon.DataPagerHelper.DataPagerQueryParams PagerQueryParams = new czy.SQLCommon.DataPagerHelper.DataPagerQueryParams();PagerQueryParams.Size = size;
         PagerQueryParams.TableName = "Town";
         PagerQueryParams.TableId = "t_id";
         PagerQueryParams.Order = order;
         PagerQueryParams.KeyFieldOrder = keyFieldOrder;
         PagerQueryParams.Colums = columes;
         DataSet ds = Factory.GetDataPager(PagerQueryParams).GetCurrentPageData(cur);
         return ds;
       }

       /// <summary>
       /// 查询当前页数据
       /// </summary>
       /// <param name="cur">当前页</param>
       /// <param name="size">当前页大小</param>
       /// <param name="order">当前页大小</param>
       /// <param name="keyFieldOrder">ID列排序方式[asc][desc]</param>
       /// <param name="columes">查询的列可为*</param>
       public static List<Models.Town> GetListCurrentData(int cur, int size)
       {
          return GetCurrentData( cur,  size).Tables[0].TableToList<Models.Town>();
       }

       /// <summary>
       /// 查询当前页数据
       /// </summary>
       /// <param name="cur">当前页</param>
       /// <param name="size">当前页大小</param>
       /// <param name="order">当前页大小</param>
       /// <param name="keyFieldOrder">ID列排序方式[asc][desc]</param>
       /// <param name="columes">查询的列可为*</param>
       public static List<Models.Town> GetListCurrentData(int cur, int size,string order,string keyFieldOrder,string columes)
       {
          return GetCurrentData( cur,  size, order, keyFieldOrder, columes).Tables[0].TableToList<Models.Town>();
       }

       /// <summary>
       /// 查询总条数
       /// </summary>
       /// <param name="size">当前大小</param>
       public static long GetTotleCount(int size)
       {
         czy.SQLCommon.DataPagerHelper.DataPagerQueryParams PagerQueryParams = new czy.SQLCommon.DataPagerHelper.DataPagerQueryParams();PagerQueryParams.Size = size;
         PagerQueryParams.TableName = "Town";
         PagerQueryParams.TableId = "t_id";
         //Util.PagerQueryParams.Order = "u_createDate asc";
         PagerQueryParams.KeyFieldOrder = "asc";
         PagerQueryParams.Colums = "*";
         return Factory.GetDataPager(PagerQueryParams).GetTotalCount();
       }
       #endregion
    }
}