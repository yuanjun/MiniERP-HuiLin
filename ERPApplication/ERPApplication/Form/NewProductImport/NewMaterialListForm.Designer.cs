namespace ERPApplication
{
    partial class NewMaterialListForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchBtn = new System.Windows.Forms.Button();
            this.horizontalLine = new System.Windows.Forms.GroupBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.packingMaterialSum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.packingMaterialTable = new System.Windows.Forms.DataGridView();
            this.packingMaterialNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packingMaterialName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factoryNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packingMaterialText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartonTable = new System.Windows.Forms.DataGridView();
            this.cartonNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartonColorNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartonFactoryNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartonSupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartonText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartonSum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.packingMaterialMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addPackingMaterialItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editPackingMaterialItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removePackingMaterialItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailPackingMaterialItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cartonMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addCartonItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCartonItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeCartonItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailCartonItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.packingMaterialTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartonTable)).BeginInit();
            this.packingMaterialMenu.SuspendLayout();
            this.cartonMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.searchBtn);
            this.panel1.Controls.Add(this.horizontalLine);
            this.panel1.Controls.Add(this.addBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 48);
            this.panel1.TabIndex = 2;
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.searchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.searchBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.searchBtn.Location = new System.Drawing.Point(193, 10);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 31);
            this.searchBtn.TabIndex = 6;
            this.searchBtn.Text = "查 询";
            this.searchBtn.UseVisualStyleBackColor = false;
            // 
            // horizontalLine
            // 
            this.horizontalLine.BackColor = System.Drawing.SystemColors.WindowText;
            this.horizontalLine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.horizontalLine.Location = new System.Drawing.Point(0, 47);
            this.horizontalLine.Name = "horizontalLine";
            this.horizontalLine.Size = new System.Drawing.Size(788, 1);
            this.horizontalLine.TabIndex = 5;
            this.horizontalLine.TabStop = false;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.addBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.addBtn.Location = new System.Drawing.Point(62, 10);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 31);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = "添 加";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // packingMaterialSum
            // 
            this.packingMaterialSum.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.packingMaterialSum.Location = new System.Drawing.Point(153, 74);
            this.packingMaterialSum.Name = "packingMaterialSum";
            this.packingMaterialSum.ReadOnly = true;
            this.packingMaterialSum.Size = new System.Drawing.Size(259, 25);
            this.packingMaterialSum.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(57, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "包材类总数：";
            // 
            // packingMaterialTable
            // 
            this.packingMaterialTable.AllowUserToAddRows = false;
            this.packingMaterialTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.packingMaterialTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.packingMaterialTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.packingMaterialTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.packingMaterialTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.packingMaterialTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.packingMaterialTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.packingMaterialNo,
            this.packingMaterialName,
            this.colorNo,
            this.factoryNo,
            this.supplier,
            this.packingMaterialText});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.packingMaterialTable.DefaultCellStyle = dataGridViewCellStyle6;
            this.packingMaterialTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.packingMaterialTable.EnableHeadersVisualStyles = false;
            this.packingMaterialTable.Location = new System.Drawing.Point(61, 108);
            this.packingMaterialTable.MultiSelect = false;
            this.packingMaterialTable.Name = "packingMaterialTable";
            this.packingMaterialTable.RowHeadersVisible = false;
            this.packingMaterialTable.RowTemplate.Height = 23;
            this.packingMaterialTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.packingMaterialTable.Size = new System.Drawing.Size(671, 282);
            this.packingMaterialTable.TabIndex = 9;
            this.packingMaterialTable.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.packingMaterialTable_CellMouseDown);
            // 
            // packingMaterialNo
            // 
            this.packingMaterialNo.DataPropertyName = "packingMaterialNo";
            this.packingMaterialNo.HeaderText = "包材代码";
            this.packingMaterialNo.MaxInputLength = 10;
            this.packingMaterialNo.Name = "packingMaterialNo";
            // 
            // packingMaterialName
            // 
            this.packingMaterialName.DataPropertyName = "chineseName";
            this.packingMaterialName.HeaderText = "品名";
            this.packingMaterialName.Name = "packingMaterialName";
            // 
            // colorNo
            // 
            this.colorNo.DataPropertyName = "colorNo";
            this.colorNo.HeaderText = "色号";
            this.colorNo.Name = "colorNo";
            // 
            // factoryNo
            // 
            this.factoryNo.DataPropertyName = "factoryNo";
            this.factoryNo.HeaderText = "包材工厂编号";
            this.factoryNo.Name = "factoryNo";
            // 
            // supplier
            // 
            this.supplier.DataPropertyName = "supplierName";
            this.supplier.HeaderText = "供应商";
            this.supplier.Name = "supplier";
            // 
            // packingMaterialText
            // 
            this.packingMaterialText.DataPropertyName = "description";
            this.packingMaterialText.HeaderText = "包材描述";
            this.packingMaterialText.Name = "packingMaterialText";
            // 
            // cartonTable
            // 
            this.cartonTable.AllowUserToAddRows = false;
            this.cartonTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cartonTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cartonTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.cartonTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cartonTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.cartonTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartonTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cartonNo,
            this.name,
            this.cartonColorNo,
            this.cartonFactoryNo,
            this.cartonSupplier,
            this.cartonText});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cartonTable.DefaultCellStyle = dataGridViewCellStyle8;
            this.cartonTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.cartonTable.EnableHeadersVisualStyles = false;
            this.cartonTable.Location = new System.Drawing.Point(62, 452);
            this.cartonTable.MultiSelect = false;
            this.cartonTable.Name = "cartonTable";
            this.cartonTable.RowHeadersVisible = false;
            this.cartonTable.RowTemplate.Height = 23;
            this.cartonTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cartonTable.Size = new System.Drawing.Size(671, 148);
            this.cartonTable.TabIndex = 12;
            this.cartonTable.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.cartonTable_CellMouseDown);
            // 
            // cartonNo
            // 
            this.cartonNo.DataPropertyName = "cartonNo";
            this.cartonNo.HeaderText = "彩盒代码";
            this.cartonNo.Name = "cartonNo";
            // 
            // name
            // 
            this.name.DataPropertyName = "chineseName";
            this.name.HeaderText = "品名";
            this.name.Name = "name";
            // 
            // cartonColorNo
            // 
            this.cartonColorNo.DataPropertyName = "colorNo";
            this.cartonColorNo.HeaderText = "色号";
            this.cartonColorNo.Name = "cartonColorNo";
            // 
            // cartonFactoryNo
            // 
            this.cartonFactoryNo.DataPropertyName = "factoryNo";
            this.cartonFactoryNo.HeaderText = "彩盒工厂编号";
            this.cartonFactoryNo.Name = "cartonFactoryNo";
            // 
            // cartonSupplier
            // 
            this.cartonSupplier.DataPropertyName = "supplierName";
            this.cartonSupplier.HeaderText = "供应商";
            this.cartonSupplier.Name = "cartonSupplier";
            // 
            // cartonText
            // 
            this.cartonText.DataPropertyName = "description";
            this.cartonText.HeaderText = "彩盒描述";
            this.cartonText.Name = "cartonText";
            // 
            // cartonSum
            // 
            this.cartonSum.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cartonSum.Location = new System.Drawing.Point(153, 418);
            this.cartonSum.Name = "cartonSum";
            this.cartonSum.ReadOnly = true;
            this.cartonSum.Size = new System.Drawing.Size(259, 25);
            this.cartonSum.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(58, 419);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "彩盒类总数：";
            // 
            // packingMaterialMenu
            // 
            this.packingMaterialMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPackingMaterialItem,
            this.editPackingMaterialItem,
            this.removePackingMaterialItem,
            this.detailPackingMaterialItem});
            this.packingMaterialMenu.Name = "packingMaterialMenu";
            this.packingMaterialMenu.Size = new System.Drawing.Size(101, 92);
            // 
            // addPackingMaterialItem
            // 
            this.addPackingMaterialItem.Name = "addPackingMaterialItem";
            this.addPackingMaterialItem.Size = new System.Drawing.Size(152, 22);
            this.addPackingMaterialItem.Text = "添加";
            this.addPackingMaterialItem.Click += new System.EventHandler(this.addPackingMaterialItem_Click);
            // 
            // editPackingMaterialItem
            // 
            this.editPackingMaterialItem.Name = "editPackingMaterialItem";
            this.editPackingMaterialItem.Size = new System.Drawing.Size(152, 22);
            this.editPackingMaterialItem.Text = "编辑";
            this.editPackingMaterialItem.Click += new System.EventHandler(this.editPackingMaterialItem_Click);
            // 
            // removePackingMaterialItem
            // 
            this.removePackingMaterialItem.Name = "removePackingMaterialItem";
            this.removePackingMaterialItem.Size = new System.Drawing.Size(152, 22);
            this.removePackingMaterialItem.Text = "删除";
            this.removePackingMaterialItem.Click += new System.EventHandler(this.removePackingMaterialItem_Click);
            // 
            // detailPackingMaterialItem
            // 
            this.detailPackingMaterialItem.Name = "detailPackingMaterialItem";
            this.detailPackingMaterialItem.Size = new System.Drawing.Size(152, 22);
            this.detailPackingMaterialItem.Text = "详情";
            this.detailPackingMaterialItem.Click += new System.EventHandler(this.detailPackingMaterialItem_Click);
            // 
            // cartonMenu
            // 
            this.cartonMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCartonItem,
            this.editCartonItem,
            this.removeCartonItem,
            this.detailCartonItem});
            this.cartonMenu.Name = "cartonMenu";
            this.cartonMenu.Size = new System.Drawing.Size(153, 114);
            // 
            // addCartonItem
            // 
            this.addCartonItem.Name = "addCartonItem";
            this.addCartonItem.Size = new System.Drawing.Size(100, 22);
            this.addCartonItem.Text = "添加";
            this.addCartonItem.Click += new System.EventHandler(this.addCartonItem_Click);
            // 
            // editCartonItem
            // 
            this.editCartonItem.Name = "editCartonItem";
            this.editCartonItem.Size = new System.Drawing.Size(100, 22);
            this.editCartonItem.Text = "编辑";
            this.editCartonItem.Click += new System.EventHandler(this.editCartonItem_Click);
            // 
            // removeCartonItem
            // 
            this.removeCartonItem.Name = "removeCartonItem";
            this.removeCartonItem.Size = new System.Drawing.Size(100, 22);
            this.removeCartonItem.Text = "删除";
            this.removeCartonItem.Click += new System.EventHandler(this.removeCartonItem_Click);
            // 
            // detailCartonItem
            // 
            this.detailCartonItem.Name = "detailCartonItem";
            this.detailCartonItem.Size = new System.Drawing.Size(152, 22);
            this.detailCartonItem.Text = "详情";
            this.detailCartonItem.Click += new System.EventHandler(this.detailCartonItem_Click);
            // 
            // NewMaterialListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 612);
            this.Controls.Add(this.cartonTable);
            this.Controls.Add(this.cartonSum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.packingMaterialTable);
            this.Controls.Add(this.packingMaterialSum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "NewMaterialListForm";
            this.TabText = "新物料导入总览";
            this.Text = "新物料导入总览";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.packingMaterialTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartonTable)).EndInit();
            this.packingMaterialMenu.ResumeLayout(false);
            this.cartonMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.GroupBox horizontalLine;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox packingMaterialSum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView packingMaterialTable;
        private System.Windows.Forms.DataGridView cartonTable;
        private System.Windows.Forms.TextBox cartonSum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn packingMaterialNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn packingMaterialName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn factoryNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn packingMaterialText;
        private System.Windows.Forms.DataGridViewTextBoxColumn cartonNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn cartonColorNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cartonFactoryNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cartonSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn cartonText;
        private System.Windows.Forms.ContextMenuStrip packingMaterialMenu;
        private System.Windows.Forms.ContextMenuStrip cartonMenu;
        private System.Windows.Forms.ToolStripMenuItem addPackingMaterialItem;
        private System.Windows.Forms.ToolStripMenuItem editPackingMaterialItem;
        private System.Windows.Forms.ToolStripMenuItem removePackingMaterialItem;
        private System.Windows.Forms.ToolStripMenuItem addCartonItem;
        private System.Windows.Forms.ToolStripMenuItem editCartonItem;
        private System.Windows.Forms.ToolStripMenuItem removeCartonItem;
        private System.Windows.Forms.ToolStripMenuItem detailPackingMaterialItem;
        private System.Windows.Forms.ToolStripMenuItem detailCartonItem;
    }
}