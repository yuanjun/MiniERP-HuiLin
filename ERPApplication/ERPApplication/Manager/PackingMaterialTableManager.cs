using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ERPApplication
{
    class PackingMaterialManager
    {
        PackingMaterialTableDao packingMateialTableDao = new PackingMaterialTableDao();

        /*
         * 查询所有包材信息
         */
        public DataTable queryPackingMaterialInformation()
        {
            return packingMateialTableDao.queryPackingMateialInformation();
        }
    }
}
