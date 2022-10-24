namespace P5_2_1214073
{
    partial class ParrentForm
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
            this.MdiMenu = new System.Windows.Forms.MenuStrip();
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowcascadeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowtitleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MdiMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MdiMenu
            // 
            this.MdiMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem,
            this.windowMenuItem});
            this.MdiMenu.Location = new System.Drawing.Point(0, 0);
            this.MdiMenu.Name = "MdiMenu";
            this.MdiMenu.Size = new System.Drawing.Size(800, 24);
            this.MdiMenu.TabIndex = 1;
            this.MdiMenu.Text = "menuStrip1";
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMenuItem,
            this.exitMenuItem});
            this.FileMenuItem.Name = "FileMenuItem";
            this.FileMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileMenuItem.Text = "&File";
            // 
            // newMenuItem
            // 
            this.newMenuItem.Name = "newMenuItem";
            this.newMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newMenuItem.Text = "&New";
            this.newMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitMenuItem.Text = "&Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // windowMenuItem
            // 
            this.windowMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WindowcascadeMenuItem,
            this.WindowtitleMenuItem});
            this.windowMenuItem.Name = "windowMenuItem";
            this.windowMenuItem.Size = new System.Drawing.Size(63, 20);
            this.windowMenuItem.Text = "&Window";
            // 
            // WindowcascadeMenuItem
            // 
            this.WindowcascadeMenuItem.Name = "WindowcascadeMenuItem";
            this.WindowcascadeMenuItem.Size = new System.Drawing.Size(180, 22);
            this.WindowcascadeMenuItem.Text = "&Cascade";
            this.WindowcascadeMenuItem.Click += new System.EventHandler(this.WindowcascadeMenuItem_Click);
            // 
            // WindowtitleMenuItem
            // 
            this.WindowtitleMenuItem.Name = "WindowtitleMenuItem";
            this.WindowtitleMenuItem.Size = new System.Drawing.Size(180, 22);
            this.WindowtitleMenuItem.Text = "&Title";
            this.WindowtitleMenuItem.Click += new System.EventHandler(this.WindowtitleMenuItem_Click);
            // 
            // ParrentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MdiMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MdiMenu;
            this.Name = "ParrentForm";
            this.Text = "Parrent Form";
            this.MdiMenu.ResumeLayout(false);
            this.MdiMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MdiMenu;
        private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WindowcascadeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WindowtitleMenuItem;
    }
}

