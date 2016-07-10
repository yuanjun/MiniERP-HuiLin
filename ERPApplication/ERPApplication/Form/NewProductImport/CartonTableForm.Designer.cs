namespace ERPApplication
{
    partial class CartonTableForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cartonTable = new System.Windows.Forms.DataGridView();
            this.cartonNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartonColorNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartonFactoryNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartonSupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartonDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.horizontalLine = new System.Windows.Forms.GroupBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.packingMaterialTable = new System.Windows.Forms.DataGridView();
            this.packingMaterialNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factoryNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartonTable)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.packingMaterialTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.packingMaterialTable);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(814, 443);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.cartonTable);
            this.panel2.Location = new System.Drawing.Point(0, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(814, 396);
            this.panel2.TabIndex = 8;
            // 
            // cartonTable
            // 
            this.cartonTable.AllowUserToAddRows = false;
            this.cartonTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cartonTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.cartonTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cartonTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.cartonTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartonTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cartonNo,
            this.cartonName,
            this.cartonColorNo,
            this.cartonFactoryNo,
            this.cartonSupplier,
            this.cartonDescription});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cartonTable.DefaultCellStyle = dataGridViewCellStyle8;
            this.cartonTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartonTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.cartonTable.EnableHeadersVisualStyles = false;
            this.cartonTable.Location = new System.Drawing.Point(0, 0);
            this.cartonTable.MultiSelect = false;
            this.cartonTable.Name = "cartonTable";
            this.cartonTable.RowHeadersVisible = false;
            this.cartonTable.RowTemplate.Height = 23;
            this.cartonTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cartonTable.Size = new System.Drawing.Size(814, 396);
            this.cartonTable.TabIndex = 9;
            // 
            // cartonNo
            // 
            this.cartonNo.DataPropertyName = "cartonNo";
            this.cartonNo.HeaderText = "彩盒代码";
            this.cartonNo.Name = "cartonNo";
            this.cartonNo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cartonNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cartonName
            // 
            this.cartonName.DataPropertyName = "chineseName";
            this.cartonName.HeaderText = "彩盒名称";
            this.cartonName.Name = "cartonName";
            // 
            // cartonColorNo
            // 
            this.cartonColorNo.DataPropertyName = "colorNo";
            this.cartonColorNo.HeaderText = "彩盒色号";
            this.cartonColorNo.Name = "cartonColorNo";
            this.cartonColorNo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cartonColorNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cartonFactoryNo
            // 
            this.cartonFactoryNo.DataPropertyName = "factoryNo";
            this.cartonFactoryNo.HeaderText = "工厂编码";
            this.cartonFactoryNo.Name = "cartonFactoryNo";
            this.cartonFactoryNo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cartonFactoryNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cartonSupplier
            // 
            this.cartonSupplier.DataPropertyName = "supplierName";
            this.cartonSupplier.HeaderText = "供应商";
            this.cartonSupplier.Name = "cartonSupplier";
            this.cartonSupplier.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cartonSupplier.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cartonDescription
            // 
            this.cartonDescription.DataPropertyName = "description";
            this.cartonDescription.HeaderText = "描述";
            this.cartonDescription.Name = "cartonDescription";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Controls.Add(this.horizontalLine);
            this.panel3.Controls.Add(this.cancelBtn);
            this.panel3.Controls.Add(this.okBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(814, 48);
            this.panel3.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Location = new System.Drawing.Point(0, 46);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(814, 1);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // horizontalLine
            // 
            this.horizontalLine.BackColor = System.Drawing.SystemColors.WindowText;
            this.horizontalLine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.horizontalLine.Location = new System.Drawing.Point(0, 47);
            this.horizontalLine.Name = "horizontalLine";
            this.horizontalLine.Size = new System.Drawing.Size(814, 1);
            this.horizontalLine.TabIndex = 5;
            this.horizontalLine.TabStop = false;
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.cancelBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cancelBtn.Location = new System.Drawing.Point(220, 10);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 31);
            this.cancelBtn.TabIndex = 3;
            this.cancelBtn.Text = "取 消";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // okBtn
            // 
            this.okBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.okBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.okBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.okBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okBtn.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.okBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.okBtn.Location = new System.Drawing.Point(85, 10);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 31);
            this.okBtn.TabIndex = 2;
            this.okBtn.Text = "确 定";
            this.okBtn.UseVisualStyleBackColor = false;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // packingMaterialTable
            // 
            this.packingMaterialTable.AllowUserToAddRows = false;
            this.packingMaterialTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.packingMaterialTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.packingMaterialTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.packingMaterialTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.packingMaterialTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.packingMaterialTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.packingMaterialNo,
            this.colorNo,
            this.factoryNo,
            this.supplier,
            this.description});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.packingMaterialTable.DefaultCellStyle = dataGridViewCellStyle6;
            this.packingMaterialTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.packingMaterialTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.packingMaterialTable.EnableHeadersVisualStyles = false;
            this.packingMaterialTable.Location = new System.Drawing.Point(0, 0);
            this.packingMaterialTable.Name = "packingMaterialTable";
            this.packingMaterialTable.RowHeadersVisible = false;
            this.packingMaterialTable.RowTemplate.Height = 23;
            this.packingMaterialTable.Size = new System.Drawing.Size(814, 443);
            this.packingMaterialTable.TabIndex = 6;
            // 
            // packingMaterialNo
            // 
            this.packingMaterialNo.HeaderText = "包材代码";
            this.packingMaterialNo.Name = "packingMaterialNo";
            this.packingMaterialNo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.packingMaterialNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colorNo
            // 
            this.colorNo.HeaderText = "包材色号";
            this.colorNo.Name = "colorNo";
            this.colorNo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colorNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // factoryNo
            // 
            this.factoryNo.HeaderText = "工厂编码";
            this.factoryNo.Name = "factoryNo";
            this.factoryNo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.factoryNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // supplier
            // 
            this.supplier.HeaderText = "供应商";
            this.supplier.Name = "supplier";
            this.supplier.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.supplier.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // description
            // 
            this.description.HeaderText = "描述";
            this.description.Name = "description";
            // 
            // CartonTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 443);
            this.Controls.Add(this.panel1);
            this.Name = "CartonTableForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "彩盒列表";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cartonTable)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.packingMaterialTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox horizontalLine;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.DataGridView packingMaterialTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn packingMaterialNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn factoryNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView cartonTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn cartonNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cartonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cartonColorNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cartonFactoryNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cartonSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn cartonDescription;
    }
}