using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace CopyDisPasta
{
    class CopyPasta
    {

        public static void PasteToDiscord(string str)
        {
            Clipboard.SetText(str);
            SetFocusToDiscord();
            SendKeys.Send("{TAB}");
            SendKeys.Send("^V");
            if(Properties.Settings.Default.AutoSendMessage) { SendKeys.Send("{ENTER}"); }
        }
        
        public static void SetFocusToDiscord()
        {
            Process[] discordProcs = Process.GetProcessesByName("discord");
            if (discordProcs.Length > 0)
            {
                for (int i = 0; i < discordProcs.Length; i++)
                {
                    if (discordProcs[i].MainWindowHandle.ToInt32() > 0)
                    {
                        Thread.Sleep(100);
                        SetForegroundWindow(discordProcs[i].MainWindowHandle);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please open discord.", "Discord was not identified as open.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public static IntPtr GetDiscordWindow()
        {
            Process[] discordProcs = Process.GetProcessesByName("discord");

            var nullPtr = new IntPtr();
            if (discordProcs.Length == 0) { return nullPtr; }
            foreach(var proc in discordProcs)
            {
                if(proc.MainWindowHandle != nullPtr)
                { return proc.MainWindowHandle; }
            }
            return nullPtr;

        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetForegroundWindow(IntPtr hWnd);
    
    }
}

