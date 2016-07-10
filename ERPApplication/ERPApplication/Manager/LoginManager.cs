using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ERPApplication
{
    class LoginManager
    {
        private LoginDao loginDao = new LoginDao();

        /*
         * 验证用户名密码是否匹配,虚参为用户输入账号、密码，返回匹配结果（匹配为true）
         */
        public bool checkPassword(String username, String password)
        {
            return loginDao.checkPassword(username, password);
        }
    }
}
