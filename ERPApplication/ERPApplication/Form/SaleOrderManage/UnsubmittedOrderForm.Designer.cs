namespace ERPApplication
{
    partial class UnsubmittedOrderForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.showAllBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.unsubmittedOrderTable = new System.Windows.Forms.DataGridView();
            this.orderNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transportType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneyType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unsubmittedOrderTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.unsubmittedOrderTable);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(732, 367);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.showAllBtn);
            this.panel1.Controls.Add(this.removeBtn);
            this.panel1.Controls.Add(this.searchBtn);
            this.panel1.Controls.Add(this.editBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 63);
            this.panel1.TabIndex = 1;
            // 
            // showAllBtn
            // 
            this.showAllBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.showAllBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showAllBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.showAllBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showAllBtn.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.showAllBtn.Location = new System.Drawing.Point(333, 14);
            this.showAllBtn.Name = "showAllBtn";
            this.showAllBtn.Size = new System.Drawing.Size(77, 32);
            this.showAllBtn.TabIndex = 4;
            this.showAllBtn.Text = "显示全部";
            this.showAllBtn.UseVisualStyleBackColor = false;
            this.showAllBtn.Click += new System.EventHandler(this.showAllBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.removeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.removeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeBtn.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.removeBtn.Location = new System.Drawing.Point(199, 14);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(75, 32);
            this.removeBtn.TabIndex = 3;
            this.removeBtn.Text = "删 除";
            this.removeBtn.UseVisualStyleBackColor = false;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.searchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.searchBtn.Location = new System.Drawing.Point(328, 14);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(0, 0);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "条件查询";
            this.searchBtn.UseVisualStyleBackColor = false;
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.editBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.editBtn.Location = new System.Drawing.Point(64, 14);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(75, 32);
            this.editBtn.TabIndex = 1;
            this.editBtn.Text = "编 辑";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // unsubmittedOrderTable
            // 
            this.unsubmittedOrderTable.AllowUserToAddRows = false;
            this.unsubmittedOrderTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.unsubmittedOrderTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.unsubmittedOrderTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.unsubmittedOrderTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.unsubmittedOrderTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.unsubmittedOrderTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.unsubmittedOrderTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderNo,
            this.orderState,
            this.clientName,
            this.orderDate,
            this.transportType,
            this.moneyType,
            this.remarks});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.unsubmittedOrderTable.DefaultCellStyle = dataGridViewCellStyle6;
            this.unsubmittedOrderTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.unsubmittedOrderTable.EnableHeadersVisualStyles = false;
            this.unsubmittedOrderTable.Location = new System.Drawing.Point(0, 64);
            this.unsubmittedOrderTable.Name = "unsubmittedOrderTable";
            this.unsubmittedOrderTable.RowHeadersVisible = false;
            this.unsubmittedOrderTable.RowTemplate.Height = 23;
            this.unsubmittedOrderTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.unsubmittedOrderTable.Size = new System.Drawing.Size(732, 303);
            this.unsubmittedOrderTable.TabIndex = 0;
            // 
            // orderNo
            // 
            this.orderNo.DataPropertyName = "saleNo";
            this.orderNo.HeaderText = "订单编号";
            this.orderNo.Name = "orderNo";
            // 
            // orderState
            // 
            this.orderState.DataPropertyName = "state";
            this.orderState.HeaderText = "订单状态";
            this.orderState.Name = "orderState";
            // 
            // clientName
            // 
            this.clientName.DataPropertyName = "name";
            this.clientName.HeaderText = "客户名称";
            this.clientName.Name = "clientName";
            // 
            // orderDate
            // 
            this.orderDate.DataPropertyName = "startDate";
            this.orderDate.HeaderText = "订单日期";
            this.orderDate.Name = "orderDate";
            // 
            // transportType
            // 
            this.transportType.DataPropertyName = "transportName";
            this.transportType.HeaderText = "运输方式";
            this.transportType.Name = "transportType";
            // 
            // moneyType
            // 
            this.moneyType.DataPropertyName = "currencyName";
            this.moneyType.HeaderText = "交易币种";
            this.moneyType.Name = "moneyType";
            // 
            // remarks
            // 
            this.remarks.DataPropertyName = "remarks";
            this.remarks.HeaderText = "备注";
            this.remarks.Name = "remarks";
            // 
            // UnsubmittedOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 367);
            this.Controls.Add(this.panel2);
            this.Name = "UnsubmittedOrderForm";
            this.TabText = "未提交订单";
            this.Text = "未提交订单";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.unsubmittedOrderTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView unsubmittedOrderTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button showAllBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderState;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn transportType;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneyType;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarks;
    }
}