namespace ERPApplication
{
    partial class HomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.unfinishedPOTable = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.handlingOrderTable = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.unfinishedOrderTable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            //this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabControl1 = new FullTabControl();
            this.productTabPage = new System.Windows.Forms.TabPage();
            this.productInventroyTable = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enterDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packingMaterialTabPage = new System.Windows.Forms.TabPage();
            this.packingMaterialTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paperBoxTabPage = new System.Windows.Forms.TabPage();
            this.paperBoxTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userPortrait = new System.Windows.Forms.PictureBox();
            this.username = new System.Windows.Forms.Label();
            this.verticalLine = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unfinishedPOTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.handlingOrderTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unfinishedOrderTable)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.productTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productInventroyTable)).BeginInit();
            this.packingMaterialTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.packingMaterialTable)).BeginInit();
            this.paperBoxTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paperBoxTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPortrait)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.unfinishedPOTable);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.handlingOrderTable);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.unfinishedOrderTable);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 662);
            this.panel1.TabIndex = 0;
            // 
            // unfinishedPOTable
            // 
            this.unfinishedPOTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.unfinishedPOTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.unfinishedPOTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.unfinishedPOTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.unfinishedPOTable.Location = new System.Drawing.Point(16, 516);
            this.unfinishedPOTable.Name = "unfinishedPOTable";
            this.unfinishedPOTable.RowTemplate.Height = 23;
            this.unfinishedPOTable.Size = new System.Drawing.Size(472, 123);
            this.unfinishedPOTable.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label5.Location = new System.Drawing.Point(13, 496);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "未完成PO";
            // 
            // handlingOrderTable
            // 
            this.handlingOrderTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.handlingOrderTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.handlingOrderTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.handlingOrderTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.handlingOrderTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.handlingOrderTable.Location = new System.Drawing.Point(17, 41);
            this.handlingOrderTable.Name = "handlingOrderTable";
            this.handlingOrderTable.RowTemplate.Height = 23;
            this.handlingOrderTable.Size = new System.Drawing.Size(472, 194);
            this.handlingOrderTable.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(14, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "待处理订单";
            // 
            // unfinishedOrderTable
            // 
            this.unfinishedOrderTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.unfinishedOrderTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.unfinishedOrderTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.unfinishedOrderTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.unfinishedOrderTable.Location = new System.Drawing.Point(16, 279);
            this.unfinishedOrderTable.Name = "unfinishedOrderTable";
            this.unfinishedOrderTable.RowTemplate.Height = 23;
            this.unfinishedOrderTable.Size = new System.Drawing.Size(472, 194);
            this.unfinishedOrderTable.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(13, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "未完成订单";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(531, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.tabControl1);
            this.panel3.Controls.Add(this.userPortrait);
            this.panel3.Controls.Add(this.username);
            this.panel3.Controls.Add(this.verticalLine);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.monthCalendar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(504, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(280, 662);
            this.panel3.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.productTabPage);
            this.tabControl1.Controls.Add(this.packingMaterialTabPage);
            this.tabControl1.Controls.Add(this.paperBoxTabPage);
            this.tabControl1.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.ItemSize = new System.Drawing.Size(83, 24);
            this.tabControl1.Location = new System.Drawing.Point(15, 346);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(253, 293);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 9;
            // 
            // productTabPage
            // 
            this.productTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.productTabPage.Controls.Add(this.productInventroyTable);
            this.productTabPage.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.productTabPage.Location = new System.Drawing.Point(4, 28);
            this.productTabPage.Name = "productTabPage";
            this.productTabPage.Size = new System.Drawing.Size(245, 261);
            this.productTabPage.TabIndex = 0;
            this.productTabPage.Text = "    成 品    ";
            // 
            // productInventroyTable
            // 
            this.productInventroyTable.AllowUserToAddRows = false;
            this.productInventroyTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productInventroyTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.productInventroyTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productInventroyTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.productInventroyTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productInventroyTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.inventory,
            this.enterDate});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productInventroyTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.productInventroyTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productInventroyTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.productInventroyTable.EnableHeadersVisualStyles = false;
            this.productInventroyTable.Location = new System.Drawing.Point(0, 0);
            this.productInventroyTable.Name = "productInventroyTable";
            this.productInventroyTable.RowHeadersVisible = false;
            this.productInventroyTable.RowTemplate.Height = 23;
            this.productInventroyTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productInventroyTable.Size = new System.Drawing.Size(245, 261);
            this.productInventroyTable.TabIndex = 0;
            // 
            // name
            // 
            this.name.HeaderText = "品名";
            this.name.Name = "name";
            // 
            // inventory
            // 
            this.inventory.HeaderText = "库存量";
            this.inventory.Name = "inventory";
            // 
            // enterDate
            // 
            this.enterDate.HeaderText = "进库日";
            this.enterDate.Name = "enterDate";
            // 
            // packingMaterialTabPage
            // 
            this.packingMaterialTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.packingMaterialTabPage.Controls.Add(this.packingMaterialTable);
            this.packingMaterialTabPage.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.packingMaterialTabPage.Location = new System.Drawing.Point(4, 28);
            this.packingMaterialTabPage.Name = "packingMaterialTabPage";
            this.packingMaterialTabPage.Size = new System.Drawing.Size(245, 261);
            this.packingMaterialTabPage.TabIndex = 1;
            this.packingMaterialTabPage.Text = "    包 材    ";
            // 
            // packingMaterialTable
            // 
            this.packingMaterialTable.AllowUserToAddRows = false;
            this.packingMaterialTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.packingMaterialTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.packingMaterialTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.packingMaterialTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.packingMaterialTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.packingMaterialTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.packingMaterialTable.DefaultCellStyle = dataGridViewCellStyle4;
            this.packingMaterialTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.packingMaterialTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.packingMaterialTable.EnableHeadersVisualStyles = false;
            this.packingMaterialTable.Location = new System.Drawing.Point(0, 0);
            this.packingMaterialTable.Name = "packingMaterialTable";
            this.packingMaterialTable.RowHeadersVisible = false;
            this.packingMaterialTable.RowTemplate.Height = 23;
            this.packingMaterialTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.packingMaterialTable.Size = new System.Drawing.Size(245, 261);
            this.packingMaterialTable.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "品名";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "库存量";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "进库日";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // paperBoxTabPage
            // 
            this.paperBoxTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.paperBoxTabPage.Controls.Add(this.paperBoxTable);
            this.paperBoxTabPage.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.paperBoxTabPage.Location = new System.Drawing.Point(4, 28);
            this.paperBoxTabPage.Margin = new System.Windows.Forms.Padding(0);
            this.paperBoxTabPage.Name = "paperBoxTabPage";
            this.paperBoxTabPage.Size = new System.Drawing.Size(245, 261);
            this.paperBoxTabPage.TabIndex = 2;
            this.paperBoxTabPage.Text = "   纸 盒   ";
            // 
            // paperBoxTable
            // 
            this.paperBoxTable.AllowUserToAddRows = false;
            this.paperBoxTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.paperBoxTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.paperBoxTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.paperBoxTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.paperBoxTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paperBoxTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.paperBoxTable.DefaultCellStyle = dataGridViewCellStyle6;
            this.paperBoxTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paperBoxTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.paperBoxTable.EnableHeadersVisualStyles = false;
            this.paperBoxTable.Location = new System.Drawing.Point(0, 0);
            this.paperBoxTable.Name = "paperBoxTable";
            this.paperBoxTable.RowHeadersVisible = false;
            this.paperBoxTable.RowTemplate.Height = 23;
            this.paperBoxTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.paperBoxTable.Size = new System.Drawing.Size(245, 261);
            this.paperBoxTable.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "品名";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "库存量";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "进库日";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // userPortrait
            // 
            this.userPortrait.Image = global::ERPApplication.Properties.Resources.portrait;
            this.userPortrait.Location = new System.Drawing.Point(41, 19);
            this.userPortrait.Name = "userPortrait";
            this.userPortrait.Size = new System.Drawing.Size(72, 72);
            this.userPortrait.TabIndex = 8;
            this.userPortrait.TabStop = false;
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("楷体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.username.ForeColor = System.Drawing.SystemColors.WindowText;
            this.username.Location = new System.Drawing.Point(119, 50);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(119, 15);
            this.username.TabIndex = 7;
            this.username.Text = "当前登录用户名";
            // 
            // verticalLine
            // 
            this.verticalLine.BackColor = System.Drawing.SystemColors.ControlDark;
            this.verticalLine.Dock = System.Windows.Forms.DockStyle.Left;
            this.verticalLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verticalLine.Location = new System.Drawing.Point(0, 0);
            this.verticalLine.Name = "verticalLine";
            this.verticalLine.Size = new System.Drawing.Size(1, 662);
            this.verticalLine.TabIndex = 6;
            this.verticalLine.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(105, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "库存状态";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // monthCalendar
            // 
            this.monthCalendar.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.monthCalendar.Location = new System.Drawing.Point(28, 113);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 2;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 662);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "HomeForm";
            this.TabText = "信息总览";
            this.Text = "信息总览";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unfinishedPOTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.handlingOrderTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unfinishedOrderTable)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.productTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productInventroyTable)).EndInit();
            this.packingMaterialTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.packingMaterialTable)).EndInit();
            this.paperBoxTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paperBoxTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPortrait)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox verticalLine;
        private System.Windows.Forms.DataGridView handlingOrderTable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView unfinishedOrderTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView unfinishedPOTable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox userPortrait;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage productTabPage;
        private System.Windows.Forms.TabPage packingMaterialTabPage;
        private System.Windows.Forms.TabPage paperBoxTabPage;
        private System.Windows.Forms.DataGridView productInventroyTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn enterDate;
        private System.Windows.Forms.DataGridView paperBoxTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridView packingMaterialTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;


    }
}