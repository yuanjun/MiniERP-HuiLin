using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Lib.SqlServerDAL;

namespace ERPApplication
{
    class ProductTableDao
    {
        /*
         * 获取产品固定信息(总体一起)
         */
        public DataTable queryStableProductInformation()
        {
            //先以productNo前三位排序，然后以产品名称排序
            String sqlText = "select productNo,chineseName,sellingPrice,CONVERT(decimal(18,2),boxLength*boxWidth*boxHeight/1000000.0) as boxVolumn,description from product order by left(productNo,3),chineseName";
            return DBHelper.ExecuteQueryDT(sqlText);
        }

        /*
         * 获取彩妆类产品固定信息
         */
        public DataTable queryStableCosmeticsInformation()
        {
            String sqlText = "select productNo,chineseName,sellingPrice,CONVERT(decimal(18,2),boxLength*boxWidth*boxHeight/1000000.0) as boxVolumn,description from product where productNo LIKE 'G01%' order by chineseName";
            return DBHelper.ExecuteQueryDT(sqlText);
        }   

        /*
         * 获取眉笔类产品固定信息
         */
        public DataTable queryStableEyeBrowPencilInformation()
        {
            String sqlText = "select productNo,chineseName,sellingPrice,CONVERT(decimal(18,2),boxLength*boxWidth*boxHeight/1000000.0) as boxVolumn,description from product where productNo LIKE 'G02%' order by chineseName";
            return DBHelper.ExecuteQueryDT(sqlText);
        }

        /*
         * 获取周边类产品固定信息
         */
        public DataTable queryStablePeripheralInformation()
        {
            String sqlText = "select productNo,chineseName,sellingPrice,CONVERT(decimal(18,2),boxLength*boxWidth*boxHeight/1000000.0) as boxVolumn,description from product where productNo LIKE 'G03%' order by chineseName";
            return DBHelper.ExecuteQueryDT(sqlText);
        }
    }
}
