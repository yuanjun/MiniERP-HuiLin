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
    public partial class ProductListForm : Form
    {
        List<Object[]> products = new List<Object[]>();         //记录选择的表项

        public ProductListForm()
        {
            InitializeComponent();

            this.productTable.AutoGenerateColumns = false;
            this.searchCondition.SelectedIndex = 0;

            fillProductTable();
        }

        private void fillProductTable()
        {
            ProductListManager productListManager = new ProductListManager();

            switch(this.searchCondition.SelectedIndex)
            {
                case 0:
                    this.productTable.DataSource = productListManager.queryProductInformation();
                    break;
                case 1:
                    this.productTable.DataSource = productListManager.queryCosmeticsInformation();
                    break;
                case 2:
                    this.productTable.DataSource = productListManager.queryEyeBrowPencilInformation();
                    break;
                case 3:
                    this.productTable.DataSource = productListManager.queryPeripheralInformation();
                    break;
                default:
                    break;
            }
        }

        /*
         * 查询条件改变
         */
        private void searchCondition_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillProductTable();
        }

        /*
         * 将选择的表项加入List<Object[]>中
         */
        private void addItemsToSelectProductTable()
        {
            DataTable products = (DataTable)this.productTable.DataSource;

            foreach (DataGridViewRow row in this.productTable.Rows)
            {
                if ((bool)row.Cells[0].EditedFormattedValue == true)                //当前行被选中
                {
                    DataRow currentRow = (row.DataBoundItem as DataRowView).Row;    //DataGridViewRow绑定的底层DataRow
                    this.products.Add(currentRow.ItemArray);  
                }
            }
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            addItemsToSelectProductTable();

            this.DialogResult = DialogResult.OK;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        public List<Object[]> getProductList()
        {
            return this.products;
        }
    }
}
