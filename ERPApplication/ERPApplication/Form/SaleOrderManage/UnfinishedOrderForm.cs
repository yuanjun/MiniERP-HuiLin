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
    public partial class UnfinishedOrderForm : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public UnfinishedOrderForm()
        {
            InitializeComponent();
            init();
            fillUnfinishedOrderTable();
        }

        private void init()
        {
            this.unfinishedOrderTable.AutoGenerateColumns = false;
        }

        /*
         * 填充未完成订单表(即查询状态不为“关闭”的订单)
         */
        private void fillUnfinishedOrderTable()
        {
            CreatedOrderManager createdOrderManager = new CreatedOrderManager();
            this.unfinishedOrderTable.DataSource = createdOrderManager.queryActiveSaleOrderInformationByState("关闭", false);
        }

        /*
         * 编辑表项
         */
        private void editBtn_Click(object sender, EventArgs e)
        {
            if (this.unfinishedOrderTable.Rows.Count <= 0)
            {
                MessageBox.Show(this,
                                "当前表内容为空，无法编辑！",
                                "编辑未完成订单提示",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            int rowIndex = this.unfinishedOrderTable.CurrentRow.Index;      //当前选中行
        }

        /*
         * 删除表项
         */
        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (this.unfinishedOrderTable.Rows.Count <= 0)
            {
                MessageBox.Show(this,
                                "当前表内容为空，无法删除！",
                                "删除未完成订单提示",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            int rowIndex = this.unfinishedOrderTable.CurrentRow.Index;      //当前选中行
            if (rowIndex >= 0)
            {
                DialogResult rst = MessageBox.Show(this,
                                                   "确定删除当前选中订单项？",
                                                   "删除未完成订单提示",
                                                   MessageBoxButtons.OKCancel,
                                                   MessageBoxIcon.Warning);

                if (rst == DialogResult.OK)
                {
                    String saleOrderNo = this.unfinishedOrderTable.Rows[rowIndex].Cells[0].Value.ToString();
                    CreatedOrderManager createdOrderManager = new CreatedOrderManager();
                    createdOrderManager.removeSaleOrderByOrderNo(saleOrderNo);

                    fillUnfinishedOrderTable();
                }
            }
        }

        /*
         * 显示全部信息
         */
        private void showAllBtn_Click(object sender, EventArgs e)
        {
            fillUnfinishedOrderTable();
        }
    }
}
