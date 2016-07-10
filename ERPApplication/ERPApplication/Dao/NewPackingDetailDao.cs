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
    class NewPackingDetailDao
    {
        /*
         * 查询当前包材最大编号
         */
        public DataTable queryBiggestPackingMaterialNo()
        {
            String sqlText = "select MAX(packingMaterialNo) FROM packingMaterial";
            return DBHelper.ExecuteQueryDT(sqlText);
        }

        /*
         * 查询供应商信息
         */
        public DataTable querySupplierInformation()
        {
            String sqlText = "select supplierNo,name,majorContact,telephone,fax,address from supplier";
            return DBHelper.ExecuteQueryDT(sqlText);
        }

        /*
         * 插一种入新包材
         */
        public void insertNewPackingMaterial(Dictionary<String,String> packingMaterialDict)
        {
            StringBuilder sqlText = new StringBuilder("insert into packingMaterial(");
            SqlParameter[] sqlParameter = new SqlParameter[packingMaterialDict.Count];

            foreach (var item in packingMaterialDict)
            {
                sqlText.Append(item.Key);
                sqlText.Append(",");
            }
            sqlText.Remove(sqlText.Length-1,1);
            sqlText.Append(") values(");

            int index = 0;
            foreach (var item in packingMaterialDict)
            {
                sqlText.Append("@");
                sqlText.Append(item.Key);
                sqlText.Append(",");

                if (item.Key == "purchasePrice")        //采购价有小数
                {
                    sqlParameter[index] = new SqlParameter("@purchasePrice", SqlDbType.Decimal);
                    sqlParameter[index].Value = Convert.ToDecimal(item.Value);
                }
                else
                {
                    sqlParameter[index] = new SqlParameter("@"+item.Key,SqlDbType.VarChar);
                    sqlParameter[index].Value = item.Value;
                }
                index++;
            }
            sqlText.Remove(sqlText.Length - 1, 1);
            sqlText.Append(")");

            DBHelper.ExecuteNonQuery(sqlText.ToString(),sqlParameter);
        }

        /*
         * 将供应商和包材关系插入供应商-包材联系表
         */
        public void insertSupplierPackingMaterial(int supplierNo,String packingMaterialNo)
        {
            String sqlText = "insert into supplierPackingMaterial(supplierNo,packingMaterialNo) values(@supplierNo,@packingMaterialNo)";
            SqlParameter[] sqlParameter = new SqlParameter[] {
                new SqlParameter("@supplierNo",SqlDbType.Int),
                new SqlParameter("@packingMaterialNo",SqlDbType.VarChar)
            };
            sqlParameter[0].Value = supplierNo;
            sqlParameter[1].Value = packingMaterialNo;

            DBHelper.ExecuteNonQuery(sqlText,sqlParameter);
        }

        /*
         * 根据包材代码查询包材其他信息
         */
        public DataTable queryPackingMaterialInformationByNo(String packingMaterialNo)
        {
            String sqlText = "select packingMaterialNo,colorNo,factoryNo,chineseName,englishName,purchasePrice,description from packingMaterial where packingMaterialNo=@packingMaterialNo";
            SqlParameter[] sqlParameter = new SqlParameter[] {
                new SqlParameter("@packingMaterialNo",SqlDbType.VarChar)
            };
            sqlParameter[0].Value = packingMaterialNo;

            return DBHelper.ExecuteQueryDT(sqlText,sqlParameter);
        }

        /*
         * 根据包材代码查询供应商信息
         */
        public DataTable querySupplierOfPackingMaterialByNo(String packingMaterialNo)
        {
            StringBuilder sqlText = new StringBuilder("select B.supplierNo,name AS supplier,majorContact,telephone,fax,address from supplierPackingMaterial A,supplier B");
            sqlText.Append(" where A.packingMaterialNo=@packingMaterialNo and A.supplierNo=B.supplierNo");
            SqlParameter[] sqlParamter = new SqlParameter[] {
                new SqlParameter("@packingMaterialNo",SqlDbType.VarChar)
            };
            sqlParamter[0].Value = packingMaterialNo;

            return DBHelper.ExecuteQueryDT(sqlText.ToString(), sqlParamter);
        }

        /*
         * 更新一种包材的基本信息
         */
        public void updatePackingMaterialInformation(Dictionary<String, String> packingMaterialDict, String packingMaterialNo)
        {
            StringBuilder sqlText = new StringBuilder("update packingMaterial set ");
            SqlParameter[] sqlParameter = new SqlParameter[packingMaterialDict.Count+1];

            int index = 0;
            foreach (var item in packingMaterialDict)
            {
                sqlText.Append(item.Key);
                sqlText.Append("=@");
                sqlText.Append(item.Key);
                sqlText.Append(",");

                if (item.Key == "purchasePrice")        //采购价有小数
                {
                    sqlParameter[index] = new SqlParameter("@purchasePrice", SqlDbType.Decimal);
                    sqlParameter[index].Value = Convert.ToDecimal(item.Value);
                }
                else
                {
                    sqlParameter[index] = new SqlParameter("@" + item.Key, SqlDbType.VarChar);
                    sqlParameter[index].Value = item.Value;
                }
                index++;
            }
            sqlText.Remove(sqlText.Length-1,1);
            sqlText.Append(" where packingMaterialNo=@packingMaterialNo");

            sqlParameter[index] = new SqlParameter("@packingMaterialNo", SqlDbType.VarChar);
            sqlParameter[index].Value = packingMaterialNo;

            DBHelper.ExecuteNonQuery(sqlText.ToString(),sqlParameter);
        }
    }
}
