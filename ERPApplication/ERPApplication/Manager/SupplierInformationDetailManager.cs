using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ERPApplication
{
    class SupplierInformationDetailManager
    {
        SupplierInformationDetailDao supplierInformationDetailDao = new SupplierInformationDetailDao();

        /*
         * 插入供应商
         */
        public void insertSupplier(Dictionary<String, String> supplierInformationDict)
        {
            DateTime current = DateTime.Now;
            supplierInformationDict.Add("createTime", current.ToString("yyyy-MM-dd HH:mm:ss"));
            supplierInformationDetailDao.insertSupplier(supplierInformationDict);
        }

        /*
         * 根据供应商编号更新供应商信息
         */
        public void updateSupplier(Dictionary<String, String> supplierInforDict, int supplierNo)
        {
            supplierInformationDetailDao.updateSupplier(supplierInforDict,supplierNo);
        }
    }
}
