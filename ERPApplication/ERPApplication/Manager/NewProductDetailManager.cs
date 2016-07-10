using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ERPApplication
{
    class NewProductDetailManager
    {
        NewProductDetailDao newProductDetailDao = new NewProductDetailDao();

        /*
         * 查询彩妆类产品最大编码
         */
        public String queryBiggestCosmeticsNo()
        {
            DataTable cosmeticsTable = newProductDetailDao.queryBiggestCosmeticsNo();
            if (cosmeticsTable.Rows.Count > 0 && !cosmeticsTable.Rows[0][0].Equals(DBNull.Value))
            {
                String s_productNo = cosmeticsTable.Rows[0][0].ToString();
                Int32 i_productNo = int.Parse(s_productNo.Substring(3,4));
                StringBuilder rst = new StringBuilder();
               
                if (i_productNo >= 1 && i_productNo <= 8)
                {
                    rst.Append("G01000");
                    rst.Append(Convert.ToString(i_productNo+1));
                }
                else if (i_productNo >= 9 && i_productNo <= 98)
                {
                    rst.Append("G0100");
                    rst.Append(Convert.ToString(i_productNo + 1));
                }
                else if (i_productNo >= 99 && i_productNo <= 998)
                {
                    rst.Append("G010");
                    rst.Append(Convert.ToString(i_productNo + 1));
                }
                else if (i_productNo >= 999 && i_productNo <= 9998)
                {
                    rst.Append("G01");
                    rst.Append(Convert.ToString(i_productNo + 1));
                }
                else
                {
                    rst.Append("error");
                }

                return rst.ToString();
            }
            else
            {
                return "G010001";
            }
        }

        /*
         * 查询眉笔类产品最大编码
         */
        public String queryBiggestEyebrowPencilNo()
        {
            DataTable eyebrowPencilTable = newProductDetailDao.queryBiggestEyebrowPencilNo();
            if (eyebrowPencilTable.Rows.Count > 0 && !eyebrowPencilTable.Rows[0][0].Equals(DBNull.Value))
            {
                String s_productNo = eyebrowPencilTable.Rows[0][0].ToString();
                Int32 i_productNo = int.Parse(s_productNo.Substring(3, 4));
                StringBuilder rst = new StringBuilder();

                if (i_productNo >= 1 && i_productNo <= 8)
                {
                    rst.Append("G02000");
                    rst.Append(Convert.ToString(i_productNo + 1));
                }
                else if (i_productNo >= 9 && i_productNo <= 98)
                {
                    rst.Append("G0200");
                    rst.Append(Convert.ToString(i_productNo + 1));
                }
                else if (i_productNo >= 99 && i_productNo <= 998)
                {
                    rst.Append("G020");
                    rst.Append(Convert.ToString(i_productNo + 1));
                }
                else if (i_productNo >= 999 && i_productNo <= 9998)
                {
                    rst.Append("G02");
                    rst.Append(Convert.ToString(i_productNo + 1));
                }
                else
                {
                    rst.Append("error");
                }

                return rst.ToString();
            }
            else
            {
                return "G020001";
            }
        }

        /*
         * 查询周边类产品最大编码
         */
        public String queryBiggestPeripheralNo()
        {
            DataTable peripheralTable = newProductDetailDao.queryBiggestPeripheralNo();
            if (peripheralTable.Rows.Count > 0 && !peripheralTable.Rows[0][0].Equals(DBNull.Value))
            {
                String s_productNo = peripheralTable.Rows[0][0].ToString();
                Int32 i_productNo = int.Parse(s_productNo.Substring(3, 4));
                StringBuilder rst = new StringBuilder();

                if (i_productNo >= 1 && i_productNo <= 8)
                {
                    rst.Append("G03000");
                    rst.Append(Convert.ToString(i_productNo + 1));
                }
                else if (i_productNo >= 9 && i_productNo <= 98)
                {
                    rst.Append("G0300");
                    rst.Append(Convert.ToString(i_productNo + 1));
                }
                else if (i_productNo >= 99 && i_productNo <= 998)
                {
                    rst.Append("G030");
                    rst.Append(Convert.ToString(i_productNo + 1));
                }
                else if (i_productNo >= 999 && i_productNo <= 9998)
                {
                    rst.Append("G03");
                    rst.Append(Convert.ToString(i_productNo + 1));
                }
                else
                {
                    rst.Append("error");
                }

                return rst.ToString();
            }
            else
            {
                return "G030001";
            }
        }

        /*
         * 查询供应商信息
         */
        public DataTable querySupplierInformation()
        {
            return newProductDetailDao.querySupplierInformation();
        }

        /*
         * 插入产品基本信息
         */
        public void insertProduct(Dictionary<String, String> productInfor)
        {
            newProductDetailDao.insertProduct(productInfor);
        }

        /*
         * 插入产品和供应商联系信息
         */
        public void insertSupplierOfProduct(int supplierNo, String productNo)
        {
            newProductDetailDao.insertSupplierOfProduct(supplierNo, productNo);
        }
    }
}
