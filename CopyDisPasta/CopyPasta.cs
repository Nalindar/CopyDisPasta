using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace CopyDisPasta
{
    class CopyPasta
    {

        public static void PasteToTarget(string str)
        {
            Clipboard.SetText(str);
            FocusTargetWindow();
            //SendKeys.Send("{TAB}");
            SendKeys.Send("^V");
            if(Properties.Settings.Default.AutoSendMessage) { SendKeys.Send("{ENTER}"); }
        }
        
        // hardcode chrome for now because : lazy
        // TODO: allow user to select process
        public static void FocusTargetWindow()
        {
            Process[] targetProcs = Process.GetProcessesByName("chrome");
            if (targetProcs.Length > 0)
            {
                for (int i = 0; i < targetProcs.Length; i++)
                {
                    if (targetProcs[i].MainWindowHandle.ToInt32() > 0)
                    {
                        Thread.Sleep(100);
                        SetForegroundWindow(targetProcs[i].MainWindowHandle);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please open chrome.", "Chrome was not identified as open.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public static IntPtr GetTargetWindow()
        {
            Process[] targetProcs = Process.GetProcessesByName("chrome");

            var nullPtr = new IntPtr();
            if (targetProcs.Length == 0) { return nullPtr; }
            foreach(var proc in targetProcs)
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

