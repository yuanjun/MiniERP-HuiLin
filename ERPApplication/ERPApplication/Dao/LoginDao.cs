using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Lib.SqlServerDAL;

namespace ERPApplication
{
    class LoginDao
    {
        
        /*
         * 验证用户名和密码是否匹配
         */
        public bool checkPassword(String username, String password)
        {
            StringBuilder sqlText = new StringBuilder("select * from [user] where ");
            sqlText.Append("name=@username and ");
            sqlText.Append("password=@password");

            SqlParameter[] parameter = new SqlParameter[]{
                new SqlParameter("@username",SqlDbType.VarChar),
                new SqlParameter("@password",SqlDbType.VarChar)
            };
            parameter[0].Value = username;
            parameter[1].Value = password;

            DataTable rst = DBHelper.ExecuteQueryDT(sqlText.ToString(), parameter);
            if (rst.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
