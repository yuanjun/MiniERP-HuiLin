namespace ERPApplication
{
    partial class ProductListForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.searchCondition = new System.Windows.Forms.ComboBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.horizontalLine = new System.Windows.Forms.GroupBox();
            this.okBtn = new System.Windows.Forms.Button();
            this.productTable = new System.Windows.Forms.DataGridView();
            this.choseFlag = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.productNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chineseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factoryNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.searchCondition);
            this.panel1.Controls.Add(this.cancelBtn);
            this.panel1.Controls.Add(this.horizontalLine);
            this.panel1.Controls.Add(this.okBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(764, 48);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(534, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "【筛选条件】";
            // 
            // searchCondition
            // 
            this.searchCondition.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.searchCondition.FormattingEnabled = true;
            this.searchCondition.Items.AddRange(new object[] {
            "全部产品",
            "彩妆类产品",
            "眉笔类产品",
            "周边类产品"});
            this.searchCondition.Location = new System.Drawing.Point(340, 14);
            this.searchCondition.Name = "searchCondition";
            this.searchCondition.Size = new System.Drawing.Size(193, 25);
            this.searchCondition.TabIndex = 7;
            this.searchCondition.SelectedIndexChanged += new System.EventHandler(this.searchCondition_SelectedIndexChanged);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.cancelBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cancelBtn.Location = new System.Drawing.Point(193, 10);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 31);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "取 消";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // horizontalLine
            // 
            this.horizontalLine.BackColor = System.Drawing.SystemColors.WindowText;
            this.horizontalLine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.horizontalLine.Location = new System.Drawing.Point(0, 47);
            this.horizontalLine.Name = "horizontalLine";
            this.horizontalLine.Size = new System.Drawing.Size(764, 1);
            this.horizontalLine.TabIndex = 5;
            this.horizontalLine.TabStop = false;
            // 
            // okBtn
            // 
            this.okBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.okBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.okBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.okBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okBtn.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.okBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.okBtn.Location = new System.Drawing.Point(62, 10);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 31);
            this.okBtn.TabIndex = 2;
            this.okBtn.Text = "确 定";
            this.okBtn.UseVisualStyleBackColor = false;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // productTable
            // 
            this.productTable.AllowUserToAddRows = false;
            this.productTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.productTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.productTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.choseFlag,
            this.productNo,
            this.chineseName,
            this.colorNo,
            this.factoryNo,
            this.inventory,
            this.sellingPrice});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.productTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productTable.EnableHeadersVisualStyles = false;
            this.productTable.Location = new System.Drawing.Point(0, 48);
            this.productTable.MultiSelect = false;
            this.productTable.Name = "productTable";
            this.productTable.RowHeadersVisible = false;
            this.productTable.RowTemplate.Height = 23;
            this.productTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productTable.Size = new System.Drawing.Size(764, 296);
            this.productTable.TabIndex = 6;
            // 
            // choseFlag
            // 
            this.choseFlag.FillWeight = 1F;
            this.choseFlag.HeaderText = "选择";
            this.choseFlag.MinimumWidth = 80;
            this.choseFlag.Name = "choseFlag";
            // 
            // productNo
            // 
            this.productNo.DataPropertyName = "productNo";
            this.productNo.HeaderText = "产品代码";
            this.productNo.Name = "productNo";
            // 
            // chineseName
            // 
            this.chineseName.DataPropertyName = "chineseName";
            this.chineseName.HeaderText = "品名";
            this.chineseName.Name = "chineseName";
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
            this.factoryNo.HeaderText = "工厂编码";
            this.factoryNo.Name = "factoryNo";
            // 
            // inventory
            // 
            this.inventory.DataPropertyName = "inventory";
            this.inventory.HeaderText = "库存";
            this.inventory.Name = "inventory";
            // 
            // sellingPrice
            // 
            this.sellingPrice.DataPropertyName = "sellingPrice";
            this.sellingPrice.HeaderText = "单价($)";
            this.sellingPrice.Name = "sellingPrice";
            // 
            // ProductListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 344);
            this.Controls.Add(this.productTable);
            this.Controls.Add(this.panel1);
            this.Name = "ProductListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "产品列表";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox searchCondition;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.GroupBox horizontalLine;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.DataGridView productTable;
        private System.Windows.Forms.DataGridViewCheckBoxColumn choseFlag;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn chineseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn factoryNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellingPrice;
    }
}