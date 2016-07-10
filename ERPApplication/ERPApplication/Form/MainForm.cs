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
    public partial class MainForm : Form
    {
        private HomeForm home = new HomeForm();

        private NewSaleOrderForm newSaleOrder = null;
        private UnsubmittedOrderForm unsubmittedOrder = null;
        private UnfinishedOrderForm unfinishedOrder = null;
        private FinishedOrderForm finishedOrder = null;
        private RemovedOrderForm removedOrder = null;
        private ClientInformationForm clientInformation = null;

        private EndProductPOForm endProductPO = null;
        private RowMaterialPOForm rowMaterialPO = null;
        private POStateQueryForm poStateQuery = null;
        private SupplierInformationForm supplierInformation = null;

        private NewProductListForm newProductList = null;
        private NewMaterialListForm newMaterialList = null;

        public MainForm(String username)
        {
            InitializeComponent();
            initTreeView();
            addHomeForm(username);
        }

        /*
         * 将“首页”添加到DockPanel中，并固定不能关闭
         */
        private void addHomeForm(String username)
        {
            home.Username = username;

            home.TopLevel = false;
            home.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            home.Show(this.dockPanel, DockState.Document);
        }

        /*
         * 主页左侧树形列表初始化操作
         */ 
        private void initTreeView()
        {
            this.treeView.ExpandAll();
        }

        /*
         * 点击树形列表，生成相应窗口
         */
        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            String title = this.treeView.SelectedNode.Text;

            switch (title.Trim())
            {
                case "新销售订单":
                    if (newSaleOrder == null || newSaleOrder.IsDisposed)
                    {
                        newSaleOrder = new NewSaleOrderForm(1);
                    }
                    newSaleOrder.TopLevel = false;
                    newSaleOrder.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    newSaleOrder.Show(this.dockPanel, DockState.Document);
                    break;
                case "未提交订单":
                    if (unsubmittedOrder == null || unsubmittedOrder.IsDisposed)
                    {
                        unsubmittedOrder = new UnsubmittedOrderForm();
                    }
                    unsubmittedOrder.TopLevel = false;
                    unsubmittedOrder.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    unsubmittedOrder.Show(this.dockPanel, DockState.Document);
                    break;
                case "未完成订单":
                    if (unfinishedOrder == null || unfinishedOrder.IsDisposed)
                    {
                        unfinishedOrder = new UnfinishedOrderForm();
                    }
                    unfinishedOrder.TopLevel = false;
                    unfinishedOrder.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    unfinishedOrder.Show(this.dockPanel, DockState.Document);
                    break;
                case "已完成订单":
                    if (finishedOrder == null || finishedOrder.IsDisposed)
                    {
                        finishedOrder = new FinishedOrderForm();
                    }
                    finishedOrder.TopLevel = false;
                    finishedOrder.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    finishedOrder.Show(this.dockPanel, DockState.Document);
                    break;
                case "已删除订单":
                    if (removedOrder == null || removedOrder.IsDisposed)
                    {
                        removedOrder = new RemovedOrderForm();
                    }
                    removedOrder.TopLevel = false;
                    removedOrder.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    removedOrder.Show(this.dockPanel, DockState.Document);
                    break;
                case "客户信息":
                    if (clientInformation == null || clientInformation.IsDisposed)
                    {
                        clientInformation = new ClientInformationForm();
                    }
                    clientInformation.TopLevel = false;
                    clientInformation.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    clientInformation.Show(this.dockPanel, DockState.Document);
                    break;
                case "成品PO":
                    if (endProductPO == null || endProductPO.IsDisposed)
                    {
                        endProductPO = new EndProductPOForm();
                    }
                    endProductPO.TopLevel = false;
                    endProductPO.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    endProductPO.Show(this.dockPanel, DockState.Document);
                    break;
                case "原材料PO":
                    if (rowMaterialPO == null || rowMaterialPO.IsDisposed)
                    {
                        rowMaterialPO = new RowMaterialPOForm();
                    }
                    rowMaterialPO.TopLevel = false;
                    rowMaterialPO.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    rowMaterialPO.Show(this.dockPanel, DockState.Document);
                    break;
                case "PO状态查询":
                    if (poStateQuery == null || poStateQuery.IsDisposed)
                    {
                        poStateQuery = new POStateQueryForm();
                    }
                    poStateQuery.TopLevel = false;
                    poStateQuery.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    poStateQuery.Show(this.dockPanel, DockState.Document);
                    break;
                case "供应商信息":
                    if (supplierInformation == null || supplierInformation.IsDisposed)
                    {
                        supplierInformation = new SupplierInformationForm();
                    }
                    supplierInformation.TopLevel = false;
                    supplierInformation.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    supplierInformation.Show(this.dockPanel, DockState.Document);
                    break;
                case "新产品导入":
                    if (newProductList == null || newProductList.IsDisposed)
                    {
                        newProductList = new NewProductListForm();
                    }
                    newProductList.TopLevel = false;
                    newProductList.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    newProductList.Show(this.dockPanel, DockState.Document);
                    break;
                case "新物料导入":
                    if (newMaterialList == null || newMaterialList.IsDisposed)
                    {
                        newMaterialList = new NewMaterialListForm();
                    }
                    newMaterialList.TopLevel = false;
                    newMaterialList.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    newMaterialList.Show(this.dockPanel, DockState.Document);
                    break;
                default:
                    break;
            }

            this.treeView.SelectedNode = null;
        }
    }
}
