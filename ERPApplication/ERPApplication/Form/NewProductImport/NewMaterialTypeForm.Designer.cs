namespace ERPApplication
{
    partial class NewMaterialTypeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewMaterialTypeForm));
            this.label1 = new System.Windows.Forms.Label();
            this.cartonRadio = new System.Windows.Forms.RadioButton();
            this.packingMaterialRadio = new System.Windows.Forms.RadioButton();
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
            this.label1.TabIndex = 1;
            this.label1.Text = "请选择您要添加的产品类别：";
            // 
            // cartonRadio
            // 
            this.cartonRadio.AutoSize = true;
            this.cartonRadio.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cartonRadio.Location = new System.Drawing.Point(144, 108);
            this.cartonRadio.Name = "cartonRadio";
            this.cartonRadio.Size = new System.Drawing.Size(55, 24);
            this.cartonRadio.TabIndex = 4;
            this.cartonRadio.TabStop = true;
            this.cartonRadio.Text = "彩盒";
            this.cartonRadio.UseVisualStyleBackColor = true;
            // 
            // packingMaterialRadio
            // 
            this.packingMaterialRadio.AutoSize = true;
            this.packingMaterialRadio.Checked = true;
            this.packingMaterialRadio.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.packingMaterialRadio.Location = new System.Drawing.Point(144, 74);
            this.packingMaterialRadio.Name = "packingMaterialRadio";
            this.packingMaterialRadio.Size = new System.Drawing.Size(55, 24);
            this.packingMaterialRadio.TabIndex = 3;
            this.packingMaterialRadio.TabStop = true;
            this.packingMaterialRadio.Text = "包材";
            this.packingMaterialRadio.UseVisualStyleBackColor = true;
            // 
            // okBtn
            // 
            this.okBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.okBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.okBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.okBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okBtn.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.okBtn.Location = new System.Drawing.Point(262, 154);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(90, 31);
            this.okBtn.TabIndex = 5;
            this.okBtn.Text = "确 定";
            this.okBtn.UseVisualStyleBackColor = false;
            // 
            // NewMaterialTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 206);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.cartonRadio);
            this.Controls.Add(this.packingMaterialRadio);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(436, 244);
            this.MinimumSize = new System.Drawing.Size(436, 244);
            this.Name = "NewMaterialTypeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "添加物料类别";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton cartonRadio;
        private System.Windows.Forms.RadioButton packingMaterialRadio;
        private System.Windows.Forms.Button okBtn;
    }
}