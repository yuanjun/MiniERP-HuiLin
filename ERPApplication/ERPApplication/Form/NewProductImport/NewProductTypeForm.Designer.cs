namespace ERPApplication
{
    partial class NewProductTypeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewProductTypeForm));
            this.label1 = new System.Windows.Forms.Label();
            this.cosmeticsRadio = new System.Windows.Forms.RadioButton();
            this.eyebrowsePencilRadio = new System.Windows.Forms.RadioButton();
            this.peripheralRadio = new System.Windows.Forms.RadioButton();
            this.okBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(44, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "请选择您要添加的产品类别：";
            // 
            // cosmeticsRadio
            // 
            this.cosmeticsRadio.AutoSize = true;
            this.cosmeticsRadio.Checked = true;
            this.cosmeticsRadio.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cosmeticsRadio.Location = new System.Drawing.Point(107, 74);
            this.cosmeticsRadio.Name = "cosmeticsRadio";
            this.cosmeticsRadio.Size = new System.Drawing.Size(97, 24);
            this.cosmeticsRadio.TabIndex = 1;
            this.cosmeticsRadio.TabStop = true;
            this.cosmeticsRadio.Text = "彩妆类产品";
            this.cosmeticsRadio.UseVisualStyleBackColor = true;
            // 
            // eyebrowsePencilRadio
            // 
            this.eyebrowsePencilRadio.AutoSize = true;
            this.eyebrowsePencilRadio.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.eyebrowsePencilRadio.Location = new System.Drawing.Point(107, 109);
            this.eyebrowsePencilRadio.Name = "eyebrowsePencilRadio";
            this.eyebrowsePencilRadio.Size = new System.Drawing.Size(97, 24);
            this.eyebrowsePencilRadio.TabIndex = 2;
            this.eyebrowsePencilRadio.TabStop = true;
            this.eyebrowsePencilRadio.Text = "眉笔类产品";
            this.eyebrowsePencilRadio.UseVisualStyleBackColor = true;
            // 
            // peripheralRadio
            // 
            this.peripheralRadio.AutoSize = true;
            this.peripheralRadio.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.peripheralRadio.Location = new System.Drawing.Point(107, 144);
            this.peripheralRadio.Name = "peripheralRadio";
            this.peripheralRadio.Size = new System.Drawing.Size(97, 24);
            this.peripheralRadio.TabIndex = 3;
            this.peripheralRadio.TabStop = true;
            this.peripheralRadio.Text = "周边类产品";
            this.peripheralRadio.UseVisualStyleBackColor = true;
            // 
            // okBtn
            // 
            this.okBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.okBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.okBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.okBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okBtn.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.okBtn.Location = new System.Drawing.Point(274, 190);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(90, 31);
            this.okBtn.TabIndex = 4;
            this.okBtn.Text = "确 定";
            this.okBtn.UseVisualStyleBackColor = false;
            // 
            // NewProductTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 233);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.peripheralRadio);
            this.Controls.Add(this.eyebrowsePencilRadio);
            this.Controls.Add(this.cosmeticsRadio);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(442, 271);
            this.MinimumSize = new System.Drawing.Size(442, 271);
            this.Name = "NewProductTypeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "添加产品类别";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton cosmeticsRadio;
        private System.Windows.Forms.RadioButton eyebrowsePencilRadio;
        private System.Windows.Forms.RadioButton peripheralRadio;
        private System.Windows.Forms.Button okBtn;
    }
}