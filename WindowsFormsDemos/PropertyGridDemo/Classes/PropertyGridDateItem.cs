using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Design;
using System.Windows.Forms.Design;

namespace WindowsFormsDemos.PropertyGridDemo.Classes
{
    /// <summary>
    /// 在PropertyGrid 上显示日期控件   
    /// </summary>
    class PropertyGridDateItem:UITypeEditor
    {
        MonthCalendar dateControl = new MonthCalendar();

        public PropertyGridDateItem()
        {

            dateControl.MaxSelectionCount = 1;

        }

        public override UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context)
        {

            return UITypeEditorEditStyle.DropDown;

        }

        public override object EditValue(System.ComponentModel.ITypeDescriptorContext context,

System.IServiceProvider provider, object value)
        {

            try
            {

                IWindowsFormsEditorService edSvc =

(IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));

                if (edSvc != null)
                {

                    if (value is string)
                    {

                        dateControl.SelectionStart = DateTime.Parse(value as String);

                        edSvc.DropDownControl(dateControl);

                        return dateControl.SelectionStart.ToShortDateString();

                    }

                    else if (value is DateTime)
                    {

                        dateControl.SelectionStart = (DateTime)value;

                        edSvc.DropDownControl(dateControl);

                        return dateControl.SelectionStart;

                    }

                }

            }

            catch (Exception ex)
            {

                System.Console.WriteLine("PropertyGridDateItem Error : " + ex.Message);

                return value;

            }

            return value;

        }  
    }
}
