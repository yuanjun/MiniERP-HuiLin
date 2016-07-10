using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ERPApplication
{
    public partial class MailConfigForm : Form
    {
        public MailConfigForm(String username,String password)
        {
            InitializeComponent();

            this.sendUsername.Text = username;
            this.sendPassword.Text = password;
            setReadOnly(true);
        }

        /*
         * 设置邮箱和密码是否可编辑
         */
        private void setReadOnly(bool flag)
        {
            this.sendUsername.ReadOnly = flag;
            this.sendPassword.ReadOnly = flag;
        }

        /*
         * 编辑按钮点击事件响应函数
         */
        private void editBtn_Click(object sender, EventArgs e)
        {
            setReadOnly(false);
        }

        /*
         * 保存按钮点击事件响应函数
         */
        private void saveBtn_Click(object sender, EventArgs e)
        {
            /*将邮箱和密码写入数据库中*/
            //this.sendUsername.Text;
            //this.sendPassword.Text;
        }

        /*
         * 明/密转换按钮点击事件响应函数
         */
        private void switchDisplayType_Click(object sender, EventArgs e)
        {
            bool current = this.sendPassword.UseSystemPasswordChar;
            this.sendPassword.UseSystemPasswordChar = !current;
        }
    }
}
