using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ERPApplication
{
    class NewCartonDetailManager
    {
        NewCartonDetailDao newCartonDetailDao = new NewCartonDetailDao();

        /*
         * 根据当前最大的彩盒编号，返回可用的最大编号
         */
        public String queryBiggestCartonNo()
        {
            DataTable cartonTable = newCartonDetailDao.queryBiggestCartonNo();

            if (cartonTable.Rows.Count > 0 && !cartonTable.Rows[0][0].Equals(DBNull.Value))
            {
                String s_index = cartonTable.Rows[0][0].ToString().Substring(1, 4);
                Int32 i_index = int.Parse(s_index);
                StringBuilder cartonNo = new StringBuilder();
                if (i_index >= 1 && i_index <= 8)
                {
                    cartonNo.Append("B000");
                    cartonNo.Append(Convert.ToString(i_index+1));
                }
                else if (i_index >= 9 && i_index <= 98)
                {
                    cartonNo.Append("B00");
                    cartonNo.Append(Convert.ToString(i_index + 1));
                }
                else if (i_index >= 99 && i_index <= 998)
                {
                    cartonNo.Append("B0");
                    cartonNo.Append(Convert.ToString(i_index + 1));
                }
                else if (i_index >= 999 && i_index <= 9998)
                {
                    cartonNo.Append("B");
                    cartonNo.Append(Convert.ToString(i_index + 1));
                }
                else
                {
                    cartonNo.Append("error");
                }

                return cartonNo.ToString();
            }
            else
            {
                return "B0001";
            }
        }

        /*
         * 获取供应商信息
         */
        public DataTable querySupplierInformation()
        {
            return newCartonDetailDao.querySupplierInformation();
        }

        /*
         * 插入新彩盒信息
         */
        public void insertNewCarton(Dictionary<String, String> cartonInforDict)
        {
            newCartonDetailDao.insertNewCarton(cartonInforDict);
        }

        /*
         * 将彩盒和供应商联系插入数据库
         */
        public void insertSupplierCarton(int supplierNo,String cartonNo)
        {
            newCartonDetailDao.insertSupplierCarton(supplierNo,cartonNo);
        }

        /*
         * 根据彩盒编号查询彩盒信息
         */
        public Dictionary<String,String> queryCartonInformationByCartonNo(String cartonNo)
        {
            Dictionary<String, String> cartonInforDict = new Dictionary<String, String>();
            DataTable cartonInforTable = newCartonDetailDao.queryCartonInformationByCartonNo(cartonNo);

            if (cartonInforTable.Rows.Count > 0)
            {
                DataRow firstRow = cartonInforTable.Rows[0];
                int columnCount = cartonInforTable.Columns.Count;
                for (int i = 0; i < columnCount; i++)
                {
                    cartonInforDict.Add(cartonInforTable.Columns[i].ColumnName,firstRow[i].ToString());
                }
            }

            return cartonInforDict;
        }

        /*
         * 根据彩盒编号查询供应商信息
         */
        public Dictionary<String, String> querySupplierOfCartonByCartonNo(String cartonNo)
        {
            Dictionary<String, String> supplierInforDict = new Dictionary<String, String>();
            DataTable supplierInforTable = newCartonDetailDao.querySupplierOfCartonByCartonNo(cartonNo);

            if (supplierInforTable.Rows.Count > 0)
            {
                DataRow firstRow = supplierInforTable.Rows[0];
                int columnCount = supplierInforTable.Columns.Count;
                for (int i = 0; i < columnCount; i++)
                {
                    supplierInforDict.Add(supplierInforTable.Columns[i].ColumnName,firstRow[i].ToString());
                }
            }

            return supplierInforDict;
        }

        /*
         * 根据彩盒编号修改相应信息
         */
        public void updateCartonInformationByCartonNo(String cartonNo,Dictionary<String,String>cartonInforDict)
        {
            newCartonDetailDao.updateCartonInformationByCartonNo(cartonNo, cartonInforDict);
        }
    }
}
