using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ERPApplication
{
    class ClientInformationManager
    {
        private ClientInformationDao clientInformationDao = new ClientInformationDao();

        /*
         * 按时间倒排顺序获取客户信息
         */
        public DataTable listClient()
        {
            return clientInformationDao.listClient();
        }

        /*
         * 按名字查询一个客户的具体信息
         */
        public Dictionary<String, String> queryClientById(int id)
        {
            return clientInformationDao.queryClientById(id);
        }

        /*
         * 根据多个条件查询客户信息
         */
        public DataTable queryClientByMutiCondition(Dictionary<String, String> items)
        {
            return clientInformationDao.queryClientByMutiCondition(items);
        }

        /*
         * 添加一个新客户
         */
        public void insertClient(Dictionary<String,String> items)
        {
            clientInformationDao.insertClient(items);
        }

        /*
         * 根据名称修改一个客户
         */
        public void updateClient(Dictionary<String, String> items)
        {
            clientInformationDao.updatClient(items);
        }

        /*
         * 删除一个客户
         */
        public void removeClientById(int id)
        {
            clientInformationDao.removeClientById(id);
        }
    }
}
