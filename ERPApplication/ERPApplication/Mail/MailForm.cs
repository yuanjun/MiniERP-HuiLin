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
    public partial class MailForm : Form
    {
        private String sendUsername;
        private String sendPassword;

        public MailForm()
        {
            InitializeComponent();

            /*做成配置文件或者存入数据库*/
            this.sendUsername = "994697421@qq.com";
            this.sendPassword = "abcd1234";             //QQ邮箱独立密码

            /*从客户和供应商表查询数据，填充contactsList*/
        }

        /*
         * 检查收件人和主题是否为空
         */
        private bool checkNull()
        {
            if (this.emailAddress.Text == "")
            {
                MessageBox.Show(this,"收件人地址不能空，请输入！");
                return false;
            }
            if (this.emailTitle.Text == "")
            {
                MessageBox.Show(this, "邮件主题不能空，请输入！");
                return false;
            }
            return true;
        }

        private void setEmailInfo(MailManager mailManager)
        {
            mailManager.setEmailTo(this.emailAddress.Text);
            mailManager.setEmailTitle(this.emailTitle.Text);
            mailManager.setEmailBody(this.emailBody.Text);
            mailManager.setEmailEncoding();
            mailManager.setEmailPriority();
            mailManager.setEmailFrom(this.sendUsername);
            mailManager.setPassword(this.sendPassword);
            
            if (this.attachmentLocation.Text != "")
            {
                mailManager.setEmailAttachment(this.attachmentLocation.Text);
            }
        }

        /*
         * 发送按钮点击事件
         */
        private void sendBtn_Click(object sender, EventArgs e)
        {
            if (checkNull() == false)
            {
                return;
            }

            MailManager mailManager = new MailManager();
            setEmailInfo(mailManager);
            mailManager.send();
        }

        /*
         * 取消按钮点击事件
         */
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*
         * 添加附件按钮点击事件
         */
        private void openFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = ".";
            fileDialog.Filter = "文本类文件（*.txt;*.doc;*.docx）|*.txt;*.doc;*.docx|所有文件（*.*）|*.*";
            fileDialog.FilterIndex = 1;
            fileDialog.RestoreDirectory = true;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                this.attachmentLocation.Text = fileDialog.FileName;
            }
        }

        /*
         * 配置按钮点击事件
         */
        public void config_Click(object sender, EventArgs e)
        {
            MailConfigForm mailConfigForm = new MailConfigForm(this.sendUsername,this.sendPassword);
            mailConfigForm.ShowDialog();
        }
    }
}
