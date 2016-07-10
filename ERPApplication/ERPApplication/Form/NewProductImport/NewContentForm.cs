using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ERPApplication
{
    public partial class NewContentForm : Form
    {
        public NewContentForm()
        {
            InitializeComponent();
        }

        private void fillProductTable()
        {
        }

        /*
         * 检查信息是否填写完整
         */
        private bool checkInformationIntegrity()
        {
            if (String.IsNullOrEmpty(this.colorNo.Text)||
                String.IsNullOrEmpty(this.factoryNo.Text)||
                String.IsNullOrEmpty(this.costPrice.Text))
            {
                MessageBox.Show(this,
                                "内容物信息填写不完整，请完善！",
                                "保存内容物提醒",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }

            if (String.IsNullOrEmpty(this.productNo.Text)||
                String.IsNullOrEmpty(this.chineseName.Text)||
                String.IsNullOrEmpty(this.description.Text))
            {
                MessageBox.Show(this,
                                "内容物所属产品信息不完整，请选择！",
                                "保存内容物提醒",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        /*
         * 构造内容物信息MAP
         */
        private Dictionary<String, String> buildContentInforDict()
        {
            Dictionary<String, String> contentInforDict = new Dictionary<String, String>();

            contentInforDict.Add(this.productNo.Name,this.productNo.Text);
            contentInforDict.Add(this.colorNo.Name,this.colorNo.Text);
            contentInforDict.Add(this.factoryNo.Name,this.factoryNo.Text);
            contentInforDict.Add(this.costPrice.Name,this.costPrice.Text);

            return contentInforDict;
        }
        /*
         * 保存内容物信息
         */
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (checkInformationIntegrity())
            {
                NewContentManager newContentManager = new NewContentManager();
                newContentManager.insertContent(buildContentInforDict());
                this.DialogResult = DialogResult.OK;
            }
        }

        /*
         * 选择内容物所属产品
         */
        private void choseProductBtn_Click(object sender, EventArgs e)
        {
            ProductTableForm productTableForm = new ProductTableForm();
            DialogResult rst = productTableForm.ShowDialog(this);
            if (rst == DialogResult.OK)
            {
                this.productNo.Text = productTableForm.getProductNo();
                this.chineseName.Text = productTableForm.getProductName();
                this.description.Text = productTableForm.getProductDescription();
            }
        }
    }
}
