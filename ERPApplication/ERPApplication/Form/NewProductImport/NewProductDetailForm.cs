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
    public partial class NewProductDetailForm : Form
    {
        int productType;                //产品类别（1：彩妆，2：眉笔，3：周边）
        int operationType;              //操作类别（1：新建，2：编辑，3：查询）

        DataTable supplierTable = null;

        public NewProductDetailForm(int productType,int operationType)
        {
            InitializeComponent();
            initToolTip();
            setPropertyValue(productType, operationType);
            dispatchOperation();
        }

        private void initToolTip()
        {
            //设置提示信息
            this.toolTip.SetToolTip(this.boxLength,"请输入长度(cm)");
            this.toolTip.SetToolTip(this.boxWidth, "请输入宽度(cm)");
            this.toolTip.SetToolTip(this.boxHeight,"请输入高度(cm)");
        }

        private void setPropertyValue(int productType, int operationType)
        {
            this.productType = productType;
            this.operationType = operationType;
        }

        /*
         * 根据不同的产品类别和操作类别，进行相应初始化
         */
        private void dispatchOperation()
        {
            switch (this.productType)
            {
                case 1:         //彩妆类产品
                    switch (this.operationType)
                    {
                        case 1:
                            fillProductNo(1);
                            fillSupplier();
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                    }
                    break;

                case 2:         //眉笔类产品
                    initpackingMaterialRelatedContorl(false); 
                    switch (this.operationType)
                    {
                        case 1:
                            fillProductNo(2);
                            fillSupplier();
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                    }
                    break;

                case 3:         //周边类产品
                    initpackingMaterialRelatedContorl(false); 
                    initCartonRelatedContorl(false);  
                    switch (this.operationType)
                    {
                        case 1:
                            fillProductNo(3);
                            fillSupplier();
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                    }
                    break;
                default:
                    break;
            }

            setWindowFixed();
        }

        /*
         * 设置彩盒相关控件是否可见
         */
        private void initCartonRelatedContorl(bool flag)
        {
            this.choseCartonBtn.Visible = flag;
            this.cartongroupBox.Visible = flag;
            this.Height = 420;
        }

        /*
         * 设置包材相关控件是否可见
         */
        private void initpackingMaterialRelatedContorl(bool flag)
        {
            this.chosePackingMaterialBtn.Visible = flag;
            this.packingMaterialgroupBox.Visible = flag;
            this.Height = 530;
        }

        /*
         * 设置窗口不可放大缩小
         */
        private void setWindowFixed()
        {
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.MaximizeBox = false;
        }

        /*
         * 获取当前最大的可用编码，填充产品代码textBox
         */
        private void fillProductNo(int productType)
        {
            NewProductDetailManager newProductDetailManager = new NewProductDetailManager();
            switch (productType)
            {
                case 1:
                    this.productNo.Text = newProductDetailManager.queryBiggestCosmeticsNo();
                    break;
                case 2:
                    this.productNo.Text = newProductDetailManager.queryBiggestEyebrowPencilNo();
                    break;
                case 3:
                    this.productNo.Text = newProductDetailManager.queryBiggestPeripheralNo();
                    break;
                default:
                    break;
            }
        }

        /*
         * 获取供应商信息，填充供应商下拉框
         */
        private void fillSupplier()
        {
            NewProductDetailManager newProductDetailManager = new NewProductDetailManager();
           
            this.supplierTable = newProductDetailManager.querySupplierInformation();
            this.supplier.Items.Clear();

            foreach(DataRow currentRow in this.supplierTable.Rows)
            {
                if (!currentRow[1].Equals(DBNull.Value))
                {
                    this.supplier.Items.Add(currentRow[1].ToString());
                }
            }
        }

        /*
         * 检查产品基本信息是否填写完整
         */
        private bool checkProductIntegrity()
        {
            if (String.IsNullOrEmpty(this.productNo.Text) || this.productNo.Text == "error")
            {
                MessageBox.Show(this,
                                "生成产品代码错误！",
                                "保存产品信息错误",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }

            if (String.IsNullOrEmpty(this.chineseName.Text))
            {
                MessageBox.Show(this,
                                "产品中文名称不能为空！",
                                "保存产品信息提醒",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }

            if (String.IsNullOrEmpty(this.value.Text))
            {
                MessageBox.Show(this,
                                "单品含量不能为空！",
                                "保存产品信息提醒",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }

            if (this.unit.SelectedIndex < 0)
            {
                MessageBox.Show(this,
                                "请选择单品含量对应的单位：重量(g)或体积(ml)！",
                                "保存产品信息提醒",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }

            if (String.IsNullOrEmpty(this.boxContain.Text))
            {
                MessageBox.Show(this,
                                "装箱数量不能为空！",
                                "保存产品信息提醒",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }

            if (String.IsNullOrEmpty(this.boxLength.Text)|| 
                String.IsNullOrEmpty(this.boxWidth.Text) ||
                String.IsNullOrEmpty(this.boxHeight.Text))
            {
                MessageBox.Show(this,
                                "装箱尺寸（长、宽、高）不能为空！",
                                "保存产品信息提醒",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }

            if (String.IsNullOrEmpty(this.sellingPrice.Text))
            {
                MessageBox.Show(this,
                                "产品销售价格不能为空！",
                                "保存产品信息提醒",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }

            if (this.supplier.SelectedIndex < 0)
            {
                MessageBox.Show(this,
                                "产品销售商不能为空！",
                                "保存产品信息提醒",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        /*
         * 检查包材信息是否填写
         */
        private bool checkPackingMaterialIntegrity()
        {
            if (!this.packingMaterialgroupBox.Visible)
            {
                return false;
            }

            if (String.IsNullOrEmpty(this.packingMaterialNo.Text)||
                String.IsNullOrEmpty(this.packingMaterialColorNo.Text)||
                String.IsNullOrEmpty(this.packingMaterialFactoryNo.Text))
            {
                MessageBox.Show(this,
                                "包材信息不完整，请选择包材！",
                                "包材信息缺失提醒",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        /*
         * 检查彩盒信息是否填写
         */
        private bool checkCartonIntegrity()
        {
            if (!this.cartongroupBox.Visible)
            {
                return false;
            }

            if (String.IsNullOrEmpty(this.cartonNo.Text)||
                String.IsNullOrEmpty(this.cartonColorNo.Text)||
                String.IsNullOrEmpty(this.cartonFactoryNo.Text))
            {
                MessageBox.Show(this,
                                "彩盒信息不完整，请选择彩盒！",
                                "彩盒信息缺失提醒",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        /*
         * 将产品基本信息组织成MAP，便于数据插入操作（周边类产品）
         */
        private Dictionary<String, String> buildProductInforDict()
        {
            Dictionary<String, String> productInforDict = new Dictionary<String, String>();

            productInforDict.Add(this.productNo.Name,this.productNo.Text);
            productInforDict.Add(this.chineseName.Name,this.chineseName.Text);
            productInforDict.Add(this.englishName.Name,this.englishName.Text);
            productInforDict.Add(this.value.Name,this.value.Text);
            productInforDict.Add(this.boxContain.Name,this.boxContain.Text);
            productInforDict.Add(this.boxLength.Name,this.boxLength.Text);
            productInforDict.Add(this.boxWidth.Name,this.boxWidth.Text);
            productInforDict.Add(this.boxHeight.Name,this.boxHeight.Text);
            productInforDict.Add(this.sellingPrice.Name,this.sellingPrice.Text);
            productInforDict.Add(this.description.Name,this.description.Text);
            productInforDict.Add(this.unit.Name,this.unit.SelectedIndex == 0 ? "g" : "ml");

            return productInforDict;
        }

        /*
         * 将彩盒信息添加到产品信息MAP中（彩妆类产品）
         */
        private Dictionary<String, String> addCartonToDict()
        {
            Dictionary<String, String> productInforDict = buildProductInforDict();
            productInforDict.Add(this.cartonNo.Name, this.cartonNo.Text);
            return productInforDict;
        }

        /*
         * 将包材信息添加到产品信息MAP中（眉笔类产品）
         */
        private Dictionary<String, String> addPackingMaterialToDict()
        {
            Dictionary<String, String> productInforDict = addCartonToDict();
            productInforDict.Add(this.packingMaterialNo.Name,this.packingMaterialNo.Text);
            return productInforDict;
        }

        /*
         * 保存产品信息
         */
        private void saveBtn_Click(object sender, EventArgs e)
        {
            NewProductDetailManager newProductDetailManager = new NewProductDetailManager();

            switch (operationType)
            {
                case 1://新建
                    switch (productType)
                    {
                        case 1:     //彩妆类
                            if (checkProductIntegrity() &&
                                checkCartonIntegrity()  &&
                                checkPackingMaterialIntegrity())
                            {
                                newProductDetailManager.insertProduct(addPackingMaterialToDict());
                                newProductDetailManager.insertSupplierOfProduct(int.Parse(supplierTable.Rows[this.supplier.SelectedIndex][0].ToString()), this.productNo.Text);
                                this.DialogResult = DialogResult.OK;
                            }
                            break;
                        case 2:     //眉笔类
                            if (checkProductIntegrity() && checkCartonIntegrity())
                            {
                                newProductDetailManager.insertProduct(addCartonToDict());
                                newProductDetailManager.insertSupplierOfProduct(int.Parse(supplierTable.Rows[this.supplier.SelectedIndex][0].ToString()), this.productNo.Text);
                                this.DialogResult = DialogResult.OK;
                            }
                            break;
                        case 3:     //周边类
                            if (checkProductIntegrity())
                            {
                                newProductDetailManager.insertProduct(buildProductInforDict());
                                newProductDetailManager.insertSupplierOfProduct(int.Parse(supplierTable.Rows[this.supplier.SelectedIndex][0].ToString()), this.productNo.Text);
                                this.DialogResult = DialogResult.OK;
                            }
                            break;
                    }
                    break;

                case 2://编辑
                    break;

                default:
                    break;
            }
        }

        /*
         * 重置产品基本信息
         */
        private void resetControlInProductGroupBox()
        {
            foreach (Control ctl in this.productGroupBox.Controls)
            {
                if (ctl.GetType().Name == "TextBox" && ((TextBox)ctl).Name != "productNo")
                {
                    ((TextBox)ctl).Clear();
                }
                if (ctl.GetType().Name == "ComboBox")
                {
                    ((ComboBox)ctl).SelectedIndex = -1;
                }
            }
        }

        /*
         * 重置彩盒信息
         */
        private void resetContorlInCartonGroupBox()
        {
            this.cartonNo.Clear();
            this.cartonColorNo.Clear();
            this.cartonFactoryNo.Clear();
        }

        /*
         * 重置包材信息
         */
        private void resetControlInPackingMaterialGroupBox()
        {
            this.packingMaterialNo.Clear();
            this.packingMaterialColorNo.Clear();
            this.packingMaterialFactoryNo.Clear();
        }

        /*
         * 重置产品信息
         */
        private void resetBtn_Click(object sender, EventArgs e)
        {
            switch (productType)
            {
                case 1:
                    resetControlInProductGroupBox();
                    resetContorlInCartonGroupBox();
                    resetControlInPackingMaterialGroupBox();
                    break;
                case 2:
                    resetControlInProductGroupBox();
                    resetContorlInCartonGroupBox();
                    break;
                case 3:
                    resetControlInProductGroupBox();
                    break;
                default:
                    break;
            }
        }

        /*
         * 选择包材
         */
        private void chosePackingMaterialBtn_Click(object sender, EventArgs e)
        {
            PackingMaterialTableForm packingMaterial = new PackingMaterialTableForm();
            DialogResult dialogResult = packingMaterial.ShowDialog(this);

            if (dialogResult == DialogResult.OK)
            {
                this.packingMaterialNo.Text = packingMaterial.getPackingMaterialNo();
                this.packingMaterialColorNo.Text = packingMaterial.getColorNo();
                this.packingMaterialFactoryNo.Text = packingMaterial.getFactoryNo();
            }
        }

        /*
         * 选择彩盒
         */
        private void choseCartonBtn_Click(object sender, EventArgs e)
        {
            CartonTableForm cartonTable = new CartonTableForm();
            DialogResult dialogResult = cartonTable.ShowDialog(this);

            if (dialogResult == DialogResult.OK)
            {
                this.cartonNo.Text = cartonTable.getCartonNo();
                this.cartonColorNo.Text = cartonTable.getColorNo();
                this.cartonFactoryNo.Text = cartonTable.getFactoryNo();
            }
        }

        /*
         * 选择不同的供应商，供应商其他信息自动填写
         */
        private void supplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (operationType == 1)      //新建操作时候
            {
                int selectIndex = this.supplier.SelectedIndex;
                if (selectIndex >= 0 && this.supplierTable.Rows.Count > 0)
                {
                    this.majorContact.Text = this.supplierTable.Rows[selectIndex][2].ToString();
                    this.telephone.Text = this.supplierTable.Rows[selectIndex][3].ToString();
                    this.fax.Text = this.supplierTable.Rows[selectIndex][4].ToString();
                    this.address.Text = this.supplierTable.Rows[selectIndex][5].ToString();
                }
            }
        }

    }
}
