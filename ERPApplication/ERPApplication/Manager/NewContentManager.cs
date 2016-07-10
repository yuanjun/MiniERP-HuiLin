using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ERPApplication
{
    class NewContentManager
    {
        NewContentDao newContentDao = new NewContentDao();

        /*
         * 将内容物信息写入数据库
         */
        public void insertContent(Dictionary<String, String> contentInforDict)
        {
            newContentDao.insertContent(contentInforDict);
        }
    }
}
