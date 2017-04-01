using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsDemos.ListViewDemo
{
    public partial class WinListViewDemo : Form
    {
        public WinListViewDemo()
        {
            InitializeComponent();
            InitData();
        }

        private void InitData()
        {
            this.listViewEx1.Items[0].SubItems.Add("数据预处理");

            ProgressBar pro = new ProgressBar();
            pro.Value = 30;
            this.listViewEx1.AddEmbeddedControl(pro, 2, 0);
        }
    }
}
