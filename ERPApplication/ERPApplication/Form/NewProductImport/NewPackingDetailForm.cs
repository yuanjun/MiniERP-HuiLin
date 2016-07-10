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
    public partial class NewPackingDetailForm : Form
    {
        int operateFlag;                            //操作标识，1：添加；2：编辑；3：详情
        DataTable supplierInformation = null;
        Dictionary<String, String> packingMaterilDict = null;
        Dictionary<String, String> supplierInforDict = null;

        public NewPackingDetailForm(int operateFlag,String packingMaterialNo="W0000")
        {
            InitializeComponent();

            this.operateFlag = operateFlag;
            if (this.operateFlag == 1)
            {
                fillPackingNoTextBox();
                fillSupplierComboBox();
            }
            else if (this.operateFlag == 2)
            {
                initFormByPackingMaterialNo(packingMaterialNo);
            }
            else if (this.operateFlag == 3)
            {
                initFormByPackingMaterialNo(packingMaterialNo);
                setControlReadOnly();
            }
            
        }

        /*
         * 根据包材编号，获取包材其他信息，以及供应商信息
         */
        private void initFormByPackingMaterialNo(String packingMaterialNo)
        {
            NewPackingDetailManager newPackingDetailManager = new NewPackingDetailManager();
            packingMaterilDict = newPackingDetailManager.queryPackingMaterialInformationByNo(packingMaterialNo);
            supplierInforDict = newPackingDetailManager.querySupplierOfPackingMaterialByNo(packingMaterialNo);

            foreach (Control ctl in this.mainPanel.Controls)
            {
                if (ctl.GetType().Name == "TextBox")
                {
                    TextBox textBox = (TextBox)ctl;
                    if (packingMaterilDict.ContainsKey(textBox.Name))
                    {
                        textBox.Text = packingMaterilDict[textBox.Name];
                    }
                    else if (supplierInforDict.ContainsKey(textBox.Name))
                    {
                        textBox.Text = supplierInforDict[textBox.Name];
                    }
                }
                else if (ctl.GetType().Name == "ComboBox")
                {
                    ComboBox comboBox = (ComboBox)ctl;
                    if (supplierInforDict.ContainsKey(comboBox.Name))
                    {
                        comboBox.Items.Clear();
                        comboBox.Items.Add(supplierInforDict[comboBox.Name]);
                        comboBox.SelectedIndex = 0;
                    }   
                }
            }
        }

        /*
         * 遍历控件，设置为readOnly
         */
        private void setControlReadOnly()
        {
            foreach (Control ctl in this.mainPanel.Controls)
            {
                if (ctl.GetType().Name == "TextBox")
                {
                    ((TextBox)ctl).ReadOnly = true;
                }
                if (ctl.GetType().Name == "ComboBox")
                {
                    ((ComboBox)ctl).Enabled = false;
                }
            }

            this.saveBtn.Enabled = false;
            this.resetBtn.Enabled = false;
        }

        /*
         * 生成包材代码
         */
        private String createPackingMaterialNo()
        {
            NewPackingDetailManager newPackingDetailManager = new NewPackingDetailManager();
            return newPackingDetailManager.queryBiggestPackingMaterialNo();
        }

        /*
         * 填充包材编号textBox
         */
        private void fillPackingNoTextBox()
        {
            this.packingMaterialNo.Text = createPackingMaterialNo();
        }

        /*
         * 填充供应商combobox
         */
        private void fillSupplierComboBox()
        {
            NewPackingDetailManager newPackingDetailManager = new NewPackingDetailManager();
            supplierInformation = newPackingDetailManager.querySupplierInformation();

            foreach(DataRow row in supplierInformation.Rows)
            {
                this.supplier.Items.Add(row[1]);
            }
        }

        /*
         * 选择供应商名字，自动填充相关信息
         */
        private void supplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.supplier.SelectedIndex;
            if(index >= 0 && supplierInformation != null && supplierInformation.Rows.Count > 0)
            {
                this.majorContact.Text = supplierInformation.Rows[index][2].ToString();
                this.telephone.Text = supplierInformation.Rows[index][3].ToString();
                this.fax.Text = supplierInformation.Rows[index][4].ToString();
                this.address.Text = supplierInformation.Rows[index][5].ToString();
            }
        }

        /*
         * 检查信息是否填写完整
         */
        private bool checkIntegrity()
        {
            if (this.packingMaterialNo.Text == "" || this.packingMaterialNo.Text == "error")
            {
                MessageBox.Show(this,
                                "生成包材编号错误，请关闭窗口重试！",
                                "保存包材信息警告",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }

            if (this.colorNo.Text == "")
            {
                MessageBox.Show(this,
                                "包材色号为空，请填写完整！",
                                "保存包材信息警告",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }

            if (this.factoryNo.Text == "")
            {
                MessageBox.Show(this,
                                "包材工厂编码为空，请填写完整！",
                                "保存包材信息警告",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }

            if (this.chineseName.Text == "")
            {
                MessageBox.Show(this,
                                "包材中文名字为空，请填写完整！",
                                "保存包材信息警告",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }

            if (this.purchasePrice.Text == "")
            {
                MessageBox.Show(this,
                                "包材采购价格为空，请填写完整！",
                                "保存包材信息警告",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }

            if (this.supplier.SelectedIndex < 0)
            {
                MessageBox.Show(this,
                                "包材供应商为空，请选择！",
                                "保存包材信息警告",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        /*
         * 将填写信息和控件名字组织成MAP
         */
        private Dictionary<String, String> buildPackingMaterialDict()
        {
            Dictionary<String, String> packingMaterialDict = new Dictionary<String, String>();

            packingMaterialDict.Add(this.packingMaterialNo.Name,this.packingMaterialNo.Text);
            packingMaterialDict.Add(this.colorNo.Name,this.colorNo.Text);
            packingMaterialDict.Add(this.factoryNo.Name, this.factoryNo.Text);
            packingMaterialDict.Add(this.chineseName.Name,this.chineseName.Text);
            packingMaterialDict.Add(this.englishName.Name,this.englishName.Text);
            packingMaterialDict.Add(this.purchasePrice.Name,this.purchasePrice.Text);
            packingMaterialDict.Add(this.description.Name,this.description.Text);

            return packingMaterialDict;
        }

        /*
         * 将包材编号外的其他信息组织成MAP
         */
        private Dictionary<String, String> buildPackingMaterialDict2()
        {
            Dictionary<String, String> packingMaterialDict = new Dictionary<String, String>();

            packingMaterialDict.Add(this.colorNo.Name, this.colorNo.Text);
            packingMaterialDict.Add(this.factoryNo.Name, this.factoryNo.Text);
            packingMaterialDict.Add(this.chineseName.Name, this.chineseName.Text);
            packingMaterialDict.Add(this.englishName.Name, this.englishName.Text);
            packingMaterialDict.Add(this.purchasePrice.Name, this.purchasePrice.Text);
            packingMaterialDict.Add(this.description.Name, this.description.Text);

            return packingMaterialDict;
        }

        /*
         * 保存包材信息
         */
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (checkIntegrity() == true)
            {
                NewPackingDetailManager newPackingDetailManager = new NewPackingDetailManager();
                if (operateFlag == 1)
                {
                    newPackingDetailManager.insertNewPackingMaterial(buildPackingMaterialDict(), int.Parse(supplierInformation.Rows[this.supplier.SelectedIndex][0].ToString()));
                }
                else if (operateFlag == 2)
                {
                    //没有更新包材对应的供应商信息
                    newPackingDetailManager.updatePackingMaterialInformation(buildPackingMaterialDict2(),this.packingMaterialNo.Text);
                }

                this.Close();
            }
        }

        /*
         * 重置当前所填写信息（包材编号不重置）
         */
        private void resetBtn_Click(object sender, EventArgs e)
        {
            foreach (Control ctl in this.mainPanel.Controls)
            {
                if (ctl.GetType().Name == "TextBox" && ((TextBox)ctl).Name != "packingMaterialNo")
                {
                    ((TextBox)ctl).Text = "";
                }
            }

            this.supplier.SelectedIndex = -1;
        }
    }
}
