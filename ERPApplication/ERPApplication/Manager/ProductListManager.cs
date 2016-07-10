using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ERPApplication
{
    class ProductListManager
    {
        ProductListDao productListDao = new ProductListDao();
        /*
        * 查询全部产品信息，先按类别排序，然后按名称排序
        */
        public DataTable queryProductInformation()
        {
            return productListDao.queryProductInformation();
        }

        /*
         * 查询彩妆类产品信息
         */
        public DataTable queryCosmeticsInformation()
        {
            return productListDao.queryCosmeticsInformation();
        }

        /*
         * 查询眉笔类产品信息
         */
        public DataTable queryEyeBrowPencilInformation()
        {
            return productListDao.queryEyeBrowPencilInformation();
        }

        /*
         * 查询周边类产品信息
         */
        public DataTable queryPeripheralInformation()
        {
            return productListDao.queryPeripheralInformation();
        }
    }
}
