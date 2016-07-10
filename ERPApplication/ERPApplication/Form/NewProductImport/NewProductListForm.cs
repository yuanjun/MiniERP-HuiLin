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
    public partial class NewProductListForm : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public NewProductListForm()
        {
            InitializeComponent();
            init();
            fillSumTextBox();
            fillCosmeticsTablesAndTextBox();
            fillEyebrowPencilTablesAndTextBox();
            fillPeripheralTablesAndTextBox();
        }

        private void init()
        {
            this.cosmeticsTable.AutoGenerateColumns = false;
            this.eyebrowPencilTable.AutoGenerateColumns = false;
            this.peripheralTable.AutoGenerateColumns = false;
        }

        /*
         * 获取总产品数
         */
        private void fillSumTextBox()
        {
            NewProductListManager newProductListManager = new NewProductListManager();
            this.productSum.Text = Convert.ToString(newProductListManager.getProductSum());
        }

        /*
         * 获取彩妆类产品数据
         */
        private void fillCosmeticsTablesAndTextBox()
        {
            NewProductListManager newProductListManager = new NewProductListManager();
            this.productASum.Text = Convert.ToString(newProductListManager.getCosmeticsCount());
            this.cosmeticsTable.DataSource = newProductListManager.getCosmeticsInformatin();
        }

        /*
         * 获取眉笔类产品数据
         */
        private void fillEyebrowPencilTablesAndTextBox()
        {
            NewProductListManager newProductListManager = new NewProductListManager();
            this.productBSum.Text = Convert.ToString(newProductListManager.getEyebrowPencilCount());
            this.eyebrowPencilTable.DataSource = newProductListManager.getEyebrowPencilInformation();
        }

        /*
         * 获取周边类产品数据
         */
        private void fillPeripheralTablesAndTextBox()
        {
            NewProductListManager newProductListManager = new NewProductListManager();
            this.productCSum.Text = Convert.ToString(newProductListManager.getPeripheralCount());
            this.peripheralTable.DataSource = newProductListManager.getPeripheralInformation(); 

        }

        /*
         * 新产品导入(添加)
         */
        private void addBtn_Click(object sender, EventArgs e)
        {
            NewProductTypeForm newProductType = new NewProductTypeForm();
            if (newProductType.ShowDialog(this) == DialogResult.OK)
            {
                NewProductDetailForm newProductDetail = new NewProductDetailForm(newProductType.getProductType(),1);
                newProductDetail.ShowDialog(this);
            }
        }

        private void setCosmeticsMenuItemEnabled(bool flag)
        {
            this.editCosmeticsItem.Enabled = flag;
            this.removeCosmeticsItem.Enabled = flag;
            this.detailCosmeticsItem.Enabled = flag;
        }

        private void setEyebrowPencilMenuItemEnabled(bool flag)
        {
            this.editEyeBrowPencilItem.Enabled = flag;
            this.removeEyeBrowPencilItem.Enabled = flag;
            this.detailEyeBrowPencilItem.Enabled = flag;
        }

        private void setPeripheralMenuItemEnabled(bool flag)
        {
            this.editPerpheralItem.Enabled = flag;
            this.removePerpheralItem.Enabled = flag;
            this.detailPerpheralItem.Enabled = flag;
        }

        /*
         * 彩妆类产品表右键菜单
         */
        private void cosmeticsTable_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int rowIndex = e.RowIndex;
                int rowCount = this.cosmeticsTable.Rows.Count;

                if (rowIndex < 0 || rowCount <= 0)
                {
                    setCosmeticsMenuItemEnabled(false);
                }
                else
                {
                    setCosmeticsMenuItemEnabled(true);
                }

                this.cosmeticsMenu.Show(MousePosition.X,MousePosition.Y);
            }
        }

        /*
         * 眉笔类产品表右键菜单
         */
        private void eyebrowPencilTable_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int rowIndex = e.RowIndex;
                int rowCount = this.eyebrowPencilTable.Rows.Count;

                if (rowIndex < 0 || rowCount <= 0)
                {
                    setEyebrowPencilMenuItemEnabled(false);
                }
                else
                {
                    setEyebrowPencilMenuItemEnabled(true);
                }

                this.eyeBrowPencilMenu.Show(MousePosition.X, MousePosition.Y);
            }
        }

        /*
         * 周边类产品表右键菜单
         */
        private void peripheralTable_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int rowIndex = e.RowIndex;
                int rowCount = this.peripheralTable.Rows.Count;

                if (rowIndex < 0 || rowCount <= 0)
                {
                    setPeripheralMenuItemEnabled(false);
                }
                else
                {
                    setPeripheralMenuItemEnabled(true);
                }

                this.peripheralMenu.Show(MousePosition.X, MousePosition.Y);
            }
        }

        /*
         * 彩妆类产品右键菜单-编辑、删除、详情
         */
        private void editCosmeticsItem_Click(object sender, EventArgs e)
        {

        }

        private void removeCosmeticsItem_Click(object sender, EventArgs e)
        {

        }

        private void detailCosmeticsItem_Click(object sender, EventArgs e)
        {

        }

        /*
         * 眉笔类产品右键菜单-编辑、删除、详情
         */
        private void editEyeBrowPencilItem_Click(object sender, EventArgs e)
        {

        }

        private void removeEyeBrowPencilItem_Click(object sender, EventArgs e)
        {

        }

        private void detailEyeBrowPencilItem_Click(object sender, EventArgs e)
        {

        }

        /*
         * 周边类产品右键菜单-编辑、删除、详情
         */
        private void editPerpheralItem_Click(object sender, EventArgs e)
        {

        }

        private void removePerpheralItem_Click(object sender, EventArgs e)
        {

        }

        private void detailPerpheralItem_Click(object sender, EventArgs e)
        {

        }

        /*
         * 添加内容物
         */
        private void addContentBtn_Click(object sender, EventArgs e)
        {
            NewContentForm newContentForm = new NewContentForm();
            DialogResult rst = newContentForm.ShowDialog(this);
            if (rst == DialogResult.OK)
            {
                fillCosmeticsTablesAndTextBox();
                fillEyebrowPencilTablesAndTextBox();
                fillPeripheralTablesAndTextBox();
            }
        }
    }
}
