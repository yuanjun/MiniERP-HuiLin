using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using WeifenLuo.WinFormsUI.Docking;

namespace ERPApplication
{
    public partial class ClientInformationForm : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public ClientInformationForm()
        {
            InitializeComponent();
            init();
            fillClientList();
        }

        /*
         * 1.设置客户表不自动产生列
         * 2.设置客户表不可多选
         */
        private void init()
        {
            this.clientList.AutoGenerateColumns = false;
            this.clientList.MultiSelect = false;
        }

        /*
         * 遍历客户表，填充dataGridView
         */
        private void fillClientList()
        {
            ClientInformationManager clientInformationManager = new ClientInformationManager();
            this.clientList.DataSource = clientInformationManager.listClient();
        }

        /*
         * 添加按钮点击事件函数
         */
        private void addBtn_Click(object sender, EventArgs e)
        {
            ClientInformationDetailForm addClient = new ClientInformationDetailForm(0);
            DialogResult rst = addClient.ShowDialog(this);
            if (rst == DialogResult.OK)
            {
                fillClientList();
            }
        }

        /*
         * 编辑按钮点击事件函数
         */
        private void editBtn_Click(object sender, EventArgs e)
        {
            if (this.clientList.Rows.Count <= 0)
            {
                MessageBox.Show(this,
                                "当前表内容为空，无法编辑！",
                                "编辑客户提示",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            //表格最多只能选择一行
            int currentIndex = this.clientList.CurrentRow.Index;
            DataGridViewRow currentRow = this.clientList.Rows[currentIndex];
            ClientInformationDetailForm clientDetail = new ClientInformationDetailForm(1);
            clientDetail.setTextBoxValue(int.Parse(currentRow.Cells[0].Value.ToString()));
            clientDetail.ShowDialog(this);
            fillClientList();
        }

        /*
         * 查询按钮点击事件函数
         */
        private void searchBtn_Click(object sender, EventArgs e)
        {
            ClientInformationDetailForm clientDetail = new ClientInformationDetailForm(2);
            clientDetail.setParentWindow(this);
            clientDetail.Show();
        }

        /*
         * 根据条件查询相应的客户信息
         */
        public void searchClients(Dictionary<String,String> items)
        {
            ClientInformationManager clientInformationManager = new ClientInformationManager();
            this.clientList.DataSource = clientInformationManager.queryClientByMutiCondition(items);
        }

        /*
         * 删除按钮点击事件函数
         */
        private void removeBtn_Click(object sender, EventArgs e)
        {
            
            if (this.clientList.Rows.Count <= 0)
            {
                MessageBox.Show(this,
                                "当前表内容为空，无法删除！",
                                "删除客户提示",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            //表格最多只能选择一行
            int currentIndex = this.clientList.CurrentRow.Index;
            if (currentIndex >= 0)
            {
                DialogResult rst = MessageBox.Show(this,
                                                   "确定删除该选中项纪录？",
                                                   "删除客户提示",
                                                   MessageBoxButtons.OKCancel,
                                                   MessageBoxIcon.Warning);
                if (rst == DialogResult.OK)
                {
                    DataGridViewRow currentRow = this.clientList.Rows[currentIndex];
                    ClientInformationManager clientInformationManager = new ClientInformationManager();
                    clientInformationManager.removeClientById(int.Parse(currentRow.Cells[0].Value.ToString()));
                    fillClientList();
                }
            }
            
        }

        /*
         * 显示全部数据
         */
        private void showAllBtn_Click(object sender, EventArgs e)
        {
            fillClientList();
        }

        /*
         * 双击列表一行显示详细信息
         */
        private void clientList_DoubleClick(object sender, EventArgs e)
        {
            int currentIndex = this.clientList.CurrentRow.Index;
            DataGridViewRow currentRow = this.clientList.Rows[currentIndex];
            ClientInformationDetailForm clientDetail = new ClientInformationDetailForm(4);
            clientDetail.setTextBoxValue(int.Parse(currentRow.Cells[0].Value.ToString()));
            clientDetail.setTextBoxDisabled();
            clientDetail.ShowDialog(this);
        }

    }
}
