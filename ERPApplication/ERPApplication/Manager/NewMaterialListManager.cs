using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ERPApplication
{
    class NewMaterialListManager
    {
        NewMaterialListDao newMaterialListDao = new NewMaterialListDao();
        
        /*
         * 获取彩盒库存总数
         */
        public int getCartonCount()
        {
            DataTable cartonTable = newMaterialListDao.getCartonCount();
            if (cartonTable.Rows.Count > 0 && !cartonTable.Rows[0][0].Equals(DBNull.Value))
            {
                return int.Parse(cartonTable.Rows[0][0].ToString());
            }
            return 0;
        }

        /*
         * 获取包材库存总数
         */
        public int getPackingMaterialCount()
        {
            DataTable packingMaterialTable = newMaterialListDao.getPackingMaterialCount();
            if (packingMaterialTable.Rows.Count > 0 && !packingMaterialTable.Rows[0][0].Equals(DBNull.Value))
            {
                return int.Parse(packingMaterialTable.Rows[0][0].ToString());
            }
            return 0;
        }

        /*
         * 获取彩盒详细信息
         */
        public DataTable getCartonInformation()
        {
            DataTable cartonTable = newMaterialListDao.getCartonInformation();      //不包含供应商的彩盒信息
            DataTable cartonSupplierTable = newMaterialListDao.getCartonSupplier(); //彩盒编号和供应商名关系

            Dictionary<String, String> cartonSuppliers = new Dictionary<String, String>();
            foreach (DataRow row in cartonSupplierTable.Rows)
            {
                if (!row[0].Equals(DBNull.Value) && !row[1].Equals(DBNull.Value))
                {
                    if (cartonSuppliers.ContainsKey(row[0].ToString()))     //如果已经包含一个cartonNo对应的supplier,则连接
                    {
                        StringBuilder tmp = new StringBuilder(cartonSuppliers[row[0].ToString()]);
                        tmp.Append(";");
                        tmp.Append(row[1].ToString());
                        cartonSuppliers[row[0].ToString()] = tmp.ToString();
                    }
                    else
                    {
                        cartonSuppliers.Add(row[0].ToString(),row[1].ToString());
                    }
                }
            }

            cartonTable.Columns.Add(new DataColumn("supplierName", typeof(String)));
            foreach (DataRow row in cartonTable.Rows)
            {
                if (!row[0].Equals(DBNull.Value))
                {
                    row["supplierName"] = cartonSuppliers[row[0].ToString()];
                }
            }

            return cartonTable;
        }

        /*
         * 获取包材详细信息
         */
        public DataTable getPackingMaterialInformation()
        {
            DataTable packingMaterialTable = newMaterialListDao.getPackingMaterialInformation();      //不包含供应商的包材信息
            DataTable packingMaterialSupplierTable = newMaterialListDao.getPackingMaterialSupplier(); //包材编号和供应商名关系

            Dictionary<String, String> packingMaterialSuppliers = new Dictionary<String, String>();
            foreach (DataRow row in packingMaterialSupplierTable.Rows)
            {
                if (!row[0].Equals(DBNull.Value) && !row[1].Equals(DBNull.Value))
                {
                    if (packingMaterialSuppliers.ContainsKey(row[0].ToString()))     //如果已经包含一个packingMaterialNo对应的supplier,则连接
                    {
                        StringBuilder tmp = new StringBuilder(packingMaterialSuppliers[row[0].ToString()]);
                        tmp.Append(";");
                        tmp.Append(row[1].ToString());
                        packingMaterialSuppliers[row[0].ToString()] = tmp.ToString();
                    }
                    else
                    {
                        packingMaterialSuppliers.Add(row[0].ToString(), row[1].ToString());
                    }
                }
            }

            packingMaterialTable.Columns.Add(new DataColumn("supplierName", typeof(String)));
            foreach (DataRow row in packingMaterialTable.Rows)
            {
                if (!row[0].Equals(DBNull.Value))
                {
                    row["supplierName"] = packingMaterialSuppliers[row[0].ToString()];
                }
            }

            return packingMaterialTable;
        }

        /*
         * 删除一条包材记录
         */
        public void removePackingMaterial(String packingMaterialNo)
        {
            newMaterialListDao.removePackingMaterial(packingMaterialNo);
        }

        /*
         * 包材和供应商间联系
         */
        public void removeSupplierWithPackingMaterial(String packingMaterialNo)
        {
            newMaterialListDao.removeSupplierWithPackingMaterial(packingMaterialNo);
        }

        /*
         * 根据彩盒编号删除彩盒记录
         */
        public void removeCarton(String cartonNo)
        {
            newMaterialListDao.removeCarton(cartonNo);
        }

        /*
         * 根据彩盒编号删除彩盒和供应商联系
         */
        public void removeSupplierWithCarton(String cartonNo)
        {
            newMaterialListDao.removeSupplierWithCarton(cartonNo);
        }
    }
}
