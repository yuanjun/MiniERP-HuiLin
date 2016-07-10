using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using Lib.SqlServerDAL;

/*
 * 已创建的销售订单（包括已删除的订单）Dao类
 */

namespace ERPApplication
{
    class CreatedOrderDao
    {
        /*
         * 查询固定状态的订单信息
         * flag为true表示对应state状态的订单信息；flag为false表示不为state状态的订单信息
         */
        public DataTable queryActiveSaleOrderInformationByState(String state, bool flag)
        {
            //查询订单编号、订单状态、客户名称、订单日期、运输方式、交易币种、备注
            StringBuilder sqlText = new StringBuilder("select A.saleNo,A.state,B.name,A.startDate,C.name AS transportName,D.name AS currencyName,A.remarks ");
            sqlText.Append("from activeSaleOrder A,client B,transportMode C,tradingCurrency D ");
            if (flag == true)
            {
                sqlText.Append("where A.state=@state AND A.clientNo=B.clientNo AND A.transportModeId=C.id AND A.currencyId=D.id ");
            }
            else
            {
                sqlText.Append("where A.state<>@state AND A.clientNo=B.clientNo AND A.transportModeId=C.id AND A.currencyId=D.id ");
            }
            sqlText.Append("order by A.startDate DESC");
            SqlParameter[] sqlParameter = new SqlParameter[] { 
                new SqlParameter("@state",SqlDbType.VarChar)
            };
            sqlParameter[0].Value = state;
            return DBHelper.ExecuteQueryDT(sqlText.ToString(), sqlParameter);
        }

        /*
         * 按时间倒序查询删除订单的信息
         */
        public DataTable queryRemovedSaleOrderInformation()
        {
            //查询订单编号、订单状态、客户名称、订单日期、运输方式、交易币种、备注
            StringBuilder sqlText = new StringBuilder("select A.saleNo,A.state,B.name,A.startDate,C.name AS transportName,D.name AS currencyName,A.remarks ");
            sqlText.Append("from removedSaleOrder A,client B,transportMode C,tradingCurrency D ");
            sqlText.Append("where A.clientNo=B.clientNo AND A.transportModeId=C.id AND A.currencyId=D.id ");
            sqlText.Append("order by A.startDate DESC");
            return DBHelper.ExecuteQueryDT(sqlText.ToString());
        }

        /*
         * 根据订单编号删除一个订单
         */
        public void removeSaleOrderByOrderNo(String orderNo)
        {
            String sqlText = "delete from activeSaleOrder where saleNo=@saleNo";
            SqlParameter[] sqlParameter = new SqlParameter[] {
                new SqlParameter("@saleNo",SqlDbType.VarChar)
            };
            sqlParameter[0].Value = orderNo;
            DBHelper.ExecuteNonQuery(sqlText,sqlParameter);
        }

        /*
         * 根据activeSaleOrder一项的id，向“已删除订单”表中插入一条记录
         */
        public void addSaleOrderItem(String orderNo)
        {
            String sqlText = "select * from activeSaleOrder where saleNo=@saleNo";
            SqlParameter[] sqlParameter = new SqlParameter[] {
                new SqlParameter("@saleNo",SqlDbType.VarChar)
            };
            sqlParameter[0].Value = orderNo;
            DataTable saleOrderTable = DBHelper.ExecuteQueryDT(sqlText,sqlParameter);

            int rowCount = saleOrderTable.Rows.Count;
            int columnCount = saleOrderTable.Columns.Count;

            if (rowCount >= 1)
            {
                String sqlText2 = "insert into removedSaleOrder values(@saleNo,@state,@clientNo,@startDate,@endDate,@transportId,@currencyId,@invoiceId,@remarks)";
                SqlParameter[] sqlParameter2 = new SqlParameter[] {
                    new SqlParameter("@saleNo",SqlDbType.VarChar),
                    new SqlParameter("@state",SqlDbType.VarChar),
                    new SqlParameter("@clientNo",SqlDbType.Int),
                    new SqlParameter("@startDate",SqlDbType.Date),
                    new SqlParameter("@endDate",SqlDbType.Date),
                    new SqlParameter("@transportId",SqlDbType.Int),
                    new SqlParameter("@currencyId",SqlDbType.Int),
                    new SqlParameter("@invoiceId",SqlDbType.Int),
                    new SqlParameter("@remarks",SqlDbType.VarChar)
                };
                for (int i = 0; i < columnCount; i++)
                {
                    sqlParameter2[i].Value = saleOrderTable.Rows[0].ItemArray[i];
                }
                DBHelper.ExecuteNonQuery(sqlText2,sqlParameter2);
            }
        }
    }
}
