using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Lib.SqlServerDAL;

namespace ERPApplication
{
    class PackingMaterialTableDao
    {
        /*
         * 查询所有包材信息
         */
        public DataTable queryPackingMateialInformation()
        {
            StringBuilder sqlText = new StringBuilder("select A.packingMaterialNo,A.chineseName,A.colorNo,A.factoryNo,B.name AS supplierName,A.description");
            sqlText.Append(" FROM packingMaterial A,supplier B,supplierPackingMaterial C");
            sqlText.Append(" WHERE A.packingMaterialNo=C.packingMaterialNo AND B.supplierNo=C.supplierNo");
            return DBHelper.ExecuteQueryDT(sqlText.ToString());
        }
    }
}
