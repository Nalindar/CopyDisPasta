using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyDisPasta
{
    class ButtonSet
    {
        public List<ButtonInfo> Buttons = new List<ButtonInfo>();
        public List<string> TabNames = null;

        public static ButtonSet ReadButtons(StreamReader stream)
        {
            var allTabs = new Dictionary<string, int>();
            var buttonSet = new ButtonSet();
            string line;
            while ((line = stream.ReadLine()) != null)
            {
                var info = ReadButtonLine(line);
                if (info != null)
                {
                    buttonSet.Buttons.Add(info);
                    allTabs[info.TabName] = 1;
                }
            }
            buttonSet.TabNames = allTabs.Keys.ToList();
            return buttonSet;
        }
        public static void WriteButtons(StreamWriter writer, ButtonSet buttonSet)
        {
            foreach (var info in buttonSet.Buttons)
            {
                string line = WriteLine(info);
                writer.WriteLine(line);
            }

        }
        private static ButtonInfo ReadButtonLine(string line)
        {
            var info = new ButtonInfo();
            char[] delimiters = new char[] { '|' };
            string[] fragments = line.Split(delimiters);
            if (fragments.Length < 2) { return null; }
            int i = 0;
            if (fragments.Length < 3)
            {
                info.TabName = "Main";
            }
            else
            {
                info.TabName = fragments[i++];
            }
            info.Title = fragments[i++];
            info.Description = fragments[i++];
            return info;
        }
        public static string WriteLine(ButtonInfo info)
        {
            return string.Format("{0}|{1}|{2}", Encode(info.TabName), Encode(info.Title), Encode(info.Description));
        }
        private static string Encode(string text)
        {
            return text.Replace("|", "").Replace("\n", "");
        }
    }
    class ButtonInfo
    {
        public string Title;
        public string Description;
        public string TabName = "Main";

    }


}
