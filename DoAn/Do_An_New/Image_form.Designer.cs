namespace Do_An_New
{
    partial class Image_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Image_form));
            this.menu_main = new System.Windows.Forms.MenuStrip();
            this.browseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelToSwitch = new System.Windows.Forms.Panel();
            this.panelDefault = new System.Windows.Forms.Panel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.picBox_main = new System.Windows.Forms.PictureBox();
            this.menu_main.SuspendLayout();
            this.panelToSwitch.SuspendLayout();
            this.panelDefault.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_main)).BeginInit();
            this.SuspendLayout();
            // 
            // menu_main
            // 
            this.menu_main.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.browseToolStripMenuItem,
            this.editToolStripMenuItem,
            this.formatToolStripMenuItem});
            this.menu_main.Location = new System.Drawing.Point(0, 0);
            this.menu_main.Name = "menu_main";
            this.menu_main.Size = new System.Drawing.Size(1182, 30);
            this.menu_main.TabIndex = 4;
            this.menu_main.Text = "menuStrip1";
            // 
            // browseToolStripMenuItem
            // 
            this.browseToolStripMenuItem.Name = "browseToolStripMenuItem";
            this.browseToolStripMenuItem.Size = new System.Drawing.Size(71, 26);
            this.browseToolStripMenuItem.Text = "Browse";
            this.browseToolStripMenuItem.Click += new System.EventHandler(this.browseToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.editToolStripMenuItem.Enabled = false;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 26);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.Enabled = false;
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.formatToolStripMenuItem.Text = "Change format";
            this.formatToolStripMenuItem.Click += new System.EventHandler(this.formatToolStripMenuItem_Click);
            // 
            // panelToSwitch
            // 
            this.panelToSwitch.Controls.Add(this.panelDefault);
            this.panelToSwitch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelToSwitch.Location = new System.Drawing.Point(0, 30);
            this.panelToSwitch.Name = "panelToSwitch";
            this.panelToSwitch.Size = new System.Drawing.Size(1182, 643);
            this.panelToSwitch.TabIndex = 6;
            // 
            // panelDefault
            // 
            this.panelDefault.Controls.Add(this.picBox_main);
            this.panelDefault.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDefault.Location = new System.Drawing.Point(0, 0);
            this.panelDefault.Name = "panelDefault";
            this.panelDefault.Size = new System.Drawing.Size(1182, 643);
            this.panelDefault.TabIndex = 6;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // picBox_main
            // 
            this.picBox_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBox_main.Image = global::Do_An_New.Properties.Resources.default_image;
            this.picBox_main.InitialImage = global::Do_An_New.Properties.Resources.default_image;
            this.picBox_main.Location = new System.Drawing.Point(0, 0);
            this.picBox_main.Name = "picBox_main";
            this.picBox_main.Size = new System.Drawing.Size(1182, 643);
            this.picBox_main.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_main.TabIndex = 5;
            this.picBox_main.TabStop = false;
            // 
            // Image_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 673);
            this.Controls.Add(this.panelToSwitch);
            this.Controls.Add(this.menu_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Image_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image";
            this.Load += new System.EventHandler(this.Image_form_Load);
            this.menu_main.ResumeLayout(false);
            this.menu_main.PerformLayout();
            this.panelToSwitch.ResumeLayout(false);
            this.panelDefault.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_main)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu_main;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.Panel panelToSwitch;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Panel panelDefault;
        private System.Windows.Forms.PictureBox picBox_main;
        private System.Windows.Forms.ToolStripMenuItem browseToolStripMenuItem;
    }
}

