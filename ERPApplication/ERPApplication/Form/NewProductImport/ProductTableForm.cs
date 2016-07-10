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
    public partial class ProductTableForm : Form
    {
        private String productNumber;
        private String productChineseName;
        private String productDescription;

        public ProductTableForm()
        {
            InitializeComponent();
            init();
            fillProductTable();
        }

        /*
         * 初始化操作
         */
        private void init()
        {
            this.productTable.AutoGenerateColumns = false;
            this.searchCondition.SelectedIndex = 0;
        }

        /*
         * 填充产品表
         */
        private void fillProductTable()
        {
            ProductTableManager productTableManager = new ProductTableManager();

            switch (this.searchCondition.SelectedIndex)
            {
                case 0:
                    this.productTable.DataSource = productTableManager.queryStableProductInformation();
                    break;
                case 1:
                    this.productTable.DataSource = productTableManager.queryStableCosmeticsInformation();
                    break;
                case 2:
                    this.productTable.DataSource = productTableManager.queryStableEyeBrowPencilInformation();
                    break;
                case 3:
                    this.productTable.DataSource = productTableManager.queryStablePeripheralInformation();
                    break;
                default:
                    break;
            }
        }

        /*
         * 筛选条件变动
         */
        private void searchCondition_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillProductTable();
        }

        public String getProductNo()
        {
            return this.productNumber;
        }

        public String getProductName()
        {
            return this.productChineseName;
        }

        public String getProductDescription()
        {
            return this.productDescription;
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            //产品为空时不能“确定”
            if (this.productTable.Rows.Count <= 0)
            {
                return;
            }

            //未选择表格一行时给出提示
            if (this.productTable.SelectedRows.Count <= 0)
            {
                MessageBox.Show(this,
                                "请选择一行！",
                                "选择内容物所属产品提示",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow selectRow = this.productTable.SelectedRows[0];
            this.productNumber = selectRow.Cells[0].Value.ToString();
            this.productChineseName = selectRow.Cells[1].Value.ToString();
            this.productDescription = selectRow.Cells[4].Value.ToString();
            this.DialogResult = DialogResult.OK;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
