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
    public partial class RowMaterialPOForm : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public RowMaterialPOForm()
        {
            InitializeComponent();
        }

        /*
         * 添加按钮点击事件
         */
        private void addBtn_Click(object sender, EventArgs e)
        {
            RowMaterialPODetailForm rowMeterialPODetail = new RowMaterialPODetailForm();
            rowMeterialPODetail.ShowDialog(this);
        }


    }
}
