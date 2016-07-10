using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Lib.SqlServerDAL;

namespace ERPApplication
{
    class NewContentDao
    {
        /*
         * 将内容物信息写入数据库
         */
        public void insertContent(Dictionary<String,String> contentInforDict)
        {
            StringBuilder sqlText = new StringBuilder("insert into content(");
            SqlParameter[] sqlParameter = new SqlParameter[contentInforDict.Count];

            foreach (var item in contentInforDict)
            {
                sqlText.Append(item.Key);
                sqlText.Append(",");
            }
            sqlText.Remove(sqlText.Length-1,1);
            sqlText.Append(") values(");

            int index = 0;
            foreach (var item in contentInforDict)
            {
                sqlText.Append("@");
                sqlText.Append(item.Key);
                sqlText.Append(",");

                if(item.Key == "costPrice")
                {
                    sqlParameter[index] = new SqlParameter("@" + item.Key, SqlDbType.Decimal);
                    sqlParameter[index].Value = Convert.ToDecimal(item.Value);
                }
                else
                {
                    sqlParameter[index] = new SqlParameter("@" + item.Key, SqlDbType.VarChar);
                    sqlParameter[index].Value = item.Value;
                }
                index++;
            }
            sqlText.Remove(sqlText.Length - 1, 1);
            sqlText.Append(")");

            DBHelper.ExecuteNonQuery(sqlText.ToString(), sqlParameter);
        }
    }
}
