namespace ERPApplication
{
    partial class MailConfigForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sendUsername = new System.Windows.Forms.TextBox();
            this.sendPassword = new System.Windows.Forms.TextBox();
            this.editBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.switchDisplayType = new System.Windows.Forms.Button();
            this.configTip = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.switchDisplayType);
            this.groupBox1.Controls.Add(this.saveBtn);
            this.groupBox1.Controls.Add(this.editBtn);
            this.groupBox1.Controls.Add(this.sendPassword);
            this.groupBox1.Controls.Add(this.sendUsername);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(44, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(493, 214);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "邮件发送账户配置";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "邮箱用户名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "邮箱密码：";
            // 
            // sendUsername
            // 
            this.sendUsername.Location = new System.Drawing.Point(150, 53);
            this.sendUsername.Name = "sendUsername";
            this.sendUsername.Size = new System.Drawing.Size(273, 25);
            this.sendUsername.TabIndex = 2;
            // 
            // sendPassword
            // 
            this.sendPassword.Location = new System.Drawing.Point(150, 93);
            this.sendPassword.Name = "sendPassword";
            this.sendPassword.Size = new System.Drawing.Size(273, 25);
            this.sendPassword.TabIndex = 3;
            this.sendPassword.UseSystemPasswordChar = true;
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(236, 153);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(75, 31);
            this.editBtn.TabIndex = 4;
            this.editBtn.Text = "编 辑";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(348, 153);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 31);
            this.saveBtn.TabIndex = 5;
            this.saveBtn.Text = "保 存";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // switchDisplayType
            // 
            this.switchDisplayType.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.switchDisplayType.Location = new System.Drawing.Point(430, 93);
            this.switchDisplayType.Name = "switchDisplayType";
            this.switchDisplayType.Size = new System.Drawing.Size(45, 25);
            this.switchDisplayType.TabIndex = 6;
            this.switchDisplayType.Text = "明/密";
            this.switchDisplayType.UseVisualStyleBackColor = true;
            this.switchDisplayType.Click += new System.EventHandler(this.switchDisplayType_Click);
            // 
            // configTip
            // 
            this.configTip.Location = new System.Drawing.Point(44, 263);
            this.configTip.Multiline = true;
            this.configTip.Name = "configTip";
            this.configTip.ReadOnly = true;
            this.configTip.Size = new System.Drawing.Size(493, 60);
            this.configTip.TabIndex = 1;
            this.configTip.Text = "配置提示：\r\n            此界面用于配置邮件发送方账户信息，对于新浪邮箱和QQ邮箱均验证可用。请确保该账户的SMTP服务已开启，否则可能导致异常。关于" +
                "SMTP服务开启方法请咨询度娘。";
            // 
            // MailConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 341);
            this.Controls.Add(this.configTip);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MailConfigForm";
            this.Text = "邮件参数配置";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sendUsername;
        private System.Windows.Forms.TextBox sendPassword;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button switchDisplayType;
        private System.Windows.Forms.TextBox configTip;
    }
}