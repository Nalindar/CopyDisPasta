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
        }
        
        public static void SetFocusToDiscord()
        {
            Process discordPID = Process.GetProcessById(5948);

            IntPtr discordhandler = discordPID.MainWindowHandle;
            Thread.Sleep(100);
            SetForegroundWindow(discordhandler);    
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetForegroundWindow(IntPtr hWnd);
    
    }
}

