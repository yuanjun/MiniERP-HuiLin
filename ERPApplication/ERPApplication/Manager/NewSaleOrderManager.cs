using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ERPApplication
{
    class NewSaleOrderManager
    {
        private NewSaleOrderDao newSaleOrderDao = new NewSaleOrderDao();

        /*
         * 根据当前最大的销售订单编号，生成新的编号
         */
        public String getSaleOrderNo()
        {
            DataTable dataTable = newSaleOrderDao.queryBiggestSaleOrderNo();
            String today = DateTime.Now.ToString("yyyyMMdd");
            if (dataTable.Rows.Count <= 0)
            {
                return "SO-S" + today + "01";
            }
            else
            {
                String oldTop = dataTable.Rows[0][0].ToString();
                int realOrderNo = int.Parse(oldTop.Substring(oldTop.Length-2,2));
                if (realOrderNo >= 9 && realOrderNo < 99)
                {
                    return "SO-S" + today + Convert.ToString(realOrderNo + 1);
                }
                else if (realOrderNo < 9 && realOrderNo >= 1)
                {
                    return "SO-S" + today + "0" + Convert.ToString(realOrderNo + 1);
                }
                else
                {
                    return "error";
                }
            }
        }

        /*
         * 查询所有客户名称
         */
        public Dictionary<String,int> queryClientInformation()
        {
            Dictionary<String,int> clientMap = new Dictionary<String,int>();
            DataTable clientInfor = newSaleOrderDao.queryClientInformation();
            foreach (DataRow row in clientInfor.Rows)
            {
                clientMap.Add(row[1].ToString(),int.Parse(row[0].ToString()));
            }
            return clientMap;
        }

        /*
         * 根据客户id查询客户其他信息
         */
        public List<String> queryClientInformationById(int id)
        {
            List<String> otherInforList = new List<String>();
            DataTable otherInfor = newSaleOrderDao.queryClientInformationById(id);
            if (otherInfor.Rows.Count > 0)
            {
                otherInforList.Add(otherInfor.Rows[0][0].ToString());
                otherInforList.Add(otherInfor.Rows[0][1].ToString());
                otherInforList.Add(otherInfor.Rows[0][2].ToString());
            }
            return otherInforList;
        }

        /*
         * 查询所有交易币种名称
         */
        public Dictionary<String, int> queryTradingCurrency()
        {
            Dictionary<String, int> tradingCurrencyDict = new Dictionary<String, int>();
            DataTable tradingCurrencyInfor = newSaleOrderDao.queryTradingCurrency();
            foreach (DataRow row in tradingCurrencyInfor.Rows)
            {
                tradingCurrencyDict.Add(row[1].ToString(),int.Parse(row[0].ToString()));
            }
            return tradingCurrencyDict;
        }

        /*
         * 根据交易币种id查询汇率
         */
        public float queryTradingCurrencyById(int id)
        {
            float currencyRate = 0.0f;
            DataTable currencyTable = newSaleOrderDao.queryTradingCurrencyById(id);
            if (currencyTable.Rows.Count > 0)
            {
                currencyRate = float.Parse(currencyTable.Rows[0][0].ToString());
            }
            return currencyRate;
        }

        /*
         * 查询运输方式
         */
        public Dictionary<String, int> queryTransportMode()
        {
            Dictionary<String, int> transportModeDict = new Dictionary<String, int>();
            DataTable transportModeInfor = newSaleOrderDao.queryTransportMode();
            foreach (DataRow row in transportModeInfor.Rows)
            {
                transportModeDict.Add(row[1].ToString(),int.Parse(row[0].ToString()));
            }
            return transportModeDict;
        }

        /*
         * 构造客户订单表
         */
        private DataTable buildOrderProductList()
        {
            DataTable orderProductList = new DataTable();

            orderProductList.Columns.Add("productNo", typeof(String));
            orderProductList.Columns.Add("name",      typeof(String));
            orderProductList.Columns.Add("colorNo",   typeof(String));
            orderProductList.Columns.Add("factoryNo", typeof(String));
            orderProductList.Columns.Add("inventory", typeof(String));
            orderProductList.Columns.Add("number",    typeof(String));
            orderProductList.Columns.Add("unitPrice", typeof(String));
            orderProductList.Columns.Add("money",     typeof(String));

            return orderProductList;
        }

        /*
         * 根据色号查询产品其他信息
         */
        public DataTable getOrderProductListInfor(DataTable excelTable)
        {  
            DataTable orderProductList = buildOrderProductList();
            Double sumMoney = 0.0;
            foreach (DataRow row in excelTable.Rows)
            {
                if (!row[0].Equals(DBNull.Value) && !row[1].Equals(DBNull.Value))
                {
                    DataTable otherInfor = newSaleOrderDao.queryProductDetailByColorNo(row[0].ToString());
                    if (otherInfor.Rows.Count > 0)
                    {
                        Object[] parament = new Object[] {
                            otherInfor.Rows[0][0],
                            otherInfor.Rows[0][1],
                            row[0].ToString(),
                            otherInfor.Rows[0][2],
                            otherInfor.Rows[0][3],
                            row[1].ToString(),
                            otherInfor.Rows[0][4],
                            Convert.ToString(int.Parse(row[1].ToString())*Convert.ToDouble(otherInfor.Rows[0][4]))
                        };
                        orderProductList.Rows.Add(parament);
                        sumMoney += int.Parse(row[1].ToString()) * Convert.ToDouble(otherInfor.Rows[0][4]);
                    }
                    else
                    {
                        Object[] parament = new Object[] {
                            "-","-",row[0].ToString(),"-","0",row[1].ToString(),"-","-"
                        };
                        orderProductList.Rows.Add(parament);
                    }
                }
            }

            Object[] param = new Object[] {
                "","","","","","","总计金额：","$"+Convert.ToString(sumMoney)
            };
            orderProductList.Rows.Add(param);

            return orderProductList;
        }

        /*
         * 将订单相关基本信息写入数据库
         */
        public void addSaleOrder(List<String> inforList)
        {
            newSaleOrderDao.addSaleOrder(inforList);
        }
    }
}
