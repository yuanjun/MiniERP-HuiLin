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
    public partial class CartonTableForm : Form
    {
        private String pCartonNo;
        private String pColorNo;
        private String pFactoryNo;

        public CartonTableForm()
        {
            InitializeComponent();
            fillCartonTable();
        }

        /*
         * 填充彩盒信息表格
         */
        private void fillCartonTable()
        {
            this.cartonTable.AutoGenerateColumns = false;
            this.cartonTable.DataSource = (new CartonTableManager()).queryCartonInformation();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (this.cartonTable.Rows.Count > 0)
            {
                DataGridViewSelectedRowCollection selectedRows = this.cartonTable.SelectedRows;
                if (selectedRows.Count > 1)
                {
                    MessageBox.Show(this,
                                    "请最多选择一行！",
                                    "选择包材提示",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }
                else if (selectedRows.Count <= 0)
                {
                    MessageBox.Show(this,
                                    "请选择一行！",
                                    "选择包材提示",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                this.pCartonNo = selectedRows[0].Cells[0].Value.ToString();
                this.pColorNo = selectedRows[0].Cells[2].Value.ToString();
                this.pFactoryNo = selectedRows[0].Cells[3].Value.ToString();

                this.DialogResult = DialogResult.OK;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        public String getCartonNo()
        {
            return this.pCartonNo;
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
