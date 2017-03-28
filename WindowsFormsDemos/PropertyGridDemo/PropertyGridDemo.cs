using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsDemos.Classes;

namespace WindowsFormsDemos
{
    public partial class PropertyGridDemo : Form
    {
        public PropertyGridDemo()
        {
            InitializeComponent();
            AppSettings appset = new AppSettings();
            this.propertyGrid1.SelectedObject = appset;
        }
    }
}
