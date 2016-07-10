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
    public partial class NewMaterialTypeForm : Form
    {
        public NewMaterialTypeForm()
        {
            InitializeComponent();
        }

        /*
         * 获取选中的物料类别
         */
        public int getMaterialType()
        {
            bool radio1 = this.packingMaterialRadio.Checked;
            bool radio2 = this.cartonRadio.Checked;

            if (radio1 && !radio2)
            {
                return 1;      //包材
            }
            else if (!radio1 && radio2)
            {
                return 2;      //彩盒
            }
            else
            {
                return -1;     //错误
            }
        }
    }
}
