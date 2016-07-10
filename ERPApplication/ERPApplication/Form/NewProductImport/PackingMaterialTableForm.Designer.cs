namespace ERPApplication
{
    partial class PackingMaterialTableForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.packingMaterialTable = new System.Windows.Forms.DataGridView();
            this.packingMaterialNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packingMaterialName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factoryNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.horizontalLine = new System.Windows.Forms.GroupBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.packingMaterialTable)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
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
            this.panel2.Controls.Add(this.packingMaterialTable);
            this.panel2.Location = new System.Drawing.Point(0, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(814, 392);
            this.panel2.TabIndex = 6;
            // 
            // packingMaterialTable
            // 
            this.packingMaterialTable.AllowUserToAddRows = false;
            this.packingMaterialTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.packingMaterialTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.packingMaterialTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.packingMaterialTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.packingMaterialTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.packingMaterialTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.packingMaterialNo,
            this.packingMaterialName,
            this.colorNo,
            this.factoryNo,
            this.supplier,
            this.description});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.packingMaterialTable.DefaultCellStyle = dataGridViewCellStyle4;
            this.packingMaterialTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.packingMaterialTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.packingMaterialTable.EnableHeadersVisualStyles = false;
            this.packingMaterialTable.Location = new System.Drawing.Point(0, 0);
            this.packingMaterialTable.MultiSelect = false;
            this.packingMaterialTable.Name = "packingMaterialTable";
            this.packingMaterialTable.RowHeadersVisible = false;
            this.packingMaterialTable.RowTemplate.Height = 23;
            this.packingMaterialTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.packingMaterialTable.Size = new System.Drawing.Size(814, 392);
            this.packingMaterialTable.TabIndex = 0;
            // 
            // packingMaterialNo
            // 
            this.packingMaterialNo.DataPropertyName = "packingMaterialNo";
            this.packingMaterialNo.HeaderText = "包材代码";
            this.packingMaterialNo.Name = "packingMaterialNo";
            this.packingMaterialNo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.packingMaterialNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // packingMaterialName
            // 
            this.packingMaterialName.DataPropertyName = "chineseName";
            this.packingMaterialName.HeaderText = "包材名称";
            this.packingMaterialName.Name = "packingMaterialName";
            // 
            // colorNo
            // 
            this.colorNo.DataPropertyName = "colorNo";
            this.colorNo.HeaderText = "包材色号";
            this.colorNo.Name = "colorNo";
            this.colorNo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colorNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // factoryNo
            // 
            this.factoryNo.DataPropertyName = "factoryNo";
            this.factoryNo.HeaderText = "工厂编码";
            this.factoryNo.Name = "factoryNo";
            this.factoryNo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.factoryNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // supplier
            // 
            this.supplier.DataPropertyName = "supplierName";
            this.supplier.HeaderText = "供应商";
            this.supplier.Name = "supplier";
            this.supplier.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.supplier.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "描述";
            this.description.Name = "description";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.horizontalLine);
            this.panel3.Controls.Add(this.cancelBtn);
            this.panel3.Controls.Add(this.okBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(814, 48);
            this.panel3.TabIndex = 5;
            // 
            // horizontalLine
            // 
            this.horizontalLine.BackColor = System.Drawing.SystemColors.ControlDark;
            this.horizontalLine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.horizontalLine.ForeColor = System.Drawing.SystemColors.ControlDark;
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
            // PackingMaterialTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 443);
            this.Controls.Add(this.panel1);
            this.Name = "PackingMaterialTableForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "包材列表";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.packingMaterialTable)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox horizontalLine;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView packingMaterialTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn packingMaterialNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn packingMaterialName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn factoryNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
    }
}