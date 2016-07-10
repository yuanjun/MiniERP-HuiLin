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
    public partial class EndProductPOForm : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public EndProductPOForm()
        {
            InitializeComponent();
        }

        /*
         * 添加按钮点击事件响应函数
         */
        private void addBtn_Click(object sender, EventArgs e)
        {
            EndProductPODetailForm endProductPODetail = new EndProductPODetailForm();
            endProductPODetail.ShowDialog(this);
        }
    }
}
