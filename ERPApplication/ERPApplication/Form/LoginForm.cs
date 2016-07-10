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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            initBackground();
        }

        /*
         * 1.重新设置单行文本框高度为30（会导致不垂直居中，增大字号）
         */
        private void initBackground()
        {
            this.username.AutoSize = false;
            this.password.AutoSize = false;

            this.username.Height = 30;
            this.password.Height = 30;

            this.AcceptButton = this.ok;
        }

        private void ok_Click(object sender, EventArgs e)
        {
            if (checkPassword() == true)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        /*
         * 验证用户名和密码是否匹配
         */
        private bool checkPassword()
        {
            if (this.username.Text == "" || this.password.Text == "")
            {
                this.tip.Text = "用户名或密码不能为空，请输入. . .";
                return false;
            }

            LoginManager loginManager = new LoginManager();
            if (loginManager.checkPassword(this.username.Text, this.password.Text))
            {
                return true;
            }
            else
            {
                this.tip.Text = "用户名或密码错误，请重试. . .";
                return false;
            }
        }

        /*
         * 获取用户名
         */
        public String getUsername()
        {
            return this.username.Text;
        }
    }
}
