namespace ERPApplication
{
    partial class FinishedOrderForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.finishedOrderTable = new System.Windows.Forms.DataGridView();
            this.orderNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transportType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneyType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.finishedOrderTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.finishedOrderTable);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 367);
            this.panel1.TabIndex = 0;
            // 
            // finishedOrderTable
            // 
            this.finishedOrderTable.AllowUserToAddRows = false;
            this.finishedOrderTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.finishedOrderTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.finishedOrderTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.finishedOrderTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.finishedOrderTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.finishedOrderTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderNo,
            this.orderState,
            this.clientName,
            this.orderDate,
            this.transportType,
            this.moneyType,
            this.remarks});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.finishedOrderTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.finishedOrderTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.finishedOrderTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.finishedOrderTable.EnableHeadersVisualStyles = false;
            this.finishedOrderTable.Location = new System.Drawing.Point(0, 0);
            this.finishedOrderTable.Name = "finishedOrderTable";
            this.finishedOrderTable.RowHeadersVisible = false;
            this.finishedOrderTable.RowTemplate.Height = 23;
            this.finishedOrderTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.finishedOrderTable.Size = new System.Drawing.Size(732, 367);
            this.finishedOrderTable.TabIndex = 4;
            this.finishedOrderTable.DoubleClick += new System.EventHandler(this.finishedOrderTable_DoubleClick);
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
            // FinishedOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 367);
            this.Controls.Add(this.panel1);
            this.Name = "FinishedOrderForm";
            this.TabText = "已完成订单";
            this.Text = "已完成订单";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.finishedOrderTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView finishedOrderTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderState;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn transportType;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneyType;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarks;
    }
}