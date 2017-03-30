using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace WindowsFormsDemos.PropertyGridDemo.Classes
{
    [DescriptionAttribute("展开以查看应用程序的拼写选项。")]
    public class SpellingOptions
    {
        private bool spellCheckWhileTyping = true;
        private bool spellCheckCAPS = false;
        private bool suggestCorrections = true;
        [DefaultValueAttribute(true)]
        public bool SpellCheckWhileTyping
        {
            get { return spellCheckWhileTyping; }
            set { spellCheckWhileTyping = value; }
        }
        [DefaultValueAttribute(false)]
        public bool SpellCheckCAPS
        {
            get { return spellCheckCAPS; }
            set { spellCheckCAPS = value; }
        }
        [DefaultValueAttribute(true)]
        public bool SuggestCorrections
        {
            get { return suggestCorrections; }
            set { suggestCorrections = value; }
        }
    }  
}
