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
    public partial class EndProductPODetailForm : Form
    {
        public EndProductPODetailForm()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            this.toolTip.SetToolTip(this.leftArrow,"成品PO状态前移");
            this.toolTip.SetToolTip(this.rightArrow, "成品PO状态后移");
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
    }
}
