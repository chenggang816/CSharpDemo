using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace WindowsFormsDemos.PropertyGridDemo.Classes
{
    public class SpellingOptionConverter:ExpandableObjectConverter
    {
        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            if (destinationType == typeof(SpellingOptions))
                return true; 
            return base.CanConvertTo(context, destinationType);
        }
        public override object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destinationType)
        {
            if (destinationType == typeof(System.String) &&
            value is SpellingOptions)
            {
                SpellingOptions so = (SpellingOptions)value;
                return "在键入时检查:" + so.SpellCheckWhileTyping +
                       "，检查大小写: " + so.SpellCheckCAPS +
                       "，建议更正: " + so.SuggestCorrections;
            }  
            return base.ConvertTo(context, culture, value, destinationType);
        }
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            if (sourceType == typeof(string))
                return true;  
            return base.CanConvertFrom(context, sourceType);
        }
        public override object ConvertFrom(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value)
        {
            if (value is string)
            {
                try
                {
                    string s = (string)value;
                    int colon = s.IndexOf(':');
                    int comma = s.IndexOf(',');
                    if (colon != -1 && comma != -1)
                    {
                        string checkWhileTyping = s.Substring(colon + 1, (comma - colon - 1));
                        colon = s.IndexOf(':', comma + 1);
                        comma = s.IndexOf(',', comma + 1);
                        string checkCaps = s.Substring(colon + 1, (comma - colon - 1));
                        colon = s.IndexOf(':', comma + 1);
                        string suggCorr = s.Substring(colon + 1);
                        SpellingOptions so = new SpellingOptions();
                        so.SpellCheckWhileTyping = Boolean.Parse(checkWhileTyping);
                        so.SpellCheckCAPS = Boolean.Parse(checkCaps);
                        so.SuggestCorrections = Boolean.Parse(suggCorr);
                        return so;
                    }
                }
                catch
                {
                    throw new ArgumentException(
                        "无法将“" + (string)value + "”转换为 SpellingOptions 类型");
                }
            }     
            return base.ConvertFrom(context, culture, value);
        }
    }
}
