using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsDemos.ImageListDemo
{
    public partial class WinImageListDemo : Form
    {
        public WinImageListDemo()
        {
            InitializeComponent();

            foreach (var key in this.imageList1.Images.Keys)
            {
                this.comboBox1.Items.Add(key);
            }
            this.comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.pictureBox1.Image = this.imageList1.Images[this.comboBox1.SelectedItem.ToString()];
        }
    }
}
