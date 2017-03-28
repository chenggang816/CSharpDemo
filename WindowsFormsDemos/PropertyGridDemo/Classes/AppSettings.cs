using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Drawing;

namespace WindowsFormsDemos.Classes
{
    [DefaultPropertyAttribute("SaveOnClose")]
    public class AppSettings
    {
        private bool saveOnClose;
        private string greetingText = "欢迎使用应用程序！";
        private int itemsInMRU = 4;
        private int maxRepeatRate = 10;
        private bool settingsChanged = false;
        private string appVersion = "1.0";

        private Size windowSize = new Size(100, 100);
        private Font windowFont = new Font("宋体", 9, FontStyle.Regular);
        private Color toolbarColor = SystemColors.Control;

        [Category("文档设置"),
        DefaultValue(true)] //当属性不是default value 属性时，以粗体显示
        public bool SaveOnClose
        {
            get { return saveOnClose; }
            set { saveOnClose = value; }
        }

        [CategoryAttribute("文档设置")]
        public Size WindowSize
        {
            get { return windowSize; }
            set { windowSize = value; }
        }

        [CategoryAttribute("文档设置")]
        public Font WindowFont
        {
            get { return windowFont; }
            set { windowFont = value; }
        }


        [CategoryAttribute("全局设置")]
        public Color ToolbarColor
        {
            get { return toolbarColor; }
            set { toolbarColor = value; }
        } 

        [Category("全局设置"),
         ReadOnly(true),
         DefaultValue("欢迎使用应用程序！")] 
        public string GreetingText
        {
            get { return greetingText; }
            set { greetingText = value; }
        }



        [CategoryAttribute("全局设置"),
        DefaultValueAttribute(4)]
        public int ItemsInMRUList
        {
            get { return itemsInMRU; }
            set { itemsInMRU = value; }
        }

        
       
        [Description("以毫秒表示的文本重复率。"),
         Category("全局设置"),
         DefaultValue(10)]
        public int MaxRepeatRate
        {
            get { return maxRepeatRate; }
            set { maxRepeatRate = value; }
        }


        [Browsable(false)]
        public bool SettingsChanged
        {
            get { return settingsChanged; }
            set { settingsChanged = value; }
        }

        [CategoryAttribute("版本"),
         DefaultValueAttribute("1.0"),
         ReadOnlyAttribute(true)]
        public string AppVersion
        {
            get { return appVersion; }
            set { appVersion = value; }
        }

        private SpellingOptions spellCheckOption = new SpellingOptions();
        [Category("拼写检查选项"),
        TypeConverter(typeof(SpellingOptionConverter))]
        public SpellingOptions SpellCheckOption
        {
            get { return spellCheckOption; }
            set { spellCheckOption = value; }
        }

    } 
}
