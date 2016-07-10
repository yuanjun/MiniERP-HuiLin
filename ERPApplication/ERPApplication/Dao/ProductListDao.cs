using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Lib.SqlServerDAL;

namespace ERPApplication
{
    class ProductListDao
    {
        /*
         * 查询全部产品信息，先按类别排序，然后按名称排序
         */
        public DataTable queryProductInformation()
        {
            StringBuilder sqlText = new StringBuilder("select A.productNo,A.chineseName,B.colorNo,B.factoryNo,B.inventory,A.sellingPrice");
            sqlText.Append(" from product A,content B where A.productNo=B.productNo");
            sqlText.Append(" order by left(A.productNo,3),A.chineseName");
            return DBHelper.ExecuteQueryDT(sqlText.ToString());
        }

        /*
         * 查询彩妆类产品信息
         */
        public DataTable queryCosmeticsInformation()
        {
            StringBuilder sqlText = new StringBuilder("select A.productNo,A.chineseName,B.colorNo,B.factoryNo,B.inventory,A.sellingPrice");
            sqlText.Append(" from product A,content B where A.productNo LIKE 'G01%' AND A.productNo=B.productNo");
            sqlText.Append(" order by A.chineseName");
            return DBHelper.ExecuteQueryDT(sqlText.ToString());
        }

        /*
         * 查询眉笔类产品信息
         */
        public DataTable queryEyeBrowPencilInformation()
        {
            StringBuilder sqlText = new StringBuilder("select A.productNo,A.chineseName,B.colorNo,B.factoryNo,B.inventory,A.sellingPrice");
            sqlText.Append(" from product A,content B where A.productNo LIKE 'G02%' AND A.productNo=B.productNo");
            sqlText.Append(" order by A.chineseName");
            return DBHelper.ExecuteQueryDT(sqlText.ToString());
        }

        /*
         * 查询周边类产品信息
         */
        public DataTable queryPeripheralInformation()
        {
            StringBuilder sqlText = new StringBuilder("select A.productNo,A.chineseName,B.colorNo,B.factoryNo,B.inventory,A.sellingPrice");
            sqlText.Append(" from product A,content B where A.productNo LIKE 'G03%' AND A.productNo=B.productNo");
            sqlText.Append(" order by A.chineseName");
            return DBHelper.ExecuteQueryDT(sqlText.ToString());
        }
    }
}
