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
    public partial class FinishedOrderForm : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public FinishedOrderForm()
        {
            InitializeComponent();
            init();
            fillFinishedOrderTable();
        }

        private void init()
        {
            this.finishedOrderTable.AutoGenerateColumns = false;
        }

        /*
         * 填充已完成订单表
         */
        private void fillFinishedOrderTable()
        {
            CreatedOrderManager createdOrderManager = new CreatedOrderManager();
            this.finishedOrderTable.DataSource = createdOrderManager.queryActiveSaleOrderInformationByState("关闭", true);
        }

        /*
         * 双击已完成订单表项显示详细信息
         */
        private void finishedOrderTable_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
