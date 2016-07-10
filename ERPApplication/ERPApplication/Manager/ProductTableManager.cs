using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ERPApplication
{
    class ProductTableManager
    {
        ProductTableDao productTableDao = new ProductTableDao();

        /*
        * 获取产品固定信息(总体一起)
        */
        public DataTable queryStableProductInformation()
        {
            return productTableDao.queryStableProductInformation();
        }

        /*
         * 获取彩妆类产品固定信息
         */
        public DataTable queryStableCosmeticsInformation()
        {
            return productTableDao.queryStableCosmeticsInformation();
        }

        /*
         * 获取眉笔类产品固定信息
         */
        public DataTable queryStableEyeBrowPencilInformation()
        {
            return productTableDao.queryStableEyeBrowPencilInformation();
        }

        /*
         * 获取周边类产品固定信息
         */
        public DataTable queryStablePeripheralInformation()
        {
            return productTableDao.queryStablePeripheralInformation();
        }
    }
}
