using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ERPApplication
{
    class CartonTableManager
    {
        CartonTableDao cartonTableDao = new CartonTableDao();

        /*
         * 查询所有彩盒信息
         */
        public DataTable queryCartonInformation()
        {
            return cartonTableDao.queryCartonInformation();
        }
    }
}
