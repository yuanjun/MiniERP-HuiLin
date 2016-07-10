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
    public partial class SupplierInformationForm : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public SupplierInformationForm()
        {
            InitializeComponent();
            fillSupplierList();
        }

        private void fillSupplierList()
        {
            this.supplierList.AutoGenerateColumns = false;
            this.supplierList.DataSource = (new SupplierInformationManager()).querySupplierInformation();
        }

        /*
         * 添加
         */
        private void addBtn_Click(object sender, EventArgs e)
        {
            SupplierInformationDetailForm supplierDetailInfor = new SupplierInformationDetailForm(1);
            supplierDetailInfor.ShowDialog(this);
            fillSupplierList();
        }

        /*
         * 编辑
         */
        private void editBtn_Click(object sender, EventArgs e)
        {
            if (this.supplierList.Rows.Count <= 0)
            {
                MessageBox.Show(this,
                                "当前表内容为空，无法编辑！",
                                "编辑供应商提示",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            //表格最多只能选择一行
            int currentIndex = this.supplierList.CurrentRow.Index;
            DataGridViewRow currentRow = this.supplierList.Rows[currentIndex];
            int supplierNo = int.Parse(currentRow.Cells[0].Value.ToString());

            SupplierInformationDetailForm supplierDetail = new SupplierInformationDetailForm(2);
            SupplierInformationManager supplier = new SupplierInformationManager();

            supplierDetail.fillSupplierPrimaryInfor(supplier.querySupplierInformationById(supplierNo));
            supplierDetail.setSupplierNo(supplierNo);
            supplierDetail.ShowDialog(this);

            fillSupplierList();
        }

        /*
         * 删除
         */
        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (this.supplierList.Rows.Count <= 0)
            {
                MessageBox.Show(this,
                                "当前表内容为空，无法删除！",
                                "删除供应商提示",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            //表格最多只能选择一行
            int currentIndex = this.supplierList.CurrentRow.Index;
        }
    }
}
