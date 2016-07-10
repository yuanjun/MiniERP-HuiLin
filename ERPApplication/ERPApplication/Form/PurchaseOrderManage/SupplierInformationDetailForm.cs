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
    public partial class SupplierInformationDetailForm : Form
    {
        int operateFlag;        //操作标识  1：新增供应商；2：编辑、查询供应商
        int supplierNo;         //供应商编号

        public SupplierInformationDetailForm(int operateFlag)
        {
            InitializeComponent();

            this.operateFlag = operateFlag;
            if (this.operateFlag == 1)
            {
                setProductListInvisible();
            }
        }

        /*
         * 新增供应商时禁止编辑产品，同时缩小窗口大小
         */
        public void setProductListInvisible()
        {
            this.productList.Visible = false;
            this.productListLabel.Visible = false;
            this.Height = 293;
        }

        /*
         * 显示选中的一列所对应的供应商详细信息
         */
        public void fillSupplierPrimaryInfor(Dictionary<String,String> supplierInforDict)
        {
            foreach (Control ctl in this.mainPanel.Controls)
            {
                if (ctl.GetType().Name == "TextBox" && supplierInforDict.ContainsKey(((TextBox)ctl).Name))
                {
                    ((TextBox)ctl).Text = supplierInforDict[((TextBox)ctl).Name];
                }
            }
        }

        /*
         * 设置供应商编号
         */
        public void setSupplierNo(int supplierNo)
        {
            this.supplierNo = supplierNo;
        }

        /*
         * 检查信息是否填写完整
         */
        private bool checkIntegrity()
        {
            if (this.name.Text == "")
            {
                MessageBox.Show(this,"信息填写不完整：供应商名字不能为空！","保存信息提醒");
                return false;
            }
            //若需要检测更多项为必填则可在后面添加
            return true;
        }

        /*
         * 将所填写信息组织成Map(去掉空项)
         */
        private Dictionary<String, String> buildSupplierInformationDict()
        {
            Dictionary<String, String> supplierInforDict = new Dictionary<String, String>();
            foreach (Control ctl in this.mainPanel.Controls)
            {
                if (ctl.GetType().Name == "TextBox")
                {
                    String ctlName = ((TextBox)ctl).Name;
                    String ctlValue = ((TextBox)ctl).Text;
                    if (ctlValue != "")
                    {
                        supplierInforDict.Add(ctlName, ctlValue);
                    }
                }
            }
            return supplierInforDict;
        }

        /*
         * 将所填写信息组织成Map(保留空项)
         */
        private Dictionary<String, String> buildSupplierInformationDict2()
        {
            Dictionary<String, String> supplierInforDict = new Dictionary<String, String>();
            foreach (Control ctl in this.mainPanel.Controls)
            {
                if (ctl.GetType().Name == "TextBox")
                {
                    String ctlName = ((TextBox)ctl).Name;
                    String ctlValue = ((TextBox)ctl).Text;
                    supplierInforDict.Add(ctlName, ctlValue);
                }
            }
            return supplierInforDict;
        }

        /*
         * 保存供应商信息
         */
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (checkIntegrity() == true)
            {
                SupplierInformationDetailManager supplierInformationDetailManager = new SupplierInformationDetailManager();
                
                if(operateFlag == 1)
                {
                    supplierInformationDetailManager.insertSupplier(buildSupplierInformationDict());
                }
                else if(operateFlag == 2)
                {
                    supplierInformationDetailManager.updateSupplier(buildSupplierInformationDict2(), supplierNo);
                }

                this.Close();
            }
        }

        /*
         * 将所有TextBox信息清空
         */
        private void clearAllInformation()
        {
            foreach (Control ctl in this.mainPanel.Controls)
            {
                if (ctl.GetType().Name == "TextBox")
                {
                    ((TextBox)ctl).Text = "";
                }
            }
        }

        /*
         * 重置供应商信息
         */
        private void resetBtn_Click(object sender, EventArgs e)
        {
            if (operateFlag == 1)
            {
                clearAllInformation();
            }
        }
    }
}
