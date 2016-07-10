using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Lib.SqlServerDAL;


namespace ERPApplication
{
    class ClientInformationDao
    {
        /*
         * 倒排序查询所有客户信息
         */
        public DataTable listClient()
        {
            String sql = "select clientNo,name,address,majorContact,telephone,fax,email,remarks from client order by createTime desc";
            return DBHelper.ExecuteQueryDT(sql);
        }

        /*
         * 查询某个对应客户id的具体信息,以hash表返回，在详细页中便于赋值
         */
        public Dictionary<String, String> queryClientById(int id)
        {
            Dictionary<String, String> rst = new Dictionary<String, String>();
            StringBuilder sqlText = new StringBuilder("select * from client where clientNo=@clientNo");
            SqlParameter[] sqlParameter = new SqlParameter[] {
                new SqlParameter("@clientNo",SqlDbType.Int)
            };
            sqlParameter[0].Value = id;
            DataTable dataTable = DBHelper.ExecuteQueryDT(sqlText.ToString(),sqlParameter);
            if (dataTable.Rows.Count > 0)
            {
                int rowIndex = 0;
                DataRow currentRow = dataTable.Rows[0];
                DataColumnCollection columns = dataTable.Columns;
                foreach (DataColumn currentColumn in columns)
                {
                    rst.Add(currentColumn.Caption, currentRow.ItemArray[rowIndex++].ToString());
                }
            }
            return rst;
        }

        /*
         * 根据多个条件查询符合的客户信息
         */
        public DataTable queryClientByMutiCondition(Dictionary<String,String> items)
        {
            StringBuilder sqlText = new StringBuilder("select clientNo,name,address,majorContact,telephone,fax,email,remarks from client where ");
            SqlParameter[] sqlParameter = new SqlParameter[items.Count];
            int index = 0;
            foreach (var item in items)
            {
                sqlText.Append(item.Key);
                sqlText.Append(" LIKE @");
                sqlText.Append(item.Key+" AND ");

                sqlParameter[index] = new SqlParameter("@"+item.Key,SqlDbType.VarChar);
                sqlParameter[index].Value = "%" + item.Value + "%";
                index++;
            }

            if (items.Count > 0)
            {
                sqlText.Remove(sqlText.Length - 5, 5);     //移除" AND "共5个字符
            }
            else
            {
                sqlText.Remove(sqlText.Length - 7, 7);     //移除" where "共7个字符
            }

            sqlText.Append(" order by createTime desc");

            DataTable dataTable = DBHelper.ExecuteQueryDT(sqlText.ToString(), sqlParameter);
            return dataTable;
        }

        /*
         * 添加一个新用户
         */
        public void insertClient(Dictionary<String, String> items)
        {
            StringBuilder keys = new StringBuilder();
            StringBuilder values = new StringBuilder();
            StringBuilder sqlText = new StringBuilder("insert into client(");

            foreach (var item in items)
            {
                keys.Append(item.Key+",");
                values.Append("@"+item.Key+",");
            }
            keys.Append("createTime");
            values.Append("@createTime");

            sqlText.Append(keys);
            sqlText.Append(") values(");
            sqlText.Append(values);
            sqlText.Append(")");

            SqlParameter[] sqlParameter = new SqlParameter[items.Count+1];
            int index = 0;
            foreach (var item in items)
            {
                sqlParameter[index] = new SqlParameter("@"+item.Key,SqlDbType.VarChar);
                sqlParameter[index].Value = item.Value;
                index++;
            }
            sqlParameter[index] = new SqlParameter("@createTime",SqlDbType.DateTime);
            sqlParameter[index].Value = DateTime.Now.ToLocalTime().ToString();

            DBHelper.ExecuteNonQuery(sqlText.ToString(), sqlParameter);
        }

        /*
         * 根据id修改一个客户
         */
        public void updatClient(Dictionary<String, String> items)
        {
            StringBuilder sqlText = new StringBuilder("update client set ");
            foreach (var item in items)
            {
                if(item.Key != "clientNo")
                {
                    sqlText.Append(item.Key+"=@"+item.Key+",");
                }
            }
            sqlText.Remove(sqlText.Length - 1, 1);
            sqlText.Append(" where clientNo=@clientNo");

            SqlParameter[] sqlParameter = new SqlParameter[items.Count];
            int index = 0;
            foreach (var item in items)
            {
                if (item.Key != "clientNo")
                {
                    sqlParameter[index] = new SqlParameter("@"+item.Key, SqlDbType.VarChar);
                    sqlParameter[index].Value = item.Value;
                    index++;
                }
            }
            sqlParameter[index] = new SqlParameter("@clientNo", SqlDbType.Int);
            sqlParameter[index].Value = items["clientNo"];

            DBHelper.ExecuteNonQuery(sqlText.ToString(), sqlParameter);
        }

        /*
         * 删除一个客户
         */
        public void removeClientById(int id)
        {
            StringBuilder sqlText = new StringBuilder("delete from client where clientNo=@clientNo");
            SqlParameter[] sqlParameter = new SqlParameter[] { 
                new SqlParameter("@clientNo",SqlDbType.Int)
            };
            sqlParameter[0].Value = id;
            DBHelper.ExecuteNonQuery(sqlText.ToString(), sqlParameter);
        }
    }
}
