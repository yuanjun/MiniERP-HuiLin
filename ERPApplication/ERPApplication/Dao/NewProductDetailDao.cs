using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Lib.SqlServerDAL;

namespace ERPApplication
{
    class NewProductDetailDao
    {
        /*
         * 查询彩妆类产品最大编码
         */
        public DataTable queryBiggestCosmeticsNo()
        {
            String sqlText = "select MAX(productNo) from product where productNo LIKE 'G01%'";
            return DBHelper.ExecuteQueryDT(sqlText);
        }

        /*
         * 查询眉笔类产品最大编码
         */
        public DataTable queryBiggestEyebrowPencilNo()
        {
            String sqlText = "select MAX(productNo) from product where productNo LIKE 'G02%'";
            return DBHelper.ExecuteQueryDT(sqlText);
        }

        /*
         * 查询周边类产品最大编码
         */
        public DataTable queryBiggestPeripheralNo()
        {
            String sqlText = "select MAX(productNo) from product where productNo LIKE 'G03%'";
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
         * 保存产品基本信息
         */
        public void insertProduct(Dictionary<String,String> productInfor)
        {
            StringBuilder sqlText = new StringBuilder("insert into product(");
            SqlParameter[] sqlParameter = new SqlParameter[productInfor.Count];

            foreach (var item in productInfor)
            {
                sqlText.Append(item.Key);
                sqlText.Append(",");
            }
            sqlText.Remove(sqlText.Length-1,1);
            sqlText.Append(") values(");

            int index = 0;
            foreach (var item in productInfor)
            {
                sqlText.Append("@");
                sqlText.Append(item.Key);
                sqlText.Append(",");

                if(item.Key == "sellingPrice" || item.Key == "value" || item.Key == "boxLength" ||
                   item.Key == "boxWidth" || item.Key == "boxHeight")
                {
                    sqlParameter[index] = new SqlParameter("@"+item.Key,SqlDbType.Decimal);
                    sqlParameter[index].Value = Convert.ToDecimal(item.Value);
                }
                else if (item.Key == "boxContain")
                {
                    sqlParameter[index] = new SqlParameter("@" + item.Key, SqlDbType.Decimal);
                    sqlParameter[index].Value = int.Parse(item.Value);
                }
                else
                {
                    sqlParameter[index] = new SqlParameter("@" + item.Key, SqlDbType.VarChar);
                    sqlParameter[index].Value = item.Value;
                }
                index++;
            }
            sqlText.Remove(sqlText.Length-1,1);
            sqlText.Append(")");

            DBHelper.ExecuteNonQuery(sqlText.ToString(),sqlParameter);
        }

        /*
         * 保存产品和供应商关系信息（实际是内容物的提供者）
         */
        public void insertSupplierOfProduct(int supplierNo,String productNo)
        {
            String sqlText = "insert into supplierProduct(supplierNo,productNo) values(@supplierNo,@productNo)";
            SqlParameter[] sqlParameter = new SqlParameter[] {
                new SqlParameter("@supplierNo",SqlDbType.Int),
                new SqlParameter("@productNo",SqlDbType.VarChar)
            };

            sqlParameter[0].Value = supplierNo;
            sqlParameter[1].Value = productNo;

            DBHelper.ExecuteNonQuery(sqlText,sqlParameter);
        }

    }
}
