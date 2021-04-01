using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UFSoft.UBF.Util.DataAccess;

namespace MGDPlug
{
    public class PuExtend
    {
        /// <summary>
        /// 新增更新中间表数据
        /// </summary>
        /// <param name="TableType"></param>中间表类型
        /// <param name="type"></param>新增还是更新 0：新增，1：更新
        /// <param name="dt"></param>数据源
        public static void InsertInTable(int TableType,int type,DataTable dt)       
        {
            switch(type)
            {
                case 0 :
                    InsertDt(TableType, dt);
                    break;
                case 1 :
                    UpdateDt(TableType, dt);
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        /// 中间表新增数据
        /// </summary>
        /// <param name="TableType"></param>
        /// <param name="dt"></param>
        public static void InsertDt(int TableType,  DataTable dt)
        {
            string sql = "";
            switch(TableType)
            {
                case 0:
                    sql = "";
                    break;
                case 1:
                    sql = "";
                    break;
                default:
                    break;
            }
            //执行sql
            RunSql(sql);
        }
        /// <summary>
        /// 中间表更新数据
        /// </summary>
        /// <param name="TableType"></param>
        /// <param name="dt"></param>
        public static void UpdateDt(int TableType, DataTable dt)
        {
            string sql = "";
            switch (TableType)
            {
                case 0:
                    sql = "";
                    break;
                case 1:
                    sql = "";
                    break;
                default:
                    break;
            }
            //执行sql
            RunSql(sql);
        }
        /// <summary>
        /// 运行sql语句
        /// </summary>
        /// <param name="sql"></param>
        public static void RunSql(string sql)
        {
            DataAccessor.RunSQL(DataAccessor.GetConn(),sql, null);
        }
    }
}
