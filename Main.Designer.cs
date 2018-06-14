namespace CopyDisPasta
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnAddButton = new System.Windows.Forms.Button();
            this.tcButtonHousing = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnClose = new System.Windows.Forms.Button();
            this.cboLocation = new System.Windows.Forms.ComboBox();
            this.lblDockLocation = new System.Windows.Forms.Label();
            this.chkbxAutoEnter = new System.Windows.Forms.CheckBox();
            this.tcButtonHousing.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddButton
            // 
            this.btnAddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
            this.btnAddButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
            this.btnAddButton.FlatAppearance.BorderSize = 0;
            this.btnAddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
            this.btnAddButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
            this.btnAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.btnAddButton.Location = new System.Drawing.Point(16, 12);
            this.btnAddButton.Name = "btnAddButton";
            this.btnAddButton.Size = new System.Drawing.Size(96, 29);
            this.btnAddButton.TabIndex = 1;
            this.btnAddButton.Text = "Add";
            this.btnAddButton.UseVisualStyleBackColor = false;
            this.btnAddButton.Click += new System.EventHandler(this.btnAddButton_Click);
            // 
            // tcButtonHousing
            // 
            this.tcButtonHousing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcButtonHousing.Controls.Add(this.tabPage1);
            this.tcButtonHousing.Controls.Add(this.tabPage2);
            this.tcButtonHousing.Location = new System.Drawing.Point(12, 49);
            this.tcButtonHousing.Name = "tcButtonHousing";
            this.tcButtonHousing.SelectedIndex = 0;
            this.tcButtonHousing.Size = new System.Drawing.Size(560, 282);
            this.tcButtonHousing.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(552, 256);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(552, 256);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
            this.btnClose.BackgroundImage = global::CopyDisPasta.Properties.Resources.spaghettidiscord;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.btnClose.Location = new System.Drawing.Point(486, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 29);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cboLocation
            // 
            this.cboLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboLocation.FormattingEnabled = true;
            this.cboLocation.Location = new System.Drawing.Point(12, 373);
            this.cboLocation.Name = "cboLocation";
            this.cboLocation.Size = new System.Drawing.Size(121, 21);
            this.cboLocation.TabIndex = 4;
            this.cboLocation.SelectedIndexChanged += new System.EventHandler(this.cboLocation_SelectedIndexChanged);
            // 
            // lblDockLocation
            // 
            this.lblDockLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDockLocation.AutoSize = true;
            this.lblDockLocation.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDockLocation.Location = new System.Drawing.Point(13, 357);
            this.lblDockLocation.Name = "lblDockLocation";
            this.lblDockLocation.Size = new System.Drawing.Size(116, 13);
            this.lblDockLocation.TabIndex = 5;
            this.lblDockLocation.Text = "Discord Dock Location";
            // 
            // chkbxAutoEnter
            // 
            this.chkbxAutoEnter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkbxAutoEnter.AutoSize = true;
            this.chkbxAutoEnter.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chkbxAutoEnter.Location = new System.Drawing.Point(16, 337);
            this.chkbxAutoEnter.Name = "chkbxAutoEnter";
            this.chkbxAutoEnter.Size = new System.Drawing.Size(127, 17);
            this.chkbxAutoEnter.TabIndex = 6;
            this.chkbxAutoEnter.Text = "Auto Send Messages";
            this.chkbxAutoEnter.UseVisualStyleBackColor = true;
            this.chkbxAutoEnter.CheckedChanged += new System.EventHandler(this.chkbxAutoEnter_CheckedChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(584, 406);
            this.ControlBox = false;
            this.Controls.Add(this.chkbxAutoEnter);
            this.Controls.Add(this.lblDockLocation);
            this.Controls.Add(this.cboLocation);
            this.Controls.Add(this.tcButtonHousing);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(200, 200);
            this.Name = "Main";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.tcButtonHousing.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddButton;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TabControl tcButtonHousing;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cboLocation;
        private System.Windows.Forms.Label lblDockLocation;
        private System.Windows.Forms.CheckBox chkbxAutoEnter;
    }
}

