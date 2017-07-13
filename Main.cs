using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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


        private void LoadButtons()
        {
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
                    this.flowLayoutPanel1.Controls.Add(newButton);
                    ++index;
                }
            }
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            var button = (sender as Button);
            string text = button.Tag.ToString();
            MessageBox.Show("alt tab this: " + text);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            LoadButtons();
        }
    }
}
