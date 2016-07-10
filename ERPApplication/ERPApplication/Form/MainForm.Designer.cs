namespace ERPApplication
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("新销售订单", 0, 0);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("未提交订单", 0, 0);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("未完成订单", 0, 0);
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("已完成订单", 0, 0);
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("已删除订单", 0, 0);
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("订单查询", 1, 1, new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("客户信息", 0, 0);
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("订单管理", 1, 1, new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("订单差额PO", 0, 0);
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("成品PO", 0, 0);
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("原材料PO", 0, 0);
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("库存PO", 1, 1, new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("PO状态查询", 0, 0);
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("供应商信息", 0, 0);
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("采购管理", 1, 1, new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode12,
            treeNode13,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("成品管理", 0, 0);
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("物料管理", 0, 0);
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("库存管理", 1, 1, new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode17});
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("应收款", 0, 0);
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("内容物", 0, 0);
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("包材", 0, 0);
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("彩盒", 0, 0);
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("运费", 0, 0);
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("应付款", 1, 1, new System.Windows.Forms.TreeNode[] {
            treeNode20,
            treeNode21,
            treeNode22,
            treeNode23});
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("财务管理", 1, 1, new System.Windows.Forms.TreeNode[] {
            treeNode19,
            treeNode24});
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("新产品导入", 0, 0);
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("新物料导入", 0, 0);
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("新品导入", 1, 1, new System.Windows.Forms.TreeNode[] {
            treeNode26,
            treeNode27});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.treeView = new System.Windows.Forms.TreeView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.dockPanel = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.treeView);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.dockPanel);
            this.splitContainer.Size = new System.Drawing.Size(587, 364);
            this.splitContainer.SplitterDistance = 195;
            this.splitContainer.SplitterWidth = 1;
            this.splitContainer.TabIndex = 0;
            // 
            // treeView
            // 
            this.treeView.BackColor = System.Drawing.SystemColors.Control;
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeView.ForeColor = System.Drawing.SystemColors.WindowText;
            this.treeView.FullRowSelect = true;
            this.treeView.ImageIndex = 0;
            this.treeView.ImageList = this.imageList;
            this.treeView.ItemHeight = 20;
            this.treeView.Location = new System.Drawing.Point(0, 0);
            this.treeView.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.treeView.Name = "treeView";
            treeNode1.ImageIndex = 0;
            treeNode1.Name = "newSaleOrder";
            treeNode1.SelectedImageIndex = 0;
            treeNode1.Text = "新销售订单";
            treeNode2.ImageIndex = 0;
            treeNode2.Name = "unsubmittedOrder";
            treeNode2.SelectedImageIndex = 0;
            treeNode2.Text = "未提交订单";
            treeNode3.ImageIndex = 0;
            treeNode3.Name = "unfinishedOrder";
            treeNode3.SelectedImageIndex = 0;
            treeNode3.Text = "未完成订单";
            treeNode4.ImageIndex = 0;
            treeNode4.Name = "finishedOrder";
            treeNode4.SelectedImageIndex = 0;
            treeNode4.Text = "已完成订单";
            treeNode5.ImageIndex = 0;
            treeNode5.Name = "removedOrder";
            treeNode5.SelectedImageIndex = 0;
            treeNode5.Text = "已删除订单";
            treeNode6.ImageIndex = 1;
            treeNode6.Name = "orderQuery";
            treeNode6.SelectedImageIndex = 1;
            treeNode6.Text = "订单查询";
            treeNode7.ImageIndex = 0;
            treeNode7.Name = "clientInformation";
            treeNode7.SelectedImageIndex = 0;
            treeNode7.Text = "客户信息";
            treeNode8.ImageIndex = 1;
            treeNode8.Name = "orderManage";
            treeNode8.SelectedImageIndex = 1;
            treeNode8.Text = "订单管理";
            treeNode9.ImageIndex = 0;
            treeNode9.Name = "orderDifferencePO";
            treeNode9.SelectedImageIndex = 0;
            treeNode9.Text = "订单差额PO";
            treeNode10.ImageIndex = 0;
            treeNode10.Name = "endProductPO";
            treeNode10.SelectedImageIndex = 0;
            treeNode10.Text = "成品PO";
            treeNode11.ImageIndex = 0;
            treeNode11.Name = "rowMaterialPO";
            treeNode11.SelectedImageIndex = 0;
            treeNode11.Text = "原材料PO";
            treeNode12.ImageIndex = 1;
            treeNode12.Name = "inventoryPO";
            treeNode12.SelectedImageIndex = 1;
            treeNode12.Text = "库存PO";
            treeNode13.ImageIndex = 0;
            treeNode13.Name = "poStateQuery";
            treeNode13.SelectedImageIndex = 0;
            treeNode13.Text = "PO状态查询";
            treeNode14.ImageIndex = 0;
            treeNode14.Name = "suppliersInformation";
            treeNode14.SelectedImageIndex = 0;
            treeNode14.Text = "供应商信息";
            treeNode15.ImageIndex = 1;
            treeNode15.Name = "purchaseManage";
            treeNode15.SelectedImageIndex = 1;
            treeNode15.Text = "采购管理";
            treeNode16.ImageIndex = 0;
            treeNode16.Name = "finishedProductManage";
            treeNode16.SelectedImageIndex = 0;
            treeNode16.Text = "成品管理";
            treeNode17.ImageIndex = 0;
            treeNode17.Name = "materialManage";
            treeNode17.SelectedImageIndex = 0;
            treeNode17.Text = "物料管理";
            treeNode18.ImageIndex = 1;
            treeNode18.Name = "inventoryManage";
            treeNode18.SelectedImageIndex = 1;
            treeNode18.Text = "库存管理";
            treeNode19.ImageIndex = 0;
            treeNode19.Name = "collection";
            treeNode19.SelectedImageIndex = 0;
            treeNode19.Text = "应收款";
            treeNode20.ImageIndex = 0;
            treeNode20.Name = "content";
            treeNode20.SelectedImageIndex = 0;
            treeNode20.Text = "内容物";
            treeNode21.ImageIndex = 0;
            treeNode21.Name = "packingMaterial";
            treeNode21.SelectedImageIndex = 0;
            treeNode21.Text = "包材";
            treeNode22.ImageIndex = 0;
            treeNode22.Name = "carton";
            treeNode22.SelectedImageIndex = 0;
            treeNode22.Text = "彩盒";
            treeNode23.ImageIndex = 0;
            treeNode23.Name = "freight";
            treeNode23.SelectedImageIndex = 0;
            treeNode23.Text = "运费";
            treeNode24.ImageIndex = 1;
            treeNode24.Name = "payment";
            treeNode24.SelectedImageIndex = 1;
            treeNode24.Text = "应付款";
            treeNode25.ImageIndex = 1;
            treeNode25.Name = "financeManage";
            treeNode25.SelectedImageIndex = 1;
            treeNode25.Text = "财务管理";
            treeNode26.ImageIndex = 0;
            treeNode26.Name = "newProductImport";
            treeNode26.SelectedImageIndex = 0;
            treeNode26.Text = "新产品导入";
            treeNode27.ImageIndex = 0;
            treeNode27.Name = "newMaterialImport";
            treeNode27.SelectedImageIndex = 0;
            treeNode27.Text = "新物料导入";
            treeNode28.ImageIndex = 1;
            treeNode28.Name = "newImport";
            treeNode28.SelectedImageIndex = 1;
            treeNode28.Text = "新品导入";
            this.treeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode15,
            treeNode18,
            treeNode25,
            treeNode28});
            this.treeView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.treeView.RightToLeftLayout = true;
            this.treeView.SelectedImageIndex = 0;
            this.treeView.Size = new System.Drawing.Size(195, 364);
            this.treeView.TabIndex = 0;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "child.png");
            this.imageList.Images.SetKeyName(1, "parent.png");
            // 
            // dockPanel
            // 
            this.dockPanel.ActiveAutoHideContent = null;
            this.dockPanel.BackColor = System.Drawing.SystemColors.Control;
            this.dockPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanel.DocumentStyle = WeifenLuo.WinFormsUI.Docking.DocumentStyle.DockingWindow;
            this.dockPanel.Location = new System.Drawing.Point(0, 0);
            this.dockPanel.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.dockPanel.Name = "dockPanel";
            this.dockPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dockPanel.ShowPadIcon = false;
            this.dockPanel.Size = new System.Drawing.Size(391, 364);
            this.dockPanel.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(587, 364);
            this.Controls.Add(this.splitContainer);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "慧琳商贸公司信息技术系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TreeView treeView;
        private WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel;
        private System.Windows.Forms.ImageList imageList;







    }
}

