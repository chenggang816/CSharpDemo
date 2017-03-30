using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsDemos.DataGridViewDemo
{
    public partial class WinDataGridViewDemo : Form
    {
        public WinDataGridViewDemo()
        {
            InitializeComponent();
        }

        private void buttonAddRow_Click(object sender, EventArgs e)
        {
            int index = this.dataGridView1.Rows.Add();
            this.dataGridView1.Rows[index].Cells[0].Value = true;
            this.dataGridView1.Rows[index].Cells[1].Value = index;
            this.dataGridView1.Rows[index].Cells[2].Value = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            DataGridViewCheckBoxCell checkboxcell = new DataGridViewCheckBoxCell();
            row.Cells.Add(checkboxcell);

            DataGridViewTextBoxCell textboxcell = new DataGridViewTextBoxCell();
            textboxcell.Value = "1";
            row.Cells.Add(textboxcell);

            DataGridViewTextBoxCell textboxcellname = new DataGridViewTextBoxCell();
            textboxcell.Value = "";
            row.Cells.Add(textboxcellname);

            DataGridViewComboBoxCell comboxcell = new DataGridViewComboBoxCell();
            comboxcell.Items.Add("男");
            comboxcell.Items.Add("女");
            comboxcell.Items.Add("不详");
            row.Cells.Insert(3,comboxcell);

            DataGridViewLinkCell linkcell = new DataGridViewLinkCell();
            linkcell.Value = "个人网站";
            row.Cells.Insert(4,linkcell);

            dataGridView1.Rows.Add(row);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewCell cell = dataGridView1.CurrentCell;
            if (cell == null)
                return;
            label1.Text = @"行：" + cell.RowIndex 
                + "\t列：" + cell.ColumnIndex 
                + "\t值:" + cell.Value ;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell = dataGridView1[1,0];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = !dataGridView1.AllowUserToAddRows;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            DataGridViewCell cell = dataGridView1[e.ColumnIndex, e.RowIndex];
            cell.ToolTipText = e.ColumnIndex.ToString() + ", " + e.RowIndex.ToString() + " :" + cell.Value;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //单元格的上边和左边线设为二重线
            // 单元格的下边和右边线设为单重线
            //dataGridView1.AdvancedCellBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.InsetDouble;
            //dataGridView1.AdvancedCellBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.Inset;
            //dataGridView1.AdvancedCellBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.Inset;
            //dataGridView1.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.InsetDouble;

            //无边框
            //dataGridView1.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
            //dataGridView1.AdvancedCellBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
            dataGridView1.AdvancedCellBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
            dataGridView1.AdvancedCellBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None; 


            dataGridView1.AdvancedColumnHeadersBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.OutsetDouble;

            dataGridView1.AdvancedRowHeadersBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.InsetDouble;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.dataGridView1.GridColor = Color.BlueViolet; 
            this.dataGridView1.BorderStyle = BorderStyle.Fixed3D; 
            this.dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Raised; 
            this.dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single; 
            this.dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
        }

        private void dataGridView1_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["ID"].Value = 1;
            e.Row.Cells["UserName"].Value = "New User";
        }

    }
}
