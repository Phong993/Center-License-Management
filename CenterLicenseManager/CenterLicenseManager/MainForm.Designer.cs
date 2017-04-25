namespace CenterLicenseManager
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terminateLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filesToolStripMenuItem,
            this.createLicenseToolStripMenuItem,
            this.transferLicenseToolStripMenuItem,
            this.terminateLicenseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(367, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filesToolStripMenuItem
            // 
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            this.filesToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.filesToolStripMenuItem.Text = "Files";
            // 
            // createLicenseToolStripMenuItem
            // 
            this.createLicenseToolStripMenuItem.Enabled = false;
            this.createLicenseToolStripMenuItem.Name = "createLicenseToolStripMenuItem";
            this.createLicenseToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.createLicenseToolStripMenuItem.Text = "Create License";
            // 
            // transferLicenseToolStripMenuItem
            // 
            this.transferLicenseToolStripMenuItem.Enabled = false;
            this.transferLicenseToolStripMenuItem.Name = "transferLicenseToolStripMenuItem";
            this.transferLicenseToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.transferLicenseToolStripMenuItem.Text = "Transfer License";
            // 
            // terminateLicenseToolStripMenuItem
            // 
            this.terminateLicenseToolStripMenuItem.Enabled = false;
            this.terminateLicenseToolStripMenuItem.Name = "terminateLicenseToolStripMenuItem";
            this.terminateLicenseToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.terminateLicenseToolStripMenuItem.Text = "Terminate License";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transferLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terminateLicenseToolStripMenuItem;
    }
}

