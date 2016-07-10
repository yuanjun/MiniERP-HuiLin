using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using Lib.SqlServerDAL;

namespace ERPApplication
{
    class NewProductListDao
    {
        /*
         * 获取当前库存彩妆类产品总数
         */
        public DataTable getCosmeticsCount()
        {
            String sqlText = "select SUM(inventory) from content where productNo LIKE 'G01%'";
            return DBHelper.ExecuteQueryDT(sqlText);
        }

        /*
         * 获取当前库存眉笔类产品总数
         */
        public DataTable getEyebrowPencilCount()
        {
            String sqlText = "select SUM(inventory) from content where productNo LIKE 'G02%'";
            return DBHelper.ExecuteQueryDT(sqlText);
        }

        /*
         * 获取当前库存周边类产品总数
         */
        public DataTable getPeripheralCount()
        {
            String sqlText = "select SUM(inventory) from content where productNo LIKE 'G03%'";
            return DBHelper.ExecuteQueryDT(sqlText);
        }

        /*
         * 查询彩妆类产品信息（不包括供应商）
         */
        public DataTable getCosmeticsInformation()
        {
            StringBuilder sqlText = new StringBuilder("select A.productNo,A.chineseName,B.colorNo,A.cartonNo,A.packingMaterialNo from product A,content B");
            sqlText.Append(" where A.productNo LIKE 'G01%' and A.productNo=B.productNo");
            return DBHelper.ExecuteQueryDT(sqlText.ToString());
        }

        /*
         * 查询眉笔类产品信息（不包括供应商）
         */
        public DataTable getEyebrowPencilInformation()
        {
            StringBuilder sqlText = new StringBuilder("select A.productNo,A.chineseName,B.colorNo,A.cartonNo from product A,content B");
            sqlText.Append(" where A.productNo LIKE 'G02%' and A.productNo=B.productNo");
            return DBHelper.ExecuteQueryDT(sqlText.ToString());
        }

        /*
         * 查询周边类产品信息（不包括供应商）
         */
        public DataTable getPeripheralInformation()
        {
            StringBuilder sqlText = new StringBuilder("select A.productNo,A.chineseName,B.colorNo from product A,content B");
            sqlText.Append(" where A.productNo LIKE 'G03%' and A.productNo=B.productNo");
            return DBHelper.ExecuteQueryDT(sqlText.ToString());
        }

        /*
         * 查询产品和供应商关系信息
         */
        public DataTable getProductSupplier()
        {
            String sqlText = "select A.productNo,B.name from supplierProduct A,supplier B where A.supplierNo=B.supplierNo";
            return DBHelper.ExecuteQueryDT(sqlText);
        }
    }
}
