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
    public partial class ClientInformationDetailForm : Form
    {
        int operationFlag;      //0表示插入     1表示编辑       2表示查询       3表示查看单条记录详情
        int clientNo;           //客户id
        ClientInformationForm parent;

        public ClientInformationDetailForm(int operationFlag)
        {
            InitializeComponent();

            this.operationFlag = operationFlag;
            if (operationFlag == 0 || operationFlag == 1)
            {
                setButtonVisible(true,false);
            }
            else if (operationFlag == 2)
            {
                setButtonVisible(false,true);
            }
            else
            {
                setButtonVisible(false, false);
            }
        }

        /*
         * 查询对应clientName纪录，并赋值给相应的textBox
         */
        public void setTextBoxValue(int id)
        {
            clientNo = id;

            ClientInformationManager clientInformationManager = new ClientInformationManager();
            Dictionary<String, String> rst = clientInformationManager.queryClientById(clientNo);
            foreach (Control ctl in this.Controls)
            {
                if (ctl.GetType().Name == "TextBox")
                {
                    TextBox textBox = (TextBox)ctl;
                    textBox.Text = rst[textBox.Name];
                }
            }
        }

        /*
         * 查询时设置所有textBox不可编辑,按钮隐藏
         */
        public void setTextBoxDisabled()
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl.GetType().Name == "TextBox")
                {
                    ((TextBox)ctl).ReadOnly = true;
                }
            }
        }

        /*
         * 设置“保存”、“重置”、“查询”按钮的可见性
         */
        private void setButtonVisible(bool flag1,bool flag2)
        {
            this.saveBtn.Visible = flag1;
            this.resetBtn.Visible = flag1;
            this.searchBtn.Visible = flag2;
        }

        /*
         * 保存新客户信息到数据库
         */
        private void saveBtn_Click(object sender, EventArgs e)
        {
            ClientInformationManager clientInformationManager = new ClientInformationManager();
            Dictionary<String, String> items = new Dictionary<String, String>();
            foreach (Control child in this.Controls)
            {
                if (child.GetType().Name == "TextBox")
                {
                    items.Add(child.Name,((TextBox)child).Text);        //TextBox控件名和DB对应字段名称相同
                }
            }

            if (operationFlag == 0)
            {
                clientInformationManager.insertClient(items);
            }
            else if(operationFlag == 1)
            {
                items.Add("clientNo",Convert.ToString(clientNo));
                clientInformationManager.updateClient(items);
            }
            
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /*
         * 重置当前所填的内容
         */
        private void resetBtn_Click(object sender, EventArgs e)
        {
            //遍历所有子控件，清除TextBox的内容
            foreach (Control child in this.Controls)
            {
                if (child.GetType().Name == "TextBox")
                {
                    TextBox textBox = (TextBox)child;
                    textBox.Clear();
                }
            }
        }

        /*
         * 查询时传递父窗口引用
         */
        public void setParentWindow(ClientInformationForm parent)
        {
            this.parent = parent;
        }

        /*
         * 查询按钮点击点击响应事件
         */
        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (this.parent != null)
            {
                Dictionary<String, String> items = new Dictionary<String, String>();
                foreach (Control child in this.Controls)
                {
                    if (child.GetType().Name == "TextBox" && ((TextBox)child).Text != "")
                    {
                        items.Add(child.Name, ((TextBox)child).Text);        //TextBox控件名和DB对应字段名称相同
                    }
                }

                this.parent.searchClients(items);
            }
        }
    }
}
