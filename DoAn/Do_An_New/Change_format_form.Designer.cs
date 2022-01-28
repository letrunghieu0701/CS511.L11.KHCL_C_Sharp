namespace Do_An_New
{
    partial class Change_format_form
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
            this.radioBtn_png = new System.Windows.Forms.RadioButton();
            this.radioBtn_jpg = new System.Windows.Forms.RadioButton();
            this.radioBtn_bmp = new System.Windows.Forms.RadioButton();
            this.lbl_format = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioBtn_png
            // 
            this.radioBtn_png.AutoSize = true;
            this.radioBtn_png.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn_png.Location = new System.Drawing.Point(225, 41);
            this.radioBtn_png.Name = "radioBtn_png";
            this.radioBtn_png.Size = new System.Drawing.Size(86, 32);
            this.radioBtn_png.TabIndex = 0;
            this.radioBtn_png.TabStop = true;
            this.radioBtn_png.Text = "PNG";
            this.radioBtn_png.UseVisualStyleBackColor = true;
            // 
            // radioBtn_jpg
            // 
            this.radioBtn_jpg.AutoSize = true;
            this.radioBtn_jpg.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn_jpg.Location = new System.Drawing.Point(225, 85);
            this.radioBtn_jpg.Name = "radioBtn_jpg";
            this.radioBtn_jpg.Size = new System.Drawing.Size(82, 32);
            this.radioBtn_jpg.TabIndex = 0;
            this.radioBtn_jpg.TabStop = true;
            this.radioBtn_jpg.Text = "JPG";
            this.radioBtn_jpg.UseVisualStyleBackColor = true;
            // 
            // radioBtn_bmp
            // 
            this.radioBtn_bmp.AutoSize = true;
            this.radioBtn_bmp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn_bmp.Location = new System.Drawing.Point(225, 129);
            this.radioBtn_bmp.Name = "radioBtn_bmp";
            this.radioBtn_bmp.Size = new System.Drawing.Size(86, 32);
            this.radioBtn_bmp.TabIndex = 0;
            this.radioBtn_bmp.TabStop = true;
            this.radioBtn_bmp.Text = "BMP";
            this.radioBtn_bmp.UseVisualStyleBackColor = true;
            // 
            // lbl_format
            // 
            this.lbl_format.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_format.Location = new System.Drawing.Point(27, 37);
            this.lbl_format.Name = "lbl_format";
            this.lbl_format.Size = new System.Drawing.Size(166, 41);
            this.lbl_format.TabIndex = 1;
            this.lbl_format.Text = "From png to:";
            this.lbl_format.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_ok
            // 
            this.btn_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok.Location = new System.Drawing.Point(63, 202);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 27);
            this.btn_ok.TabIndex = 2;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(199, 202);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(108, 27);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // Change_format_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 252);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.lbl_format);
            this.Controls.Add(this.radioBtn_bmp);
            this.Controls.Add(this.radioBtn_jpg);
            this.Controls.Add(this.radioBtn_png);
            this.Name = "Change_format_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Format";
            this.Load += new System.EventHandler(this.Change_format_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioBtn_png;
        private System.Windows.Forms.RadioButton radioBtn_jpg;
        private System.Windows.Forms.RadioButton radioBtn_bmp;
        private System.Windows.Forms.Label lbl_format;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
    }
}