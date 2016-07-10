using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

using WeifenLuo.WinFormsUI.Docking;

namespace ERPApplication
{
    public partial class NewSaleOrderForm : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        
        int operateType;                    //操作类别，1表示新建订单；2表示未提交~关闭阶段订单；3表示已删除订单
        int packingTableRowIndex;           //标记鼠标点击装箱单表时的行
        int productTableRowIndex;           //标记鼠标点击订单产品列表时的行

        Dictionary<String, int> clients = null;
        Dictionary<String, int> transportModes = null;
        Dictionary<String, int> tradingCurrencys = null;

        public NewSaleOrderForm(int operateType,String saleNo="")
        {
            InitializeComponent();
            init();
            dispatchOperate(operateType,saleNo);
        }

        private void init()
        {
            this.toolTip.SetToolTip(this.leftArrow, "销售订单状态前移");
            this.toolTip.SetToolTip(this.rightArrow, "销售订单状态后移");
            this.productList.AutoGenerateColumns = false;
        }

        /*
         * 鼠标悬浮、离开、按下、弹起左向箭头事件函数
         */
        private void leftArrow_MouseHover(object sender, EventArgs e)
        {
            this.leftArrow.BackgroundImage = ERPApplication.Properties.Resources.leftArrow2;
        }
        private void leftArrow_MouseLeave(object sender, EventArgs e)
        {
            this.leftArrow.BackgroundImage = ERPApplication.Properties.Resources.leftArrow;
        }
        private void leftArrow_MouseDown(object sender, MouseEventArgs e)
        {
            this.leftArrow.BackgroundImage = ERPApplication.Properties.Resources.leftArrow;
        }
        private void leftArrow_MouseUp(object sender, MouseEventArgs e)
        {
            this.leftArrow.BackgroundImage = ERPApplication.Properties.Resources.leftArrow2;
        }

        /*
         * 鼠标悬浮、离开、按下、弹起右向箭头事件函数
         */
        private void rightArrow_MouseHover(object sender, EventArgs e)
        {
            this.rightArrow.BackgroundImage = ERPApplication.Properties.Resources.rightArrow2;
        }
        private void rightArrow_MouseLeave(object sender, EventArgs e)
        {
            this.rightArrow.BackgroundImage = ERPApplication.Properties.Resources.rightArrow;
        }
        private void rightArrow_MouseDown(object sender, MouseEventArgs e)
        {
            this.rightArrow.BackgroundImage = ERPApplication.Properties.Resources.rightArrow;
        }
        private void rightArrow_MouseUp(object sender, MouseEventArgs e)
        {
            this.rightArrow.BackgroundImage = ERPApplication.Properties.Resources.rightArrow2;
        }

        /*
         * 根据操作参数的不同，进行不同的界面初始化操作
         */
        private void dispatchOperate(int operateType,String saleNo)
        {
            this.operateType = operateType;

            switch (operateType)
            {
                case 1:
                    newSaleOrderOperate();
                    break;
                case 2:
                    activeSaleOrderOperate();
                    break;
                case 3:
                    removedSaleOrderOperate();
                    break;
            }
        }

        private void newSaleOrderOperate()
        {
            this.orderNo.Text = getSaleOrderNo();       //填充订单编号
            this.orderState.Text = "未提交";            //设置订单状态
            this.unsubmittedState.Image = ERPApplication.Properties.Resources.current;  //设置订单状态对应图片 
            fillClientBox();
            fillTransportModeBox();
            fillTradingCurrencyBox();
        }

        private void activeSaleOrderOperate()
        {
        }

        private void removedSaleOrderOperate()
        {
        }

        /*
         * 填充客户名称
         */
        private void fillClientBox()
        {
            this.clientName.Items.Clear();      //清空客户名称
            NewSaleOrderManager newSaleOrderManager = new NewSaleOrderManager();
            clients = newSaleOrderManager.queryClientInformation();
            foreach (var item in clients)
            {
                this.clientName.Items.Add(item.Key);
            }
        }

