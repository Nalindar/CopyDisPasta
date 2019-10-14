using CopyDisPasta.Properties;
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
    public partial class ButtonEditor : Form
    {
        public string TabName { get { return this.txtTabName.Text; } set { this.txtTabName.Text = value; } }
        public string ButtonTitle { get { return this.txtTitle.Text; } }
        public string ButtonDescription { get { return this.txtDescription.Text; } }
        public ButtonEditor()
        {
            InitializeComponent();
        }

        private void LoadWindowPosition()
        {
            if (Settings.Default.ButtonEditorLocation != null && Settings.Default.ButtonEditorSize.Height != 0 && Settings.Default.ButtonEditorSize.Width != 0)
            {
                this.Location = Settings.Default.ButtonEditorLocation;
                this.Size = Settings.Default.ButtonEditorSize;
            }
        }

        private void SaveWindowPosition()
        {
            Settings.Default.ButtonEditorLocation = this.Location;
            Settings.Default.ButtonEditorSize = this.Size;
            Settings.Default.Save();
        }

        private void ButtonEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveWindowPosition();
        }

        private void ButtonEditor_Load(object sender, EventArgs e)
        {
            LoadWindowPosition();
        }
    }
}
