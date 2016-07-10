using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Lib.SqlServerDAL;

namespace ERPApplication
{
    class NewCartonDetailDao
    {
        /*
         * 查询当前最大的彩盒编号
         */
        public DataTable queryBiggestCartonNo()
        {
            String sqlText = "select Max(cartonNo) from carton";
            return DBHelper.ExecuteQueryDT(sqlText);
        }

        /*
         * 查询供应商相关信息
         */
        public DataTable querySupplierInformation()
        {
            String sqlText = "select supplierNo,name,majorContact,telephone,fax,address from supplier";
            return DBHelper.ExecuteQueryDT(sqlText);
        }

        /*
         * 将彩盒信息插入数据库
         */
        public void insertNewCarton(Dictionary<String,String> cartonInforDict)
        {
            StringBuilder sqlText = new StringBuilder("insert into carton(");
            SqlParameter[] sqlParameter = new SqlParameter[cartonInforDict.Count];

            foreach (var item in cartonInforDict)
            {
                sqlText.Append(item.Key);
                sqlText.Append(",");
            }
            sqlText.Remove(sqlText.Length-1,1);     //移除多余的逗号
            sqlText.Append(") values(");

            int index = 0;
            foreach (var item in cartonInforDict)
            {
                sqlText.Append("@");
                sqlText.Append(item.Key);
                sqlText.Append(",");

                if(item.Key == "length" || item.Key == "width" || item.Key == "height")
                {
                    sqlParameter[index] = new SqlParameter("@" + item.Key, SqlDbType.Int);
                    sqlParameter[index].Value = int.Parse(item.Value);
                }
                else if (item.Key == "purchasePrice")
                {
                    sqlParameter[index] = new SqlParameter("@" + item.Key, SqlDbType.Decimal);
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
            sqlText.Append(")");

            DBHelper.ExecuteNonQuery(sqlText.ToString(),sqlParameter);
        }

        /*
         * 将彩盒和供应商联系插入数据库
         */
        public void insertSupplierCarton(int supplierNo, String cartonNo)
        {
            String sqlText = "insert into supplierCarton(supplierNo,cartonNo) values(@supplierNo,@cartonNo)";
            SqlParameter[] sqlParameter = new SqlParameter[] {
                new SqlParameter("@supplierNo",SqlDbType.Int),
                new SqlParameter("@cartonNo",SqlDbType.VarChar)
            };

            sqlParameter[0].Value = supplierNo;
            sqlParameter[1].Value = cartonNo;

            DBHelper.ExecuteNonQuery(sqlText,sqlParameter);
        }

        /*
         * 根据彩盒编号查询彩盒信息
         */
        public DataTable queryCartonInformationByCartonNo(String cartonNo)
        {
            String sqlText = "select cartonNo,chineseName,englishName,purchasePrice,length,width,height,colorNo,factoryNo,description from carton where cartonNo=@cartonNo";
            SqlParameter[] sqlParameter = new SqlParameter[] {
                new SqlParameter("@cartonNo",SqlDbType.VarChar)
            };
            sqlParameter[0].Value = cartonNo;

            return DBHelper.ExecuteQueryDT(sqlText,sqlParameter);
        }

        /*
         * 根据彩盒编号查询供应商信息
         */
        public DataTable querySupplierOfCartonByCartonNo(String cartonNo)
        {
            StringBuilder sqlText = new StringBuilder("select A.supplierNo,B.name as supplier,B.majorContact,B.telephone,B.fax,B.address from supplierCarton A,supplier B");
            sqlText.Append(" where A.cartonNo=@cartonNo AND A.supplierNo=B.supplierNo");

            SqlParameter[] sqlParameter = new SqlParameter[] {
                new SqlParameter("@cartonNo",SqlDbType.VarChar)
            };
            sqlParameter[0].Value = cartonNo;

            return DBHelper.ExecuteQueryDT(sqlText.ToString(),sqlParameter);
        }

        /*
         * 根据彩盒编号修改相应信息
         */
        public void updateCartonInformationByCartonNo(String cartonNo, Dictionary<String, String> cartonInforDict)
        {
            StringBuilder sqlText = new StringBuilder("update carton set ");
            SqlParameter[] sqlParameter = new SqlParameter[cartonInforDict.Count+1];

            int index = 0;
            foreach (var item in cartonInforDict)
            {
                sqlText.Append(item.Key);
                sqlText.Append("=@");
                sqlText.Append(item.Key);
                sqlText.Append(",");

                if (item.Key == "length" || item.Key == "width" || item.Key == "height")
                {
                    sqlParameter[index] = new SqlParameter("@" + item.Key, SqlDbType.Int);
                    sqlParameter[index].Value = int.Parse(item.Value);
                }
                else if (item.Key == "purchasePrice")
                {
                    sqlParameter[index] = new SqlParameter("@" + item.Key, SqlDbType.Decimal);
                    sqlParameter[index].Value = Convert.ToDecimal(item.Value);
                }
                else
                {
                    sqlParameter[index] = new SqlParameter("@" + item.Key, SqlDbType.VarChar);
                    sqlParameter[index].Value = item.Value;
                }
                index++;
            }
            sqlText.Remove(sqlText.Length-1,1);         //移除多余的逗号
            sqlText.Append(" where cartonNo=@cartonNo");

            sqlParameter[index] = new SqlParameter("@cartonNo",SqlDbType.VarChar);
            sqlParameter[index].Value = cartonNo;

            DBHelper.ExecuteNonQuery(sqlText.ToString(),sqlParameter);
        }
    }
}
