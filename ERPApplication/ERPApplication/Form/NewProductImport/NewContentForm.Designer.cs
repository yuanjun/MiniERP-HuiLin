namespace ERPApplication
{
    partial class NewContentForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.choseProductBtn = new System.Windows.Forms.Button();
            this.horizontalLine = new System.Windows.Forms.GroupBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chineseName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.productNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.contentGroupBox = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.costPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.factoryNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.colorNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.contentGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.choseProductBtn);
            this.panel1.Controls.Add(this.horizontalLine);
            this.panel1.Controls.Add(this.saveBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 48);
            this.panel1.TabIndex = 3;
            // 
            // choseProductBtn
            // 
            this.choseProductBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.choseProductBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.choseProductBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.choseProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.choseProductBtn.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.choseProductBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.choseProductBtn.Location = new System.Drawing.Point(193, 10);
            this.choseProductBtn.Name = "choseProductBtn";
            this.choseProductBtn.Size = new System.Drawing.Size(112, 31);
            this.choseProductBtn.TabIndex = 6;
            this.choseProductBtn.Text = "选择所属产品";
            this.choseProductBtn.UseVisualStyleBackColor = false;
            this.choseProductBtn.Click += new System.EventHandler(this.choseProductBtn_Click);
            // 
            // horizontalLine
            // 
            this.horizontalLine.BackColor = System.Drawing.SystemColors.WindowText;
            this.horizontalLine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.horizontalLine.Location = new System.Drawing.Point(0, 47);
            this.horizontalLine.Name = "horizontalLine";
            this.horizontalLine.Size = new System.Drawing.Size(816, 1);
            this.horizontalLine.TabIndex = 5;
            this.horizontalLine.TabStop = false;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.saveBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.saveBtn.Location = new System.Drawing.Point(62, 10);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 31);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.Text = "保 存";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.Controls.Add(this.groupBox2);
            this.mainPanel.Controls.Add(this.contentGroupBox);
            this.mainPanel.Controls.Add(this.label4);
            this.mainPanel.Location = new System.Drawing.Point(0, 48);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(816, 275);
            this.mainPanel.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chineseName);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.description);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.productNo);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(49, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(732, 113);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "产品固定信息";
            // 
            // chineseName
            // 
            this.chineseName.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chineseName.Location = new System.Drawing.Point(466, 30);
            this.chineseName.Name = "chineseName";
            this.chineseName.ReadOnly = true;
            this.chineseName.Size = new System.Drawing.Size(240, 25);
            this.chineseName.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(391, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "产品名称：";
            // 
            // description
            // 
            this.description.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.description.Location = new System.Drawing.Point(106, 71);
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Size = new System.Drawing.Size(600, 25);
            this.description.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(32, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "产品描述：";
            // 
            // productNo
            // 
            this.productNo.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.productNo.Location = new System.Drawing.Point(106, 30);
            this.productNo.Name = "productNo";
            this.productNo.ReadOnly = true;
            this.productNo.Size = new System.Drawing.Size(223, 25);
            this.productNo.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(32, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "产品代码：";
            // 
            // contentGroupBox
            // 
            this.contentGroupBox.Controls.Add(this.label8);
            this.contentGroupBox.Controls.Add(this.costPrice);
            this.contentGroupBox.Controls.Add(this.label3);
            this.contentGroupBox.Controls.Add(this.factoryNo);
            this.contentGroupBox.Controls.Add(this.label2);
            this.contentGroupBox.Controls.Add(this.colorNo);
            this.contentGroupBox.Controls.Add(this.label1);
            this.contentGroupBox.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.contentGroupBox.Location = new System.Drawing.Point(49, 17);
            this.contentGroupBox.Name = "contentGroupBox";
            this.contentGroupBox.Size = new System.Drawing.Size(732, 113);
            this.contentGroupBox.TabIndex = 9;
            this.contentGroupBox.TabStop = false;
            this.contentGroupBox.Text = "内容物信息";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(681, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "￥";
            // 
            // costPrice
            // 
            this.costPrice.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.costPrice.Location = new System.Drawing.Point(466, 30);
            this.costPrice.Name = "costPrice";
            this.costPrice.Size = new System.Drawing.Size(240, 25);
            this.costPrice.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(391, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "成本价格：";
            // 
            // factoryNo
            // 
            this.factoryNo.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.factoryNo.Location = new System.Drawing.Point(106, 71);
            this.factoryNo.Name = "factoryNo";
            this.factoryNo.Size = new System.Drawing.Size(600, 25);
            this.factoryNo.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(30, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "工厂编码：";
            // 
            // colorNo
            // 
            this.colorNo.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.colorNo.Location = new System.Drawing.Point(106, 30);
            this.colorNo.Name = "colorNo";
            this.colorNo.Size = new System.Drawing.Size(240, 25);
            this.colorNo.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(32, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "色号：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(743, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "￥";
            // 
            // NewContentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 323);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(832, 361);
            this.MinimumSize = new System.Drawing.Size(832, 361);
            this.Name = "NewContentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "新内容物";
            this.panel1.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.contentGroupBox.ResumeLayout(false);
            this.contentGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button choseProductBtn;
        private System.Windows.Forms.GroupBox horizontalLine;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox contentGroupBox;
        private System.Windows.Forms.TextBox costPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox factoryNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox colorNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox chineseName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox productNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;

    }
}