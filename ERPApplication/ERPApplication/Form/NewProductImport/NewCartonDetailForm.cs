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
    public partial class NewCartonDetailForm : Form
    {
        int operateFlag;                                //操作标识 1：增加；2：编辑；3：详情
        DataTable supplierInformation = null;
        Dictionary<String, String> cartonDict = null;
        Dictionary<String, String> supplierInforDict = null;

        public NewCartonDetailForm(int operateFlag,String cartonNo="")
        {
            InitializeComponent();
            init();

            this.operateFlag = operateFlag;
            if (operateFlag == 1)
            {
                fillCartonNo();
                fillSupplier();
            }
            else if (operateFlag == 2)
            {
                fillCartonInforTextBox(cartonNo);
                fillSupplierInforTextBox(cartonNo);
            }
            else if (operateFlag == 3)
            {
                fillCartonInforTextBox(cartonNo);
                fillSupplierInforTextBox(cartonNo);
                setContorlReadOnly();
            }
        }

        private void init()
        {
            this.toolTip.SetToolTip(this.length, "彩盒长度（单位mm）");
            this.toolTip.SetToolTip(this.width,  "彩盒宽度（单位mm）");
            this.toolTip.SetToolTip(this.height, "彩盒高度（单位mm）");
        }

        /*
         * 生成最新可用的彩盒编号
         */
        private void fillCartonNo()
        {
            NewCartonDetailManager newCartonDetailManager = new NewCartonDetailManager();
            this.cartonNo.Text = newCartonDetailManager.queryBiggestCartonNo();
        }

        /*
         * 获取供应商相关信息
         */
        private void fillSupplier()
        {
            NewCartonDetailManager newCartonDetailManager = new NewCartonDetailManager();
            this.supplierInformation = newCartonDetailManager.querySupplierInformation();

            this.supplier.Items.Clear();
            foreach (DataRow row in this.supplierInformation.Rows)
            {
                this.supplier.Items.Add(row[1].ToString());
            }
        }

        /*
         * 根据彩盒编号获取彩盒信息，填充各个TextBox
         */
        private void fillCartonInforTextBox(String cartonNo)
        {
            NewCartonDetailManager newCartonDetailManager = new NewCartonDetailManager();
            cartonDict = newCartonDetailManager.queryCartonInformationByCartonNo(cartonNo);
            
            foreach (Control ctl in this.cartonPanel.Controls)
            {
                if (ctl.GetType().Name == "TextBox" && cartonDict.ContainsKey(((TextBox)ctl).Name))
                {
                    ((TextBox)ctl).Text = cartonDict[((TextBox)ctl).Name];
                }
            }  
        }

        /*
         * 根据彩盒编号获取供应商信息，填充各个TextBox
         */
        private void fillSupplierInforTextBox(String cartonNo)
        {
            NewCartonDetailManager newCartonDetailManager = new NewCartonDetailManager();
            supplierInforDict = newCartonDetailManager.querySupplierOfCartonByCartonNo(cartonNo);

            foreach (Control ctl in this.supplierPanel.Controls)
            {
                if (ctl.GetType().Name == "TextBox" && supplierInforDict.ContainsKey(ctl.Name))
                {
                    ((TextBox)ctl).Text = supplierInforDict[ctl.Name];
                }
                else if (ctl.GetType().Name == "ComboBox" && supplierInforDict.ContainsKey(ctl.Name))
                {
                    ((ComboBox)ctl).Items.Clear();
                    ((ComboBox)ctl).Items.Add(supplierInforDict[ctl.Name]);
                    ((ComboBox)ctl).SelectedIndex = 0;
                }
            }
        }

        /*
         * 详情查看时设置各框不可编辑
         */
        private void setContorlReadOnly()
        {
            foreach (Control ctl in this.cartonPanel.Controls)
            {
                if(ctl.GetType().Name == "TextBox")
                {
                    ((TextBox)ctl).ReadOnly = true;
                }
            }
            foreach (Control ctl in this.supplierPanel.Controls)
            {
                if (ctl.GetType().Name == "TextBox")
                {
                    ((TextBox)ctl).ReadOnly = true;
                }
                else if (ctl.GetType().Name == "ComboBox")
                {
                    ((ComboBox)ctl).Enabled = false;
                }
            }

            this.saveBtn.Enabled = false;
            this.resetBtn.Enabled = false;
        }

        /*
         * 改选不同的供应商，自动填写如下相应信息
         */
        private void supplier_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (operateFlag == 1)
            {
                int selectIndex = this.supplier.SelectedIndex;
                if (selectIndex >= 0)
                {
                    this.majorContact.Text = this.supplierInformation.Rows[selectIndex][2].ToString();
                    this.telephone.Text = this.supplierInformation.Rows[selectIndex][3].ToString();
                    this.fax.Text = this.supplierInformation.Rows[selectIndex][4].ToString();
                    this.address.Text = this.supplierInformation.Rows[selectIndex][5].ToString();
                }
            }
        }

        /*
         * 构建彩盒基本信息MAP
         */
        private Dictionary<String, String> buildCartonInformationDict()
        {
            Dictionary<String, String> cartonInformationDict = new Dictionary<String, String>();
            foreach (Control ctl in this.cartonPanel.Controls)
            {
                if (ctl.GetType().Name == "TextBox")
                {
                    cartonInformationDict.Add(((TextBox)ctl).Name, ((TextBox)ctl).Text);
                }
            }
            return cartonInformationDict;
        }

        private Dictionary<String, String> buildCartonInformationDict2()
        {
            Dictionary<String, String> cartonInformationDict = new Dictionary<String, String>();
            foreach (Control ctl in this.cartonPanel.Controls)
            {
                if (ctl.GetType().Name == "TextBox" && ((TextBox)ctl).Name != this.cartonNo.Name)
                {
                    cartonInformationDict.Add(((TextBox)ctl).Name, ((TextBox)ctl).Text);
                }
            }
            return cartonInformationDict;
        }

        private bool checkIntegrity()
        {
            if (this.cartonNo.Text == "" || this.cartonNo.Text == "error")
            {
                MessageBox.Show(this,
                                "生成彩盒编号错误，请关闭窗口重试！",
                                "保存彩盒信息警告",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }

            if (this.colorNo.Text == "")
            {
                MessageBox.Show(this,
                                "彩盒色号不能为空，请填写！",
                                "保存彩盒信息警告",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }

            if (this.factoryNo.Text == "")
            {
                MessageBox.Show(this,
                                "彩盒工厂编码不能为空，请填写！",
                                "保存彩盒信息警告",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }

            if (this.chineseName.Text == "")
            {
                MessageBox.Show(this,
                                "彩盒中文名字不能为空，请填写！",
                                "保存彩盒信息警告",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }

            if (this.purchasePrice.Text == "")
            {
                MessageBox.Show(this,
                                "彩盒采购价格不能为空，请填写！",
                                "保存彩盒信息警告",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }

            if (this.length.Text == "" || this.width.Text == "" || this.height.Text == "")
            {
                MessageBox.Show(this,
                                "彩盒长、宽、高不能为空，请填写！",
                                "保存彩盒信息警告",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }

            if (this.supplier.SelectedIndex < 0)
            {
                MessageBox.Show(this,
                                "供应商信息不能为空，请选择！",
                                "保存彩盒信息警告",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        /*
         * 保存当前填写信息到数据库
         */
        private void saveBtn_Click(object sender, EventArgs e)
        {
            NewCartonDetailManager newCartonDetailManager = new NewCartonDetailManager();
            if (checkIntegrity() == true)
            {
                if (operateFlag == 1)
                {
                    //将彩盒基本信息插入数据库
                    newCartonDetailManager.insertNewCarton(buildCartonInformationDict());
                    //将彩盒和供应商关系插入数据库
                    newCartonDetailManager.insertSupplierCarton(int.Parse(this.supplierInformation.Rows[this.supplier.SelectedIndex][0].ToString()), this.cartonNo.Text);
                }
                else if (operateFlag == 2)
                {
                    //将修改后的彩盒信息保存到数据库(未更新相应供应商信息)
                    newCartonDetailManager.updateCartonInformationByCartonNo(this.cartonNo.Text, buildCartonInformationDict2());
                }

                this.Close();
            }
        }

        /*
         * 重置当前所填写的信息
         */
        private void resetBtn_Click(object sender, EventArgs e)
        {
            if (operateFlag == 1)
            {
                foreach (Control ctl in this.cartonPanel.Controls)
                {
                    if (ctl.GetType().Name == "TextBox" && ((TextBox)ctl).Name != this.cartonNo.Name)
                    {
                        ((TextBox)ctl).Text = "";
                    }
                }

                foreach (Control ctl in this.supplierPanel.Controls)
                {
                    if (ctl.GetType().Name == "TextBox")
                    {
                        ((TextBox)ctl).Text = "";
                    }
                    else if (ctl.GetType().Name == "ComboBox")
                    {
                        ((ComboBox)ctl).SelectedIndex = -1;
                    }
                }
            }
        }




    }
}
