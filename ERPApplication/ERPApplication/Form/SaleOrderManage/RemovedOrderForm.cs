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
    public partial class RemovedOrderForm : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public RemovedOrderForm()
        {
            InitializeComponent();
            init();
            fillRemovedOrderTable();
        }

        private void init()
        {
            this.removedOrderTable.AutoGenerateColumns = false;
        }

        /*
         * 查询已删除订单信息
         */
        private void fillRemovedOrderTable()
        {
            CreatedOrderManager createdOrderManager = new CreatedOrderManager();
            this.removedOrderTable.DataSource = createdOrderManager.queryRemovedSaleOrderInformation();
        }

        /*
         * 双击已删除订单表项显示详细信息
         */
        private void removedOrderTable_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
