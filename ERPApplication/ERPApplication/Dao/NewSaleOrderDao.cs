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
    class NewSaleOrderDao
    {
        /*
         * 查询销售订单表，返回“今日”、订单号最大的一个单号
         */
        public DataTable queryBiggestSaleOrderNo()
        {
            String sql = "select saleNo from activeSaleOrder where saleNo LIKE @saleNo ORDER BY saleNo DESC";
            SqlParameter[] sqlParameter = new SqlParameter[] { 
                new SqlParameter("@saleNo",SqlDbType.VarChar)
            };
            sqlParameter[0].Value = "SO-S" + DateTime.Now.ToString("yyyyMMdd") + "%";
            return DBHelper.ExecuteQueryDT(sql, sqlParameter);
        }

        /*
         * 查询全部客户信息
         */
        public DataTable queryClientInformation()
        {
            String sqlText = "select clientNo,name from client";
            return DBHelper.ExecuteQueryDT(sqlText);
        }

        /*
         * 根据客户id查询
         */
        public DataTable queryClientInformationById(int clientNo)
        {
            String sqlText = "select address,majorContact,telephone from client where clientNo=@clientNo";
            SqlParameter[] sqlParameter = new SqlParameter[]{
                new SqlParameter("@clientNo",SqlDbType.VarChar)
            };
            sqlParameter[0].Value = clientNo;
            return DBHelper.ExecuteQueryDT(sqlText, sqlParameter);
        }

        /*
         * 查询运输方式
         */
        public DataTable queryTransportMode()
        {
            String sqlText = "select id,name from transportMode";
            return DBHelper.ExecuteQueryDT(sqlText);
        }

        /*
         * 查询全部交易币种名称
         */
        public DataTable queryTradingCurrency()
        {
            String sqlText = "select id,name from tradingCurrency";
            return DBHelper.ExecuteQueryDT(sqlText);
        }

        /*
         * 根据id查询当前交易币种汇率
         */
        public DataTable queryTradingCurrencyById(int id)
        {
            String sqlText = "select exchangeRate from tradingCurrency where id=@id";
            SqlParameter[] sqlParameter = new SqlParameter[] { 
                new SqlParameter("@id",SqlDbType.VarChar)
            };
            sqlParameter[0].Value = id;
            return DBHelper.ExecuteQueryDT(sqlText, sqlParameter);
        }

        /*
         * 根据色号查询产品其他信息
         */
        public DataTable queryProductDetailByColorNo(String colorNo)
        {
            String sqlText = "select productNo,chineseName,factoryNo,inventory,sellingPrice from product where colorNo=@colorNo";
            SqlParameter[] sqlParameter = new SqlParameter[] {
                new SqlParameter("@colorNo",SqlDbType.VarChar)
            };
            sqlParameter[0].Value = colorNo;
            return DBHelper.ExecuteQueryDT(sqlText,sqlParameter);
        }

        /*
         * 将订单相关基本信息写入数据库
         */
        public void addSaleOrder(List<String> inforList)
        {
            String sqlText = "insert into activeSaleOrder values(@saleNo,@state,@clientNo,@startDate,@endDate,@transportModeId,@currencyId,@invoiceId,@remarks)";
            SqlParameter[] sqlParameter = new SqlParameter[] {
                new SqlParameter("@saleNo",SqlDbType.VarChar),
                new SqlParameter("@state",SqlDbType.VarChar),
                new SqlParameter("@clientNo",SqlDbType.Int),
                new SqlParameter("@startDate",SqlDbType.Date),
                new SqlParameter("@endDate",SqlDbType.Date),
                new SqlParameter("@transportModeId",SqlDbType.Int),
                new SqlParameter("@currencyId",SqlDbType.Int),
                new SqlParameter("@invoiceId",SqlDbType.VarChar),
                new SqlParameter("@remarks",SqlDbType.VarChar)
            };

            if (sqlParameter.Length == inforList.Count)
            {
                for (int i = 0; i < inforList.Count; i++)
                {
                    if (i == 2 || i == 5 || i == 6)
                    {
                        sqlParameter[i].Value = int.Parse(inforList[i]);
                    }
                    else
                    {
                        sqlParameter[i].Value = inforList[i];
                    }
                }
            }

            DBHelper.ExecuteQueryDT(sqlText,sqlParameter);
        }
    }
}
