namespace CrossFire_windowsForm
{
    partial class ucItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pic_Item = new System.Windows.Forms.PictureBox();
            this.btn_Buy = new System.Windows.Forms.Button();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Price = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Item)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_Item
            // 
            this.pic_Item.Dock = System.Windows.Forms.DockStyle.Left;
            this.pic_Item.Location = new System.Drawing.Point(0, 0);
            this.pic_Item.Margin = new System.Windows.Forms.Padding(2);
            this.pic_Item.Name = "pic_Item";
            this.pic_Item.Size = new System.Drawing.Size(156, 72);
            this.pic_Item.TabIndex = 0;
            this.pic_Item.TabStop = false;
            // 
            // btn_Buy
            // 
            this.btn_Buy.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Buy.Location = new System.Drawing.Point(156, 39);
            this.btn_Buy.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Buy.Name = "btn_Buy";
            this.btn_Buy.Size = new System.Drawing.Size(86, 33);
            this.btn_Buy.TabIndex = 1;
            this.btn_Buy.Text = "BUY";
            this.btn_Buy.UseVisualStyleBackColor = true;
            this.btn_Buy.Click += new System.EventHandler(this.btn_Buy_Click);
            // 
            // txt_Name
            // 
            this.txt_Name.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_Name.Location = new System.Drawing.Point(156, 0);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(86, 20);
            this.txt_Name.TabIndex = 2;
            // 
            // txt_Price
            // 
            this.txt_Price.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Price.Location = new System.Drawing.Point(156, 20);
            this.txt_Price.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(86, 20);
            this.txt_Price.TabIndex = 3;
            // 
            // ucItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.txt_Price);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.btn_Buy);
            this.Controls.Add(this.pic_Item);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ucItem";
            this.Size = new System.Drawing.Size(242, 72);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Item)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_Item;
        private System.Windows.Forms.Button btn_Buy;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Price;
    }
}
