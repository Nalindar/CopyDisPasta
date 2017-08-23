namespace CopyDisPasta
{
    partial class ButtonEditor
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
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblButtonTitle = new System.Windows.Forms.Label();
            this.lblButtonText = new System.Windows.Forms.Label();
            this.lblTabName = new System.Windows.Forms.Label();
            this.txtTabName = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(80, 46);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(192, 20);
            this.txtTitle.TabIndex = 0;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(10, 91);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(262, 130);
            this.txtDescription.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(197, 227);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lblButtonTitle
            // 
            this.lblButtonTitle.AutoSize = true;
            this.lblButtonTitle.Location = new System.Drawing.Point(7, 49);
            this.lblButtonTitle.Name = "lblButtonTitle";
            this.lblButtonTitle.Size = new System.Drawing.Size(30, 13);
            this.lblButtonTitle.TabIndex = 3;
            this.lblButtonTitle.Text = "Title:";
            // 
            // lblButtonText
            // 
            this.lblButtonText.AutoSize = true;
            this.lblButtonText.Location = new System.Drawing.Point(7, 75);
            this.lblButtonText.Name = "lblButtonText";
            this.lblButtonText.Size = new System.Drawing.Size(65, 13);
            this.lblButtonText.TabIndex = 4;
            this.lblButtonText.Text = "Button Text:";
            // 
            // lblTabName
            // 
            this.lblTabName.AutoSize = true;
            this.lblTabName.Location = new System.Drawing.Point(7, 19);
            this.lblTabName.Name = "lblTabName";
            this.lblTabName.Size = new System.Drawing.Size(57, 13);
            this.lblTabName.TabIndex = 5;
            this.lblTabName.Text = "Tab Name";
            // 
            // txtTabName
            // 
            this.txtTabName.Location = new System.Drawing.Point(80, 16);
            this.txtTabName.Name = "txtTabName";
            this.txtTabName.Size = new System.Drawing.Size(192, 20);
            this.txtTabName.TabIndex = 6;
            // 
            // ButtonEditor
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtTabName);
            this.Controls.Add(this.lblTabName);
            this.Controls.Add(this.lblButtonText);
            this.Controls.Add(this.lblButtonTitle);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtTitle);
            this.Name = "ButtonEditor";
            this.Text = "ButtonEditor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ButtonEditor_FormClosing);
            this.Load += new System.EventHandler(this.ButtonEditor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblButtonTitle;
        private System.Windows.Forms.Label lblButtonText;
        private System.Windows.Forms.Label lblTabName;
        private System.Windows.Forms.TextBox txtTabName;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}