using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Lib.SqlServerDAL;

namespace ERPApplication
{
    class CartonTableDao
    {
        /*
         * 查询所有彩盒的具体信息
         */
        public DataTable queryCartonInformation()
        {
            StringBuilder sqlText = new StringBuilder("select A.cartonNo,A.chineseName,A.colorNo,A.factoryNo,B.name AS supplierName,A.description");
            sqlText.Append(" FROM carton A,supplier B,supplierCarton C");
            sqlText.Append(" WHERE A.cartonNo=C.cartonNo AND B.supplierNo=C.supplierNo");
            return DBHelper.ExecuteQueryDT(sqlText.ToString());
        }
    }
}
