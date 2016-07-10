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
    public partial class NewMaterialListForm : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        int currentRow;

        public NewMaterialListForm()
        {
            InitializeComponent();
            init();
            fillTableAndTextBox();
        }

        private void init()
        {
            this.cartonTable.AutoGenerateColumns = false;
            this.packingMaterialTable.AutoGenerateColumns = false;
        }

        private void fillTableAndTextBox()
        {
            NewMaterialListManager newMaterialListManager = new NewMaterialListManager();

            this.cartonSum.Text = Convert.ToString(newMaterialListManager.getCartonCount());
            this.packingMaterialSum.Text = Convert.ToString(newMaterialListManager.getPackingMaterialCount());

            this.cartonTable.DataSource = newMaterialListManager.getCartonInformation();
            this.packingMaterialTable.DataSource = newMaterialListManager.getPackingMaterialInformation();
        }

        /*
         * 新物料导入(添加)
         */
        private void addBtn_Click(object sender, EventArgs e)
        {
            NewMaterialTypeForm newMaterialType = new NewMaterialTypeForm();
            if (newMaterialType.ShowDialog(this) == DialogResult.OK)
            {
                if (newMaterialType.getMaterialType() == 1)
                {
                    NewPackingDetailForm newPackingMaterial = new NewPackingDetailForm(1);
                    newPackingMaterial.ShowDialog(this);
                    
                }
                else if (newMaterialType.getMaterialType() == 2)
                {
                    NewCartonDetailForm newCarton = new NewCartonDetailForm(1);
                    newCarton.ShowDialog(this);
                }

                fillTableAndTextBox();
            }
        }

        /*
         * 设置包材表 鼠标右键菜单是否激活
         */
        private void setPackingMaterialTableMenuEnabled(bool flag)
        {
            this.editPackingMaterialItem.Enabled = flag;
            this.removePackingMaterialItem.Enabled = flag;
            this.detailPackingMaterialItem.Enabled = flag;
        }

        /*
         * 包材表 鼠标右键菜单
         */
        private void packingMaterialTable_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                currentRow = e.RowIndex;

                int rowCount = this.packingMaterialTable.Rows.Count;
                //表格为空或单击表头时，禁止删除、编辑、详情
                if (rowCount <= 0 || currentRow < 0)
                {
                    setPackingMaterialTableMenuEnabled(false);
                }
                else if(rowCount > 0)
                {
                    setPackingMaterialTableMenuEnabled(true);
                }

                this.packingMaterialMenu.Show(MousePosition.X,MousePosition.Y);
            }
        }

        private void addPackingMaterialItem_Click(object sender, EventArgs e)
        {
            NewPackingDetailForm newPackingMaterial = new NewPackingDetailForm(1);
            newPackingMaterial.ShowDialog(this);

            fillTableAndTextBox();
        }

        private void editPackingMaterialItem_Click(object sender, EventArgs e)
        {
            NewPackingDetailForm newPackingMaterial = new NewPackingDetailForm(2,this.packingMaterialTable.Rows[currentRow].Cells[0].Value.ToString());
            newPackingMaterial.ShowDialog(this);

            fillTableAndTextBox();
        }

        private void removePackingMaterialItem_Click(object sender, EventArgs e)
        {
            DialogResult rest = MessageBox.Show(this,
                                                "确定删除当前包材记录？",
                                                "删除包材警告",
                                                MessageBoxButtons.OKCancel,
                                                MessageBoxIcon.Warning);
            if (rest == DialogResult.OK)
            {
                NewMaterialListManager newPackingListManager = new NewMaterialListManager();
                newPackingListManager.removePackingMaterial(this.packingMaterialTable.Rows[this.currentRow].Cells[0].Value.ToString());
                newPackingListManager.removeSupplierWithPackingMaterial(this.packingMaterialTable.Rows[this.currentRow].Cells[0].Value.ToString());

                fillTableAndTextBox();
            }
        }

        private void detailPackingMaterialItem_Click(object sender, EventArgs e)
        {
            NewPackingDetailForm newPackingMaterial = new NewPackingDetailForm(3, this.packingMaterialTable.Rows[currentRow].Cells[0].Value.ToString());
            newPackingMaterial.ShowDialog(this);
        }

        /*
         * 彩盒表鼠标右键菜单是否激活
         */
        private void setCartonTableMenuEnabled(bool flag)
        {
            this.editCartonItem.Enabled = flag;
            this.removeCartonItem.Enabled = flag;
            this.detailCartonItem.Enabled = flag;
        }

        /*
         * 彩盒表 鼠标右键菜单
         */
        private void cartonTable_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                currentRow = e.RowIndex;

                int rowCount = this.cartonTable.Rows.Count;
                //表格为空或单击表头时，禁止删除、编辑、详情
                if (rowCount <= 0 || currentRow < 0)
                {
                    setCartonTableMenuEnabled(false);
                }
                else
                {
                    setCartonTableMenuEnabled(true);
                }

                this.cartonMenu.Show(MousePosition.X, MousePosition.Y);
            }
        }

        private void addCartonItem_Click(object sender, EventArgs e)
        {
            NewCartonDetailForm newCarton = new NewCartonDetailForm(1);
            newCarton.ShowDialog(this);

            fillTableAndTextBox();
        }

        private void editCartonItem_Click(object sender, EventArgs e)
        {
            NewCartonDetailForm newCarton = new NewCartonDetailForm(2,this.cartonTable.Rows[currentRow].Cells[0].Value.ToString());
            newCarton.ShowDialog(this);

            fillTableAndTextBox();
        }

        private void removeCartonItem_Click(object sender, EventArgs e)
        {
            DialogResult rest = MessageBox.Show(this,
                                                "确定删除当前彩盒记录？",
                                                "删除彩盒警告",
                                                MessageBoxButtons.OKCancel,
                                                MessageBoxIcon.Warning);
            if (rest == DialogResult.OK)
            {
                NewMaterialListManager newcartonManager = new NewMaterialListManager();
                newcartonManager.removeCarton(this.cartonTable.Rows[this.currentRow].Cells[0].Value.ToString());
                newcartonManager.removeSupplierWithCarton(this.cartonTable.Rows[this.currentRow].Cells[0].Value.ToString());

                fillTableAndTextBox();
            }
        }

        private void detailCartonItem_Click(object sender, EventArgs e)
        {
            NewCartonDetailForm newCarton = new NewCartonDetailForm(3, this.cartonTable.Rows[currentRow].Cells[0].Value.ToString());
            newCarton.ShowDialog(this);
        }

    }
}
