using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ERPApplication
{
    class NewPackingDetailManager
    {
        NewPackingDetailDao newPackingDetailDao = new NewPackingDetailDao();

        /*
         * 根据当前包材最大编号，返回可用最大编号
         */
        public String queryBiggestPackingMaterialNo()
        {
            StringBuilder rst = new StringBuilder();
            DataTable packingMaterialTable = newPackingDetailDao.queryBiggestPackingMaterialNo();
            if (packingMaterialTable.Rows.Count > 0 && !packingMaterialTable.Rows[0][0].Equals(DBNull.Value))
            {
                String packingMaterialNoChar = packingMaterialTable.Rows[0][0].ToString();
                int packingMaterialInt = int.Parse(packingMaterialNoChar.Substring(1,4));
                if (packingMaterialInt >= 1 && packingMaterialInt <= 8)
                {
                    rst.Append("W000");
                    rst.Append(Convert.ToString(packingMaterialInt + 1));
                }
                else if (packingMaterialInt >= 9 && packingMaterialInt <= 98)
                {
                    rst.Append("W00");
                    rst.Append(Convert.ToString(packingMaterialInt + 1));
                }
                else if (packingMaterialInt >= 99 && packingMaterialInt <= 998)
                {
                    rst.Append("W0");
                    rst.Append(Convert.ToString(packingMaterialInt + 1));
                }
                else if (packingMaterialInt >= 999 && packingMaterialInt <= 9998)
                {
                    rst.Append("W");
                    rst.Append(Convert.ToString(packingMaterialInt + 1));
                }
                else
                {
                    rst.Append("error");
                }
                return rst.ToString();
            }
            else
            {
                return "W0001";
            }
        }

        /*
         * 查询供应商信息
         */
        public DataTable querySupplierInformation()
        {
            return newPackingDetailDao.querySupplierInformation();
        }

        /*
         * 插入一项新包材，同时记录其和供应商间的联系
         */
        public void insertNewPackingMaterial(Dictionary<String,String> packingMaterialDict,int supplierNo)
        {
            newPackingDetailDao.insertNewPackingMaterial(packingMaterialDict);
            newPackingDetailDao.insertSupplierPackingMaterial(supplierNo,packingMaterialDict["packingMaterialNo"]);
        }

        /*
         * 根据包材代码查询包材基本信息
         */
        public Dictionary<String, String> queryPackingMaterialInformationByNo(String packingMaterialNo)
        {
            DataTable packingMaterialInforTable = newPackingDetailDao.queryPackingMaterialInformationByNo(packingMaterialNo);
            Dictionary<String, String> packingMaterialDict = new Dictionary<String, String>();
            if (packingMaterialInforTable.Rows.Count > 0)
            {
                //理论上一个包材代码只会对应一行记录
                DataRow currentRow = packingMaterialInforTable.Rows[0];
                int columnCount = currentRow.ItemArray.Length;
                for (int i = 0; i < columnCount; i++)
                {
                    packingMaterialDict.Add(packingMaterialInforTable.Columns[i].ColumnName,currentRow[i].ToString());
                }
            }

            return packingMaterialDict;
        }

        /*
         * 根据包材代码查询相应供应商信息
         */
        public Dictionary<String, String> querySupplierOfPackingMaterialByNo(String packingMaterialNo)
        {
            DataTable supplierOfPackingMaterialTable = newPackingDetailDao.querySupplierOfPackingMaterialByNo(packingMaterialNo);
            Dictionary<String, String> supplierInforDict = new Dictionary<String, String>();
            if (supplierOfPackingMaterialTable.Rows.Count > 0)
            {
                DataRow currentRow = supplierOfPackingMaterialTable.Rows[0];
                int columnCount = currentRow.ItemArray.Length;
                for (int i = 0; i < columnCount; i++)
                {
                    supplierInforDict.Add(supplierOfPackingMaterialTable.Columns[i].ColumnName, currentRow[i].ToString());
                }
            }

            return supplierInforDict;
        }

        /*
         * 更新一种包材的基本信息
         */
        public void updatePackingMaterialInformation(Dictionary<String, String> packingMaterialDict, String packingMaterialNo)
        {
            newPackingDetailDao.updatePackingMaterialInformation(packingMaterialDict,packingMaterialNo);
        }
    }
}
