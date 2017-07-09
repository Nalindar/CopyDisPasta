using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void button1_Click(object sender, EventArgs e)
        {
            CopyPasta.PasteToDiscord("http://aka-steve.com/downloads -- follow the steps, get thwarglauncher, type in a name/pw combo (no spaces or special characters) -- account is created on first login");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CopyPasta.PasteToDiscord("go to decal agent -- export -- check the 'locations' box -- copy to clipboard -- http://pastebin.com/ -- paste it in the blank space - scroll down and click 'create new paste' -- give link");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CopyPasta.PasteToDiscord("go to your AC folder (default C:\\Turbine\\Asheron's Call) and right click acclient.exe - properties - details tab -- what version is it?");
        }
    }
}
