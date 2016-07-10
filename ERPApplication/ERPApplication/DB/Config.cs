using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;


namespace Lib.Common
{
    [Serializable]
    public class Config
    {
        #region 系统常用参数设置
        //类库链接定义
        public static string DBDAL = "Lib.SqlServerDAL";
        //数据库链接
        public static string MMDBConnStr = ConfigurationManager.AppSettings["serverAddress"];
        //public static String MMDBConnStr = "Data Source=GONGLING-PC\\SQLEXPRESS;Initial Catalog=miniERP;User ID=sa;Password=123456";
        #endregion
    }
}

