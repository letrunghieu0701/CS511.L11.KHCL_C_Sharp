namespace Do_An_New
{
    partial class Rotate_form
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
            this.lbl_rotate = new System.Windows.Forms.Label();
            this.panelFilters = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_flip = new System.Windows.Forms.Button();
            this.btn_rotate = new System.Windows.Forms.Button();
            this.panelFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_rotate
            // 
            this.lbl_rotate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lbl_rotate.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_rotate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rotate.ForeColor = System.Drawing.Color.White;
            this.lbl_rotate.Location = new System.Drawing.Point(0, 0);
            this.lbl_rotate.Name = "lbl_rotate";
            this.lbl_rotate.Size = new System.Drawing.Size(285, 44);
            this.lbl_rotate.TabIndex = 1;
            this.lbl_rotate.Text = "Rotate";
            this.lbl_rotate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelFilters
            // 
            this.panelFilters.AutoScroll = true;
            this.panelFilters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.panelFilters.Controls.Add(this.pictureBox2);
            this.panelFilters.Controls.Add(this.pictureBox1);
            this.panelFilters.Controls.Add(this.btn_flip);
            this.panelFilters.Controls.Add(this.btn_rotate);
            this.panelFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFilters.Location = new System.Drawing.Point(0, 44);
            this.panelFilters.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelFilters.Name = "panelFilters";
            this.panelFilters.Size = new System.Drawing.Size(285, 564);
            this.panelFilters.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Do_An_New.Properties.Resources.icons8_flip_vertical_52;
            this.pictureBox2.Location = new System.Drawing.Point(101, 311);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(66, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Do_An_New.Properties.Resources.icons8_rotate_52_flip;
            this.pictureBox1.Location = new System.Drawing.Point(101, 69);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btn_flip
            // 
            this.btn_flip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btn_flip.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_flip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_flip.ForeColor = System.Drawing.Color.White;
            this.btn_flip.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_flip.Location = new System.Drawing.Point(81, 402);
            this.btn_flip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_flip.Name = "btn_flip";
            this.btn_flip.Size = new System.Drawing.Size(107, 43);
            this.btn_flip.TabIndex = 8;
            this.btn_flip.Text = "Flip";
            this.btn_flip.UseVisualStyleBackColor = false;
            this.btn_flip.Click += new System.EventHandler(this.btn_flip_Click);
            // 
            // btn_rotate
            // 
            this.btn_rotate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btn_rotate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_rotate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rotate.ForeColor = System.Drawing.Color.White;
            this.btn_rotate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_rotate.Location = new System.Drawing.Point(81, 160);
            this.btn_rotate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_rotate.Name = "btn_rotate";
            this.btn_rotate.Size = new System.Drawing.Size(107, 43);
            this.btn_rotate.TabIndex = 9;
            this.btn_rotate.Text = "Rotate";
            this.btn_rotate.UseVisualStyleBackColor = false;
            this.btn_rotate.Click += new System.EventHandler(this.btn_rotate_Click);
            // 
            // Rotate_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(285, 608);
            this.Controls.Add(this.panelFilters);
            this.Controls.Add(this.lbl_rotate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Rotate_form";
            this.Text = "Crop_Rotate_form";
            this.panelFilters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_rotate;
        private System.Windows.Forms.Panel panelFilters;
        private System.Windows.Forms.Button btn_flip;
        private System.Windows.Forms.Button btn_rotate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}