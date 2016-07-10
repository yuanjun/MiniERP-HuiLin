namespace ERPApplication
{
    partial class MailForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.emailTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.emailBody = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.attachmentLocation = new System.Windows.Forms.TextBox();
            this.openFile = new System.Windows.Forms.Button();
            this.emailAddress = new System.Windows.Forms.TextBox();
            this.contactsList = new System.Windows.Forms.ListBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.config = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(49, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "收件人地址：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(49, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "邮件主题：";
            // 
            // emailTitle
            // 
            this.emailTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.emailTitle.Location = new System.Drawing.Point(139, 78);
            this.emailTitle.Name = "emailTitle";
            this.emailTitle.Size = new System.Drawing.Size(383, 21);
            this.emailTitle.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(49, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "邮件正文：";
            // 
            // emailBody
            // 
            this.emailBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.emailBody.Location = new System.Drawing.Point(139, 123);
            this.emailBody.Name = "emailBody";
            this.emailBody.Size = new System.Drawing.Size(383, 145);
            this.emailBody.TabIndex = 5;
            this.emailBody.Text = "";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(49, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "添加附件：";
            // 
            // attachmentLocation
            // 
            this.attachmentLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.attachmentLocation.Location = new System.Drawing.Point(139, 296);
            this.attachmentLocation.Name = "attachmentLocation";
            this.attachmentLocation.ReadOnly = true;
            this.attachmentLocation.Size = new System.Drawing.Size(334, 21);
            this.attachmentLocation.TabIndex = 7;
            // 
            // openFile
            // 
            this.openFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.openFile.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.openFile.Location = new System.Drawing.Point(481, 295);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(40, 23);
            this.openFile.TabIndex = 8;
            this.openFile.Text = "浏览";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // emailAddress
            // 
            this.emailAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.emailAddress.Location = new System.Drawing.Point(139, 40);
            this.emailAddress.Name = "emailAddress";
            this.emailAddress.Size = new System.Drawing.Size(383, 21);
            this.emailAddress.TabIndex = 9;
            // 
            // contactsList
            // 
            this.contactsList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.contactsList.FormattingEnabled = true;
            this.contactsList.ItemHeight = 12;
            this.contactsList.Location = new System.Drawing.Point(574, 40);
            this.contactsList.Name = "contactsList";
            this.contactsList.Size = new System.Drawing.Size(148, 280);
            this.contactsList.TabIndex = 10;
            // 
            // sendBtn
            // 
            this.sendBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.sendBtn.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sendBtn.Location = new System.Drawing.Point(169, 349);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(141, 28);
            this.sendBtn.TabIndex = 11;
            this.sendBtn.Text = "发  送";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cancelBtn.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cancelBtn.Location = new System.Drawing.Point(395, 349);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(141, 28);
            this.cancelBtn.TabIndex = 12;
            this.cancelBtn.Text = "取  消";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // config
            // 
            this.config.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.config.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.config.Location = new System.Drawing.Point(679, 365);
            this.config.Name = "config";
            this.config.Size = new System.Drawing.Size(59, 23);
            this.config.TabIndex = 13;
            this.config.Text = "配置";
            this.config.UseVisualStyleBackColor = true;
            this.config.Click += new System.EventHandler(this.config_Click);
            // 
            // MailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 400);
            this.Controls.Add(this.config);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.contactsList);
            this.Controls.Add(this.emailAddress);
            this.Controls.Add(this.openFile);
            this.Controls.Add(this.attachmentLocation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.emailBody);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.emailTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MailForm";
            this.Text = "邮件信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox emailBody;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox attachmentLocation;
        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.TextBox emailAddress;
        private System.Windows.Forms.ListBox contactsList;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button config;
    }
}