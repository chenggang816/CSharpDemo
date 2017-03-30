using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsDemos.PropertyGridDemo.Classes
{
    class PropertyGridBoolItem:ComboBoxItemTypeConvert
    {
        public override void GetConvertHash()
        {

            _hash.Add(0, "是");

            _hash.Add(1, "否");

        }  
    }
}
