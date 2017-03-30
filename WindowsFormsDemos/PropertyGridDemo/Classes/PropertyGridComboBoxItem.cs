using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsDemos.PropertyGridDemo.Classes
{
    class PropertyGridComboBoxItem:ComboBoxItemTypeConvert  
    {
        public override void GetConvertHash()
        {
            _hash.Add(0, "炒肝");

            _hash.Add(1, "豆汁");

            _hash.Add(2, "灌肠");  
        }
    }
}
