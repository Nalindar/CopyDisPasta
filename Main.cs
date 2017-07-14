using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopyDisPasta
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }


        private void LoadButtons(string bunkArg)
        {
            if(this.InvokeRequired)
            {
                Action<string> delegateAction = LoadButtons;
                Invoke(delegateAction, "MODIFY BY THREAD");
                return;
            }
            using (StreamReader reader = File.OpenText("DynamicButtons.txt"))
            {
                string line;
                int index = 0;
                while ((line = reader.ReadLine()) != null)
                {
                    int offset = line.IndexOf("|");
                    string title = line.Substring(0, offset - 1).Trim();
                    string description = line.Substring(offset + 1).Trim();
                    Button newButton = new Button();
                    newButton.Click += NewButton_Click;
                    newButton.Text = title;
                    newButton.Tag = description;
                    newButton.Height = 50;
                    newButton.Width = 150;
                    newButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
                    newButton.FlatAppearance.BorderSize = 0;
                    newButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    newButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
                    newButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                    this.flowLayoutPanel1.Controls.Add(newButton);
                    ++index;
                }
            }
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            var button = (sender as Button);
            string text = button.Tag.ToString();
            CopyPasta.PasteToDiscord(text);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            LoadButtons("");
        }

        private void btnAddButton_Click(object sender, EventArgs e)
        {
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
            flowLayoutPanel1.Controls.Clear();
        }

        private void Process_Exited(object sender, EventArgs e)
        {
            ClearButtons("");
            LoadButtons("");
        }
    }
}
