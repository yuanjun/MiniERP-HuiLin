using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ERPApplication
{
    class NewProductListManager
    {
        NewProductListDao newProductListDao = new NewProductListDao();

        /*
         * 获取当前库存彩妆类产品总数
         */
        public int getCosmeticsCount()
        {
            DataTable cosmeticsTable = newProductListDao.getCosmeticsCount();
            if (cosmeticsTable.Rows.Count > 0 && !cosmeticsTable.Rows[0][0].Equals(DBNull.Value))
            {
                return int.Parse(cosmeticsTable.Rows[0][0].ToString());
            }
            return 0;
        }

        /*
         * 获取当前库存眉笔类产品总数
         */
        public int getEyebrowPencilCount()
        {
            DataTable eyebrowPencilTable = newProductListDao.getEyebrowPencilCount();
            if (eyebrowPencilTable.Rows.Count > 0 && !eyebrowPencilTable.Rows[0][0].Equals(DBNull.Value))
            {
                return int.Parse(eyebrowPencilTable.Rows[0][0].ToString());
            }
            return 0;
        }

        /*
         * 获取当前库存周边类产品总数
         */
        public int getPeripheralCount()
        {
            DataTable peripheralTable = newProductListDao.getPeripheralCount();
            if (peripheralTable.Rows.Count > 0 && !peripheralTable.Rows[0][0].Equals(DBNull.Value))
            {
                return int.Parse(peripheralTable.Rows[0][0].ToString());
            }
            return 0;
        }

        /*
         * 获取当前产品总数
         */
        public int getProductSum()
        {
            DataTable cosmeticsTable = newProductListDao.getCosmeticsCount();
            DataTable eyebrowPencilTable = newProductListDao.getEyebrowPencilCount();
            DataTable peripheralTable = newProductListDao.getPeripheralCount();

            int cosmeticsCount = 0;
            int eyebrowPencil = 0;
            int peripheral = 0;

            if (cosmeticsTable.Rows.Count > 0 && !cosmeticsTable.Rows[0][0].Equals(DBNull.Value))
            {
                cosmeticsCount = int.Parse(cosmeticsTable.Rows[0][0].ToString());
            }
            if (eyebrowPencilTable.Rows.Count > 0 && !eyebrowPencilTable.Rows[0][0].Equals(DBNull.Value))
            {
                eyebrowPencil = int.Parse(eyebrowPencilTable.Rows[0][0].ToString());
            }
            if (peripheralTable.Rows.Count > 0 && !peripheralTable.Rows[0][0].Equals(DBNull.Value))
            {
                peripheral = int.Parse(peripheralTable.Rows[0][0].ToString());
            }

            return (cosmeticsCount + eyebrowPencil + peripheral);
        }

        /*
         * 获取彩妆类产品详细信息
         */
        public DataTable getCosmeticsInformatin()
        {
            DataTable cosmeticsTable = newProductListDao.getCosmeticsInformation();
            DataTable productSupplierTable = newProductListDao.getProductSupplier();

            Dictionary<String, String> cosmeticsDict = new Dictionary<String, String>();
            foreach (DataRow row in productSupplierTable.Rows)
            {
                if (!row[0].Equals(DBNull.Value) && !row[1].Equals(DBNull.Value))
                {
                    if (cosmeticsDict.ContainsKey(row[0].ToString()))
                    {
                        StringBuilder tmp = new StringBuilder(cosmeticsDict[row[0].ToString()]);
                        tmp.Append(";");
                        tmp.Append(row[1].ToString());
                        cosmeticsDict[row[0].ToString()] = tmp.ToString();
                    }
                    else
                    {
                        cosmeticsDict[row[0].ToString()] = row[1].ToString();
                    }
                }
            }

            cosmeticsTable.Columns.Add("supplierName",typeof(String));
            foreach (DataRow row in cosmeticsTable.Rows)
            {
                row["supplierName"] = cosmeticsDict[row[0].ToString()];
            }

            return cosmeticsTable;
        }

        /*
         * 获取眉笔类产品详细信息
         */
        public DataTable getEyebrowPencilInformation()
        {
            DataTable eyebrowPencilTable = newProductListDao.getEyebrowPencilInformation();
            DataTable productSupplierTable = newProductListDao.getProductSupplier();

            Dictionary<String, String> eyebrowPencilDict = new Dictionary<String, String>();
            foreach (DataRow row in productSupplierTable.Rows)
            {
                if (!row[0].Equals(DBNull.Value) && !row[1].Equals(DBNull.Value))
                {
                    if (eyebrowPencilDict.ContainsKey(row[0].ToString()))
                    {
                        StringBuilder tmp = new StringBuilder(eyebrowPencilDict[row[0].ToString()]);
                        tmp.Append(";");
                        tmp.Append(row[1].ToString());
                        eyebrowPencilDict[row[0].ToString()] = tmp.ToString();
                    }
                    else
                    {
                        eyebrowPencilDict[row[0].ToString()] = row[1].ToString();
                    }
                }
            }

            eyebrowPencilTable.Columns.Add("supplierName", typeof(String));
            foreach (DataRow row in eyebrowPencilTable.Rows)
            {
                row["supplierName"] = eyebrowPencilDict[row[0].ToString()];
            }

            return eyebrowPencilTable;
        }

        /*
         * 获取周边类产品详细信息
         */
        public DataTable getPeripheralInformation()
        {
            DataTable peripheralTable = newProductListDao.getPeripheralInformation();
            DataTable productSupplierTable = newProductListDao.getProductSupplier();

            Dictionary<String, String> peripheralDict = new Dictionary<String, String>();
            foreach (DataRow row in productSupplierTable.Rows)
            {
                if (!row[0].Equals(DBNull.Value) && !row[1].Equals(DBNull.Value))
                {
                    if (peripheralDict.ContainsKey(row[0].ToString()))
                    {
                        StringBuilder tmp = new StringBuilder(peripheralDict[row[0].ToString()]);
                        tmp.Append(";");
                        tmp.Append(row[1].ToString());
                        peripheralDict[row[0].ToString()] = tmp.ToString();
                    }
                    else
                    {
                        peripheralDict[row[0].ToString()] = row[1].ToString();
                    }
                }
            }

            peripheralTable.Columns.Add("supplierName", typeof(String));
            foreach (DataRow row in peripheralTable.Rows)
            {
                row["supplierName"] = peripheralDict[row[0].ToString()];
            }

            return peripheralTable;
        }
    }
}
