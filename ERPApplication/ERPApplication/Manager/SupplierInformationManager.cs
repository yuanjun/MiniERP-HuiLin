using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ERPApplication
{
    class SupplierInformationManager
    {
        SupplierInformationDao supplierInformationDao = new SupplierInformationDao();

        /*
         * 查询供应商信息
         */
        public DataTable querySupplierInformation()
        {
            return supplierInformationDao.querySupplierInformation();
        }

        /*
         * 根据供应商编号查询供应商信息
         */
        public Dictionary<String, String> querySupplierInformationById(int supplierNo)
        {
            Dictionary<String, String> supplierInforDict = new Dictionary<String, String>();
            DataTable supplierInforTable = supplierInformationDao.querySupplierInformationById(supplierNo);
            if (supplierInforTable.Rows.Count > 0)
            {
                int columnCount = supplierInforTable.Columns.Count;
                for (int i = 0; i < columnCount; i++)
                {
                    String columnName = supplierInforTable.Columns[i].ColumnName;
                    String columnValue = supplierInforTable.Rows[0][i].ToString();
                    supplierInforDict.Add(columnName,columnValue);
                }
            }
            return supplierInforDict;
        }

    }
}
