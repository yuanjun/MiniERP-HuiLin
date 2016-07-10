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
    public partial class PackingMaterialTableForm : Form
    {
        private String pPackingMaterialNo;
        private String pColorNo;
        private String pFactoryNo;

        public PackingMaterialTableForm()
        {
            InitializeComponent();
            fillPackingMaterialTable();
        }

        /*
         * 填充包材表格
         */
        private void fillPackingMaterialTable()
        {
            this.packingMaterialTable.AutoGenerateColumns = false;
            this.packingMaterialTable.DataSource = (new PackingMaterialManager()).queryPackingMaterialInformation();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (this.packingMaterialTable.Rows.Count > 0)
            {
                DataGridViewSelectedRowCollection selectedRows = this.packingMaterialTable.SelectedRows;
                if (selectedRows.Count > 1)
                {
                    MessageBox.Show(this,
                                    "请最多选择一行！",
                                    "选择彩盒提示",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }
                else if (selectedRows.Count <= 0)
                {
                    MessageBox.Show(this,
                                    "请选择一行！",
                                    "选择彩盒提示",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                this.pPackingMaterialNo = selectedRows[0].Cells[0].Value.ToString();
                this.pColorNo = selectedRows[0].Cells[2].Value.ToString();
                this.pFactoryNo = selectedRows[0].Cells[3].Value.ToString();

                this.DialogResult = DialogResult.OK;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        public String getPackingMaterialNo()
        {
            return this.pPackingMaterialNo;
        }

        public String getColorNo()
        {
            return this.pColorNo;
        }

        public String getFactoryNo()
        {
            return this.pFactoryNo;
        }
    }
}
