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
    public partial class NewProductTypeForm : Form
    {
        public NewProductTypeForm()
        {
            InitializeComponent();
        }

        /*
         * 返回被选中的单选按钮
         */
        public int getProductType()
        {
            bool radio1 = this.cosmeticsRadio.Checked;
            bool radio2 = this.eyebrowsePencilRadio.Checked;
            bool radio3 = this.peripheralRadio.Checked;

            if (radio1 && !radio2 && !radio3)
            {
                return 1;   //彩妆类
            }
            else if(!radio1 && radio2 && !radio3)
            {
                return 2;   //眉笔类
            }
            else if (!radio1 && !radio2 && radio3)
            {
                return 3;   //周边类
            }
            else
            {
                return -1;   //错误
            }
        }
    }
}
