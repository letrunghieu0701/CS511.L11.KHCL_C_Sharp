namespace Do_An_New
{
    partial class Edit_form
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
            this.btn_back = new System.Windows.Forms.Button();
            this.panelNavigate = new System.Windows.Forms.Panel();
            this.btn_reset = new System.Windows.Forms.Button();
            this.picBox_adjustment = new System.Windows.Forms.PictureBox();
            this.picBox_rotate = new System.Windows.Forms.PictureBox();
            this.picBox_filter = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelFunctions = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save_a_copy = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.picBox_edit = new System.Windows.Forms.PictureBox();
            this.panelNavigate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_adjustment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_rotate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_filter)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_edit)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.AutoSize = true;
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(9, 17);
            this.btn_back.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(86, 36);
            this.btn_back.TabIndex = 1;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // panelNavigate
            // 
            this.panelNavigate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panelNavigate.Controls.Add(this.btn_reset);
            this.panelNavigate.Controls.Add(this.picBox_adjustment);
            this.panelNavigate.Controls.Add(this.picBox_rotate);
            this.panelNavigate.Controls.Add(this.picBox_filter);
            this.panelNavigate.Controls.Add(this.btn_back);
            this.panelNavigate.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNavigate.Location = new System.Drawing.Point(0, 0);
            this.panelNavigate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelNavigate.Name = "panelNavigate";
            this.panelNavigate.Size = new System.Drawing.Size(672, 72);
            this.panelNavigate.TabIndex = 3;
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btn_reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.ForeColor = System.Drawing.Color.White;
            this.btn_reset.Location = new System.Drawing.Point(574, 17);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(86, 35);
            this.btn_reset.TabIndex = 11;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // picBox_adjustment
            // 
            this.picBox_adjustment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.picBox_adjustment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picBox_adjustment.Image = global::Do_An_New.Properties.Resources.icons8_sun_52;
            this.picBox_adjustment.Location = new System.Drawing.Point(398, 17);
            this.picBox_adjustment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picBox_adjustment.Name = "picBox_adjustment";
            this.picBox_adjustment.Size = new System.Drawing.Size(86, 35);
            this.picBox_adjustment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_adjustment.TabIndex = 3;
            this.picBox_adjustment.TabStop = false;
            this.picBox_adjustment.Click += new System.EventHandler(this.picBox_adjustment_Click);
            // 
            // picBox_rotate
            // 
            this.picBox_rotate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.picBox_rotate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picBox_rotate.Cursor = System.Windows.Forms.Cursors.Default;
            this.picBox_rotate.Image = global::Do_An_New.Properties.Resources.icons8_crop_52_white_;
            this.picBox_rotate.Location = new System.Drawing.Point(190, 17);
            this.picBox_rotate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picBox_rotate.Name = "picBox_rotate";
            this.picBox_rotate.Size = new System.Drawing.Size(86, 35);
            this.picBox_rotate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_rotate.TabIndex = 4;
            this.picBox_rotate.TabStop = false;
            this.picBox_rotate.Click += new System.EventHandler(this.picBox_crop_edit_Click);
            // 
            // picBox_filter
            // 
            this.picBox_filter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.picBox_filter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picBox_filter.Image = global::Do_An_New.Properties.Resources.icons8_paint_brush_52_white_;
            this.picBox_filter.Location = new System.Drawing.Point(294, 17);
            this.picBox_filter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picBox_filter.Name = "picBox_filter";
            this.picBox_filter.Size = new System.Drawing.Size(86, 35);
            this.picBox_filter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_filter.TabIndex = 5;
            this.picBox_filter.TabStop = false;
            this.picBox_filter.Click += new System.EventHandler(this.picBox_filter_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.panel1.Controls.Add(this.panelFunctions);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(672, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 524);
            this.panel1.TabIndex = 6;
            // 
            // panelFunctions
            // 
            this.panelFunctions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFunctions.Location = new System.Drawing.Point(0, 0);
            this.panelFunctions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelFunctions.Name = "panelFunctions";
            this.panelFunctions.Size = new System.Drawing.Size(214, 494);
            this.panelFunctions.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_save);
            this.panel2.Controls.Add(this.btn_cancel);
            this.panel2.Controls.Add(this.btn_save_a_copy);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 494);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(214, 30);
            this.panel2.TabIndex = 0;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_save.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(94, 0);
            this.btn_save.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(50, 30);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btn_cancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(144, 0);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(70, 30);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            // 
            // btn_save_a_copy
            // 
            this.btn_save_a_copy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btn_save_a_copy.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_save_a_copy.FlatAppearance.BorderSize = 0;
            this.btn_save_a_copy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save_a_copy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_a_copy.ForeColor = System.Drawing.Color.White;
            this.btn_save_a_copy.Location = new System.Drawing.Point(0, 0);
            this.btn_save_a_copy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_save_a_copy.Name = "btn_save_a_copy";
            this.btn_save_a_copy.Size = new System.Drawing.Size(94, 30);
            this.btn_save_a_copy.TabIndex = 1;
            this.btn_save_a_copy.Text = "Save a copy";
            this.btn_save_a_copy.UseVisualStyleBackColor = false;
            this.btn_save_a_copy.Click += new System.EventHandler(this.btn_save_a_copy_Click);
            // 
            // picBox_edit
            // 
            this.picBox_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.picBox_edit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBox_edit.Image = global::Do_An_New.Properties.Resources.default_image;
            this.picBox_edit.InitialImage = global::Do_An_New.Properties.Resources.default_image;
            this.picBox_edit.Location = new System.Drawing.Point(0, 72);
            this.picBox_edit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picBox_edit.Name = "picBox_edit";
            this.picBox_edit.Size = new System.Drawing.Size(672, 452);
            this.picBox_edit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_edit.TabIndex = 5;
            this.picBox_edit.TabStop = false;
            // 
            // Edit_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 524);
            this.Controls.Add(this.picBox_edit);
            this.Controls.Add(this.panelNavigate);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Edit_form";
            this.Text = "Edit_form";
            this.Load += new System.EventHandler(this.Edit_form_Load);
            this.panelNavigate.ResumeLayout(false);
            this.panelNavigate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_adjustment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_rotate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_filter)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_edit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Panel panelNavigate;
        private System.Windows.Forms.PictureBox picBox_adjustment;
        private System.Windows.Forms.PictureBox picBox_rotate;
        private System.Windows.Forms.PictureBox picBox_filter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save_a_copy;
        private System.Windows.Forms.Panel panelFunctions;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button btn_reset;
        public System.Windows.Forms.PictureBox picBox_edit;
    }
}