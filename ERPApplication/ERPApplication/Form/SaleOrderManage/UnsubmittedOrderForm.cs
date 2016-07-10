using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace ERPApplication
{
    public partial class UnsubmittedOrderForm : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public UnsubmittedOrderForm()
        {
            InitializeComponent();
            init();
            fillUnSubmittedOrderTable();
        }

        private void init()
        {
            this.unsubmittedOrderTable.AutoGenerateColumns = false;
        }

        /*
         * 填充未提交订单表
         */
        private void fillUnSubmittedOrderTable()
        {
            CreatedOrderManager createdOrderManager = new CreatedOrderManager();
            this.unsubmittedOrderTable.DataSource = createdOrderManager.queryActiveSaleOrderInformationByState("未提交", true);
        }

        /*
         * 编辑订单项
         */
        private void editBtn_Click(object sender, EventArgs e)
        {
            if (this.unsubmittedOrderTable.Rows.Count <= 0)
            {
                MessageBox.Show(this,
                                "当前表内容为空，无法编辑！",
                                "编辑未提交订单提示",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            int rowIndex = this.unsubmittedOrderTable.CurrentRow.Index;      //当前选中行
        }

        /*
         * 删除未提交状态订单
         */
        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (this.unsubmittedOrderTable.Rows.Count <= 0)
            {
                MessageBox.Show(this,
                                "当前表内容为空，无法编辑！",
                                "编辑未提交订单提示",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            int rowIndex = this.unsubmittedOrderTable.CurrentRow.Index;      //当前选中行
            if (rowIndex >= 0)
            {
                DialogResult rst = MessageBox.Show(this,
                                                   "确定删除当前选中订单项？",
                                                   "删除未提交订单提示",
                                                   MessageBoxButtons.OKCancel,
                                                   MessageBoxIcon.Warning);

                if (rst == DialogResult.OK)
                {
                    String saleOrderNo = this.unsubmittedOrderTable.Rows[rowIndex].Cells[0].Value.ToString();
                    CreatedOrderManager createdOrderManager = new CreatedOrderManager();
                    createdOrderManager.removeSaleOrderByOrderNo(saleOrderNo);
                    fillUnSubmittedOrderTable();
                }
            }
        }

        /*
         * 显示全部订单
         */
        private void showAllBtn_Click(object sender, EventArgs e)
        {
            fillUnSubmittedOrderTable();
        }
    }
}
