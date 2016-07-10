using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace ERPApplication
{
    /// <summary>   
    /// 解决系统TabControl多余边距问题   
    /// </summary> 
    class FullTabControl : TabControl
    {
        public override Rectangle DisplayRectangle
        {
            get
            {
                Rectangle rect = base.DisplayRectangle;
                return new Rectangle(rect.Left - 2, rect.Top + 0, rect.Width + 2, rect.Height + 1);
            }
        }  
    }
}

/*
 *  调用方法：
    比如在Form1页面里，打开Form1.Designer.cs
    找到
    this.tabControl1 = new System.Windows.Forms.TabControl();
    改为
    this.tabControl1 = new FullTabControl();
 */
