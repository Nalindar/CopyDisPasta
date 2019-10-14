using CopyDisPasta.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopyDisPasta
{
    public partial class Main : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        private ButtonSet _AllButtons;
        private bool _ignoreMove;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Main()
        {
            InitializeComponent();
            this.cboLocation.Items.Add("Right");
            this.cboLocation.Items.Add("Bottom");
            this.cboLocation.Items.Add("Left");
            this.cboLocation.Items.Add("Top");
            this.cboLocation.Items.Add("User Defined");
        }

        private void LoadWindowPosition()
        {
            WindowRect.RECT myRect;
            var targetWindow = CopyPasta.GetTargetWindow();
            if(targetWindow != null)
            {
                WindowRect.GetWindowRect(new HandleRef(this, targetWindow), out myRect);
                AlignMainWindow(myRect);
            }
            if(Settings.Default.MainWindowSize.Height != 0 && Settings.Default.MainWindowSize.Width != 0)
            {
                this.Size = Settings.Default.MainWindowSize;
            }
        }
        private void AlignMainWindow(WindowRect.RECT targetRect)
        {
            Point newPoint = new Point();
            switch (Properties.Settings.Default.MainWindowDockLocation)
            {
                case 0:
                    newPoint = new Point(targetRect.Right, targetRect.Top);
                    break;
                case 1:
                    newPoint = new Point(targetRect.Left, targetRect.Bottom);
                    break;
                case 2:
                    newPoint = new Point(targetRect.Left - this.Width, targetRect.Top);
                    break;
                case 3:
                    newPoint = new Point(targetRect.Left, targetRect.Top - this.Height);
                    break;
                case 4:
                    newPoint = Settings.Default.MainWindowLocation;
                    break;


            }
            if (!IsOnScreen(newPoint) && !IsOnScreen(new Point(newPoint.X+14, newPoint.Y))) { return; }
//            if (newPoint.Y < 0) { newPoint.Y = 0; }


            //            if (newPoint.X < Screen.PrimaryScreen.WorkingArea.X) { newPoint.X = Screen.PrimaryScreen.WorkingArea.X; }
            this.Location = newPoint;
        }
        private static bool IsOnScreen(Point pt)
        {
            //TODO: Real onscreen check
            //return true;

            foreach (var screen in Screen.AllScreens)
            {
                if (screen.WorkingArea.Contains(pt)) { return true; }
            }
            return false;
        }

        private void SaveWindowPosition()
        {
            Settings.Default.MainWindowDockLocation = this.cboLocation.SelectedIndex;
            Settings.Default.MainWindowLocation = this.Location;
            Settings.Default.MainWindowSize = this.Size;
            Settings.Default.Save();
        }

        private void LoadButtons(string bunkArg)
        {
            if(this.InvokeRequired)
            {
                Action<string> delegateAction = LoadButtons;
                Invoke(delegateAction, "MODIFY BY THREAD");
                return;
            }
            tcButtonHousing.TabPages.Clear();
            using (StreamReader reader = File.OpenText("DynamicButtons.txt"))
            {
                _AllButtons = ButtonSet.ReadButtons(reader);
            }
            foreach (string tabName in _AllButtons.TabNames)
            {
                var tabPage = new TabPage(tabName) { Name = tabName };
                tabPage.Size = new System.Drawing.Size(493, 145);
                //AnchorStretch(tabPage);
                var panel = new FlowLayoutPanel();


                AnchorStretch(panel);
                panel.AutoScroll = true;
                panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
                panel.Location = new System.Drawing.Point(0, 6);
                panel.Name = "flpButtons";
                panel.Size = new System.Drawing.Size(493, 145);
                panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));

                panel.TabIndex = 0;


                tabPage.Controls.Add(panel);
                this.tcButtonHousing.TabPages.Add(tabPage);
            }

            int index = 0;
            foreach (var info in _AllButtons.Buttons)
            {
                Button newButton = new Button();
                newButton.Click += NewButton_Click;
                newButton.Text = info.Title;
                newButton.Tag = info.Description;
                newButton.Height = 50;
                newButton.Width = 150;
                newButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
                newButton.FlatAppearance.BorderSize = 0;
                newButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                newButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
                newButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                var tabPage = this.tcButtonHousing.TabPages[info.TabName];
                FlowLayoutPanel panel = tabPage.Controls[0] as FlowLayoutPanel;
                panel.Controls.Add(newButton);
                //this.flpButtons.Controls.Add(newButton);
                ++index;
            }
        }
        private static void AnchorStretch(Control ctl)
        {
            ctl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            var button = (sender as Button);
            string text = button.Tag.ToString().Replace("\\n", Environment.NewLine);
            CopyPasta.PasteToTarget(text);
        }
        

        private void Main_Load(object sender, EventArgs e)
        {
            _ignoreMove = true;
            this.cboLocation.SelectedIndex = Properties.Settings.Default.MainWindowDockLocation;
            LoadWindowPosition();
            LoadButtons("");
            _ignoreMove = false;
        }

        private void btnAddButton_Click(object sender, EventArgs e)
        {

            var editor = new ButtonEditor();
            editor.TabName = tcButtonHousing.SelectedTab.Name;
            if (editor.ShowDialog() != DialogResult.OK) { return; }
            var info = new ButtonInfo()
            {
                TabName = editor.TabName,
                Title = editor.ButtonTitle,
                Description = editor.ButtonDescription
            };
            _AllButtons.Buttons.Add(info);
            using (StreamWriter writer = new StreamWriter("DynamicButtons.txt"))
            {
                ButtonSet.WriteButtons(writer, _AllButtons);
            }
            this.LoadButtons("");
            return;
            var process = Process.Start("notepad.exe", "DynamicButtons.txt");
            process.EnableRaisingEvents = true;
            process.Exited += Process_Exited;
        }
        private void ClearButtons(string bunkArgs)
        {
            if (this.InvokeRequired)
            {
                Action<string> delegateAction = ClearButtons;
                Invoke(delegateAction, "MODIFY BY THREAD");
                return;
            }
            //flpButtons.Controls.Clear();
        }

        private void Process_Exited(object sender, EventArgs e)
        {
            ClearButtons("");
            LoadButtons("");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.MainWindowDockLocation = this.cboLocation.SelectedIndex;
            SaveWindowPosition();
        }

        private void btnAddTab_Click(object sender, EventArgs e)
        {
            this.tcButtonHousing.TabPages.Add(Guid.NewGuid().ToString().Substring(1, 6));
        }

        private void cboLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!_ignoreMove)
            {
                SaveWindowPosition();
                LoadWindowPosition();
            }
        }

        private void chkbxAutoEnter_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.AutoSendMessage = chkbxAutoEnter.Checked;
        }
    }
}
