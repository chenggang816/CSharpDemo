using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsDemos.DataGridViewDemo;
using WindowsFormsDemos.ImageListDemo;
using WindowsFormsDemos.ListViewDemo;

namespace WindowsFormsDemos
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new WinPropertyGridDemo());
            //Application.Run(new WinDataGridViewDemo());
            //Application.Run(new WinImageListDemo());
            Application.Run(new WinListViewDemo());
        }
    }
}
