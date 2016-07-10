using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace ERPApplication
{
    public partial class HomeForm : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        /*
         * 对用户名的读写属性
         */
        public String Username
        {
            get
            {
                return this.username.Text;
            }
            set
            {
                this.username.Text = value;
            }
        }

        public HomeForm()
        {
            InitializeComponent();
            init();
        }

        /*
        * 1.设置窗口关闭实际为隐藏，对象没有被释放
        * 2.禁止关闭窗口
        */
        private void init()
        {
            this.HideOnClose = true;
            this.CloseButton = false;
        }
    }
}
