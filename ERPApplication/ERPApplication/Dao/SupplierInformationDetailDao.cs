using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Lib.SqlServerDAL;

namespace ERPApplication
{
    class SupplierInformationDetailDao
    {
        /*
         * 插入新供应商
         */
        public void insertSupplier(Dictionary<String,String> supplierInformationDict)
        {
            StringBuilder sqlText = new StringBuilder("insert into supplier(");
            foreach (var item in supplierInformationDict)
            {
                sqlText.Append(item.Key);
                sqlText.Append(",");
            }
            sqlText.Remove(sqlText.Length-1,1);     //移除,(多余的逗号)
            sqlText.Append(") values(");

            SqlParameter[] sqlParameter = new SqlParameter[supplierInformationDict.Count];
            int index = 0;
            foreach (var item in supplierInformationDict)
            {
                sqlText.Append("@");
                sqlText.Append(item.Key);
                sqlText.Append(",");

                if (index != supplierInformationDict.Count - 1)
                {
                    sqlParameter[index] = new SqlParameter("@" + item.Key, SqlDbType.VarChar);
                }
                else
                {
                    sqlParameter[index] = new SqlParameter("@" + item.Key, SqlDbType.DateTime);
                }
                sqlParameter[index].Value = item.Value;
                index++;
            }
            sqlText.Remove(sqlText.Length - 1, 1);     //移除,(多余的逗号)
            sqlText.Append(")");

            DBHelper.ExecuteNonQuery(sqlText.ToString(),sqlParameter);
        }

        /*
         * 根据供应商编号更新供应商信息
         */
        public void updateSupplier(Dictionary<String, String> supplierInforDict, int supplierNo)
        {
            StringBuilder sqlText = new StringBuilder("update supplier set");
            SqlParameter[] sqlParameter = new SqlParameter[supplierInforDict.Count+1];

            int index = 0;
            foreach (var item in supplierInforDict)
            {
                sqlText.Append(" ");
                sqlText.Append(item.Key);
                sqlText.Append("=@");
                sqlText.Append(item.Key);
                sqlText.Append(",");

                sqlParameter[index] = new SqlParameter("@" + item.Key, SqlDbType.VarChar);
                sqlParameter[index].Value = item.Value;
                index++;
            }
            sqlText.Remove(sqlText.Length - 1, 1);                 //移除多余逗号
            sqlText.Append(" where supplierNo=@supplierNo");

            sqlParameter[index] = new SqlParameter("@supplierNo", SqlDbType.Int);
            sqlParameter[index].Value = supplierNo;

            DBHelper.ExecuteNonQuery(sqlText.ToString(), sqlParameter);
        }
    }
}
