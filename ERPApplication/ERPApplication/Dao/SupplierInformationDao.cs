using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Lib.SqlServerDAL;

namespace ERPApplication
{
    class SupplierInformationDao
    {
        /*
         * 查询供应商信息
         */
        public DataTable querySupplierInformation()
        {
            String sqlText = "select supplierNo,name,majorContact,telephone,fax,email,address from supplier";
            return DBHelper.ExecuteQueryDT(sqlText);
        }

        /*
         * 根据供应商编号查询供应商信息
         */
        public DataTable querySupplierInformationById(int supplierNo)
        {
            String sqlText = "select name,address,majorContact,telephone,fax,cellphone,email from supplier where supplierNo=@supplierNo";
            SqlParameter[] sqlParameter = new SqlParameter[] {
                new SqlParameter("@supplierNo",SqlDbType.Int)
            };
            sqlParameter[0].Value = supplierNo;
            return DBHelper.ExecuteQueryDT(sqlText,sqlParameter);
        }

    }
}
