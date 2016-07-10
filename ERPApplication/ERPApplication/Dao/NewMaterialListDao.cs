using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using Lib.SqlServerDAL;

namespace ERPApplication
{
    class NewMaterialListDao
    {
        /*
         * 获取库存彩盒总数
         */
        public DataTable getCartonCount()
        {
            String sqlText = "select COUNT(inventory) from carton";
            return DBHelper.ExecuteQueryDT(sqlText);
        }

        /*
         * 获取库存包材总数
         */
        public DataTable getPackingMaterialCount()
        {
            String sqlText = "select COUNT(inventory) from packingMaterial";
            return DBHelper.ExecuteQueryDT(sqlText);
        }

        /*
         * 获取库存彩盒详细信息(不包括和彩盒相关的供应商)
         */
        public DataTable getCartonInformation()
        {
            String sqlText = "select cartonNo,chineseName,colorNo,factoryNo,description from carton";
            return DBHelper.ExecuteQueryDT(sqlText);
        }

        /*
         * 获取和彩盒相关的供应商信息
         */
        public DataTable getCartonSupplier()
        {
            String sqlText = "select A.cartonNo,B.name from supplierCarton A,supplier B where A.supplierNo=B.supplierNo";
            return DBHelper.ExecuteQueryDT(sqlText);

        }

        /*
        * 获取库存包材详细信息（不包括和彩盒相关的供应商）
        */
        public DataTable getPackingMaterialInformation()
        {
            String sqlText = "select packingMaterialNo,chineseName,colorNo,factoryNo,description from packingMaterial";
            return DBHelper.ExecuteQueryDT(sqlText);
        }

        /*
         * 获取和彩盒相关的供应商信息
         */
        public DataTable getPackingMaterialSupplier()
        {
            String sqlText = "select A.packingMaterialNo,B.name from supplierPackingMaterial A,supplier B where A.supplierNo=B.supplierNo";
            return DBHelper.ExecuteQueryDT(sqlText);
        }

        /*
        * 删除一条包材记录
        */
        public void removePackingMaterial(String packingMaterialNo)
        {
            String sqlText = "delete from packingMaterial where packingMaterialNo=@packingMaterialNo";
            SqlParameter[] sqlParameter = new SqlParameter[] {
                new SqlParameter("@packingMaterialNo",SqlDbType.VarChar)
            };
            sqlParameter[0].Value = packingMaterialNo;

            DBHelper.ExecuteNonQuery(sqlText, sqlParameter);
        }

        /*
         * 包材和供应商间联系
         */
        public void removeSupplierWithPackingMaterial(String packingMaterialNo)
        {
            String sqlText = "delete from supplierPackingMaterial where packingMaterialNo=@packingMaterialNo";
            SqlParameter[] sqlParameter = new SqlParameter[] {
                new SqlParameter("@packingMaterialNo",SqlDbType.VarChar)
            };
            sqlParameter[0].Value = packingMaterialNo;

            DBHelper.ExecuteNonQuery(sqlText, sqlParameter);
        }

        /*
         * 根据彩盒编号删除彩盒记录
         */
        public void removeCarton(String cartonNo)
        {
            String sqlText = "delete from carton where cartonNo=@cartonNo";
            SqlParameter[] sqlParameter = new SqlParameter[] {
                new SqlParameter("@cartonNo",SqlDbType.VarChar)
            };
            sqlParameter[0].Value = cartonNo;

            DBHelper.ExecuteNonQuery(sqlText,sqlParameter);
        }

        /*
         * 根据彩盒编号删除彩盒和供应商联系
         */
        public void removeSupplierWithCarton(String cartonNo)
        {
            String sqlText = "delete from supplierCarton where cartonNo=@cartonNo";
            SqlParameter[] sqlParameter = new SqlParameter[] {
                new SqlParameter("@cartonNo",SqlDbType.VarChar)
            };
            sqlParameter[0].Value = cartonNo;

            DBHelper.ExecuteNonQuery(sqlText, sqlParameter);
        }
    }
}