        /*
         * 填充运输方式
         */
        private void fillTransportModeBox()
        {
            this.transportType.Items.Clear();       //清空运输方式
            transportModes = new NewSaleOrderManager().queryTransportMode();
            foreach (var item in transportModes)
            {
                this.transportType.Items.Add(item.Key);
            }
        }

        /*
         * 填充交易币种
         */
        private void fillTradingCurrencyBox()
        {
            this.currencyType.Items.Clear();        //清空交易币种名
            tradingCurrencys = new NewSaleOrderManager().queryTradingCurrency();
            foreach (var item in tradingCurrencys)
            {
                this.currencyType.Items.Add(item.Key);
            }
        }

        /*
         * 生成一个新的订单编号
         */
        private String getSaleOrderNo()
        {
            NewSaleOrderManager newSaleOrderManager = new NewSaleOrderManager();
            if (newSaleOrderManager.getSaleOrderNo() == "error")
            {
                MessageBox.Show(this,
                                "订单编号已达到上限，请检查数据库！",
                                "获取销售订单编号警告",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                );
                return "";
            }
            return newSaleOrderManager.getSaleOrderNo();
        }

        /*
         * 保存订单时，检查必要信息是否都填写完毕
         */
        private bool checkInforIntegrity()
        {
            //检查订单号是否生成成功
            if (this.orderNo.Text == "")
            {
                MessageBox.Show(this,"分配订单号失败，无法保存订单信息！","订单信息填写错误",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return false;
            }

            //检查客户信息是否填写
            if (this.clientName.SelectedIndex < 0)
            {
                MessageBox.Show(this, "请选择相应客户！", "订单信息填写错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            //检查运输方式是否填写
            if (this.transportType.SelectedIndex < 0)
            {
                MessageBox.Show(this, "请选择运输方式！", "订单信息填写错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            //检查交易币种信息是否填写
            if (this.currencyType.SelectedIndex < 0)
            {
                MessageBox.Show(this, "请选择交易币种！", "订单信息填写错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            //如果设置了完成时间，则完成时间应大于开始时间
            if (this.endDate.Checked == true && this.endDate.Value <= this.startDate.Value)
            {
                MessageBox.Show(this, "完成日期必须大于开始日期！", "订单信息填写错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        /*
         * 将界面填写信息按数据库表字段顺序组织成一个List
         */
        private List<String> buildInforList()
        {
            List<String> inforCollection = new List<String>();

            inforCollection.Add(this.orderNo.Text); 
            inforCollection.Add(this.orderState.Text);
            inforCollection.Add(this.clients[this.clientName.Text].ToString());
            inforCollection.Add(this.startDate.Value.ToString("yyyy-MM-dd"));
            inforCollection.Add(this.endDate.Checked ? this.endDate.Value.ToString("yyyy-MM-dd") : null);
            inforCollection.Add(this.transportModes[this.transportType.SelectedItem.ToString()].ToString());
            inforCollection.Add(this.tradingCurrencys[this.currencyType.SelectedItem.ToString()].ToString());
            inforCollection.Add(null);        //invoiceId字段暂时设置为null
            inforCollection.Add(this.remarks.Text);

            return inforCollection;
        }

        /*
         * 清除界面上所有信息
         */
        private void clearAllInfor()
        {
            //textBox类
            this.orderNo.Clear();
            this.orderState.Clear();
            this.clientAddress.Clear();
            this.contacts.Clear();
            this.phoneNumber.Clear();
            this.currentRate.Clear();
            this.remarks.Clear();
            
            //DateTimePicker类
            this.startDate.Value = DateTime.Now;
            this.endDate.Value = DateTime.Now;
            this.endDate.Checked = false;

            //ComboBox类
            this.clientName.Items.Clear();
            this.clientName.Items.Add("");
            this.clientName.SelectedIndex = 0;

            this.transportType.Items.Clear();
            this.transportType.Items.Add("");
            this.transportType.SelectedIndex = 0;

            this.currencyType.Items.Clear();
            this.currencyType.Items.Add("");
            this.currencyType.SelectedIndex = 0;

            //DataGridView类
            DataTable tmp = null;
            tmp = (DataTable)this.productList.DataSource;
            if (tmp != null)
            {
                tmp.Rows.Clear();
            }
            this.productList.DataSource = tmp;

            tmp = (DataTable)this.packingTable.DataSource;
            if (tmp != null)
            {
                tmp.Rows.Clear();
            }
            this.packingTable.DataSource = tmp;
        }

        /*
         * 保存信息
         */
        private void saveBtn_Click(object sender, EventArgs e)
        {
            NewSaleOrderManager newSaleOrderManager = new NewSaleOrderManager();

            switch (this.operateType)
            {
                case 1:
                    //检查信息是否填写完整
                    if (checkInforIntegrity() == true)
                    {
                        newSaleOrderManager.addSaleOrder(buildInforList());
                        DialogResult rest = MessageBox.Show(this, 
                                                            "订单保存成功！继续创建订单请选择(是)，退出选择(否)",
                                                            "订单保存提示",
                                                            MessageBoxButtons.YesNo,
                                                            MessageBoxIcon.Information);
                        if (rest == DialogResult.Yes)
                        {
                            //清除当前界面信息
                            clearAllInfor();
                            //重新初始化界面
                            dispatchOperate(1, "");
                        }
                        else
                        {
                            //关闭当前窗口
                            this.Close();
                        }
                    }
                    break;
                case 2:
                    break;
                case 3:
                    break;
                default:
                    break;
            }
        }

        /*
         * 后移订单状态
         */
        private void leftArrow_Click(object sender, EventArgs e)
        {

        }

        /*
         * 前移订单状态
         */
        private void rightArrow_Click(object sender, EventArgs e)
        {

        }

        /*
         * 根据客户名称填充剩余信息
         */
        private void clientName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clients == null || !clients.ContainsKey(this.clientName.SelectedItem.ToString()))
            {
                return;
            }

            int clientId = clients[this.clientName.SelectedItem.ToString()];
            List<String> otherClientInfor = new NewSaleOrderManager().queryClientInformationById(clientId);
            if(otherClientInfor.Count >= 3)
            {
                this.clientAddress.Text = otherClientInfor[0];
                this.contacts.Text = otherClientInfor[1];
                this.phoneNumber.Text = otherClientInfor[2];
            }
        }

        /*
         * 根据交易币种名填充当前汇率
         */
        private void currencyType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tradingCurrencys == null || !tradingCurrencys.ContainsKey(this.currencyType.SelectedItem.ToString()))
            {
                return;
            }

            int currencyId = tradingCurrencys[this.currencyType.SelectedItem.ToString()];
            float currency = new NewSaleOrderManager().queryTradingCurrencyById(currencyId);
            if (currency > 0)
            {
                this.currentRate.Text = currency.ToString();
            }
        }

        /*
         * 订单产品列表右键操作
         */
        private void productList_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (MouseButtons.Right == e.Button)
            {
                if (this.productList.Rows.Count <= 0)
                {
                    this.removeProductItem.Enabled = false;
                }
                else
                {
                    this.removeProductItem.Enabled = true;
                }
                this.productTableRowIndex = e.RowIndex;
                this.orderProductListMenu.Show(MousePosition.X, MousePosition.Y);
            }
        }

        /*
         * 根据由选择的产品项组成的DataTable，填充当前的产品订单列表
         */
        private void fillProductList(List<Object[]> products)
        {
            foreach (var item in products)
            {
                this.productList.Rows.Add();
                DataGridViewRow currentViewRow = this.productList.Rows[this.productList.Rows.Count - 1];

                currentViewRow.Cells[0].Value = item[0];
                currentViewRow.Cells[1].Value = item[1];
                currentViewRow.Cells[2].Value = item[2];
                currentViewRow.Cells[3].Value = item[3];
                currentViewRow.Cells[4].Value = item[4];
                currentViewRow.Cells[6].Value = item[5];
            }
        }

        /*
         * 添加订单产品项
         */
        private void addProductItem_Click(object sender, EventArgs e)
        {
            ProductListForm productListForm = new ProductListForm();
            DialogResult rst = productListForm.ShowDialog(this);
            if (rst == DialogResult.OK)
            {
                fillProductList(productListForm.getProductList());
            }
        }

        /*
         * 删除订单产品项
         */
        private void removeProductItem_Click(object sender, EventArgs e)
        {
            if (this.productTableRowIndex >= 0)
            {
                DialogResult rst = MessageBox.Show(this,
                                                   "确定删除当前行？",
                                                   "删除订单产品项提示",
                                                   MessageBoxButtons.OKCancel,
                                                   MessageBoxIcon.Warning);
                if (rst == DialogResult.OK)
                {
                    this.productList.Rows.RemoveAt(this.productTableRowIndex);
                }
            }
        }

        /*
         * 编辑数量，自动计算金额
         */
        private void productList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                Object productNum = this.productList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (productNum != null)
                {
                    int i_num = 0;
                    if (int.TryParse(productNum.ToString(), out i_num))
                    {
                        Decimal money = i_num * Convert.ToDecimal(this.productList.Rows[e.RowIndex].Cells[6].Value);
                        this.productList.Rows[e.RowIndex].Cells[7].Value = Convert.ToString(money);
                    }
                }
            }
        }

        /*
         * 装箱单列表操作
         */  
        private void packingTable_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (MouseButtons.Right == e.Button)
            {
                //表为空时只允许添加
                if (this.packingTable.Rows.Count <= 0)
                {
                    this.addItem.Enabled = true;
                    this.removeItem.Enabled = false;
                }
                else
                {
                    this.addItem.Enabled = true;
                    this.removeItem.Enabled = true;
                }
                this.packingTableRowIndex = e.RowIndex;
                this.packingListMenu.Show(MousePosition.X, MousePosition.Y);
            }
        }

        /*
         * 点击添加运单
         */
        private void addItem_Click(object sender, EventArgs e)
        {
            this.packingTable.Rows.Add();
        }

        /*
         * 点击删除运单
         */
        private void removeItem_Click(object sender, EventArgs e)
        {
            if (this.packingTableRowIndex >= 0)
            {
                DialogResult rst = MessageBox.Show(this,
                                                   "确定删除当前行？",
                                                   "删除运单提示",
                                                   MessageBoxButtons.OKCancel,
                                                   MessageBoxIcon.Warning);
                if (rst == DialogResult.OK)
                {
                    this.packingTable.Rows.RemoveAt(this.packingTableRowIndex);
                }
            }
        }


        /*
         * 上传客户订单（此方式已废弃）
         */
        private void openFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "表格文件(*.xls;*.xlsx)|*.xls;*.xlsx";
            fileDialog.FilterIndex = 1;
            fileDialog.InitialDirectory = ".";
            fileDialog.RestoreDirectory = true;

            if (fileDialog.ShowDialog(this) == DialogResult.OK)
            {
                String filename = fileDialog.FileName;                         //获取文件名
                DataSet excelDataSet = ExcelOperate.readExcel(filename);       //获取excel内容(色号、数量)
                if (excelDataSet == null)
                {
                    return;
                }
                //注意：excel表格中数据的第一行被作为表头不加载，空行会被自动过滤掉
                DataTable excelDataTable = excelDataSet.Tables[0];
                if (excelDataTable.Columns.Count != 2)
                {
                    MessageBox.Show(this,
                                    "客户订单表格要求为2列（色号、数量）！",
                                    "上传错误",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return;
                }

                NewSaleOrderManager newSaleOrderManager = new NewSaleOrderManager();
                this.productList.DataSource = newSaleOrderManager.getOrderProductListInfor(excelDataTable);
            }
        }

    }
}
