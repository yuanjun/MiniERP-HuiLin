using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

/*
 * ERPApplication命名空间即一个“包”，同一个命名空间内容直接引用
 */

namespace ERPApplication
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            /* 
             * 进入主界面前进行登录验证
             */
            LoginForm login = new LoginForm();
            /*DialogResult result = login.ShowDialog();
            if (result == DialogResult.OK)
            {
                Application.Run(new MainForm(login.getUsername()));
            }*/
            Application.Run(new MainForm("admin"));
        }
    }
}
