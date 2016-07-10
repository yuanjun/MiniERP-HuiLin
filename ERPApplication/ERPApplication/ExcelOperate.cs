using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ERPApplication
{
    class ExcelOperate
    {
        /*
         * 读取excel文件返回dataset数据集
         */
        public static DataSet readExcel(String path)
        {
            String strConn = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + path + ";" + "Extended Properties=Excel 8.0";
            OleDbConnection conn = new OleDbConnection(strConn);
            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                MessageBox.Show(null,
                                "请安装高版本office Excel套件！",
                                "异常提醒",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                );
                return null;
            }
            

            //返回Excel的架构，包括各个sheet表的名称,类型，创建时间和修改时间等　
　　　　　　DataTable dtSheetName = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables,new Object[]{null,null,null,"Table"});
　　　　　　String[] strTableNames = new String[dtSheetName.Rows.Count];
　　　　　　for(int k=0;k<dtSheetName.Rows.Count;k++)
　　　　　　{
　　　　　　　　strTableNames[k]=dtSheetName.Rows[k]["TABLE_NAME"].ToString();
　　　　　　}

            String strExcel =  "select * from [" + strTableNames[0] + "]";
            OleDbDataAdapter myCommand = new OleDbDataAdapter(strExcel, strConn);
            DataSet dataSet = new DataSet();

            myCommand.Fill(dataSet);
            conn.Close();

            return dataSet; 
        }
    }
}
