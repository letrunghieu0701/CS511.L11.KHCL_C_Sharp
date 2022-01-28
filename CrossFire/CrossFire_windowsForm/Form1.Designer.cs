namespace CrossFire_windowsForm
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_Rifle = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_MG = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Sniper = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Pistol = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Melee = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_dgv = new System.Windows.Forms.Panel();
            this.btn_checkout = new System.Windows.Forms.Button();
            this.btn_del_item = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_tongCong = new System.Windows.Forms.TextBox();
            this.txt_giamGia = new System.Windows.Forms.TextBox();
            this.txt_tienHang = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.panel_Rifle = new System.Windows.Forms.Panel();
            this.panel_MG = new System.Windows.Forms.Panel();
            this.panel_Melee = new System.Windows.Forms.Panel();
            this.panel_Pistol = new System.Windows.Forms.Panel();
            this.panel_Sniper = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel_dgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_Rifle,
            this.menu_MG,
            this.menu_Sniper,
            this.menu_Pistol,
            this.menu_Melee});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(878, 31);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu_Rifle
            // 
            this.menu_Rifle.Name = "menu_Rifle";
            this.menu_Rifle.Size = new System.Drawing.Size(53, 25);
            this.menu_Rifle.Text = "Rifle";
            this.menu_Rifle.Click += new System.EventHandler(this.menu_Rifle_Click);
            // 
            // menu_MG
            // 
            this.menu_MG.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_MG.Name = "menu_MG";
            this.menu_MG.Size = new System.Drawing.Size(47, 25);
            this.menu_MG.Text = "MG";
            this.menu_MG.Click += new System.EventHandler(this.menu_MG_Click);
            // 
            // menu_Sniper
            // 
            this.menu_Sniper.Name = "menu_Sniper";
            this.menu_Sniper.Size = new System.Drawing.Size(67, 25);
            this.menu_Sniper.Text = "Sniper";
            this.menu_Sniper.Click += new System.EventHandler(this.menu_Sniper_Click);
            // 
            // menu_Pistol
            // 
            this.menu_Pistol.Name = "menu_Pistol";
            this.menu_Pistol.Size = new System.Drawing.Size(60, 25);
            this.menu_Pistol.Text = "Pistol";
            this.menu_Pistol.Click += new System.EventHandler(this.menu_Pistol_Click);
            // 
            // menu_Melee
            // 
            this.menu_Melee.Name = "menu_Melee";
            this.menu_Melee.Size = new System.Drawing.Size(64, 25);
            this.menu_Melee.Text = "Melee";
            this.menu_Melee.Click += new System.EventHandler(this.menu_Melee_Click);
            // 
            // panel_dgv
            // 
            this.panel_dgv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_dgv.Controls.Add(this.btn_checkout);
            this.panel_dgv.Controls.Add(this.btn_del_item);
            this.panel_dgv.Controls.Add(this.label1);
            this.panel_dgv.Controls.Add(this.label3);
            this.panel_dgv.Controls.Add(this.label5);
            this.panel_dgv.Controls.Add(this.label6);
            this.panel_dgv.Controls.Add(this.txt_tongCong);
            this.panel_dgv.Controls.Add(this.txt_giamGia);
            this.panel_dgv.Controls.Add(this.txt_tienHang);
            this.panel_dgv.Controls.Add(this.label7);
            this.panel_dgv.Controls.Add(this.label8);
            this.panel_dgv.Controls.Add(this.label9);
            this.panel_dgv.Controls.Add(this.dgv);
            this.panel_dgv.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_dgv.Location = new System.Drawing.Point(0, 31);
            this.panel_dgv.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel_dgv.Name = "panel_dgv";
            this.panel_dgv.Size = new System.Drawing.Size(311, 544);
            this.panel_dgv.TabIndex = 2;
            // 
            // btn_checkout
            // 
            this.btn_checkout.Location = new System.Drawing.Point(173, 479);
            this.btn_checkout.Name = "btn_checkout";
            this.btn_checkout.Size = new System.Drawing.Size(117, 52);
            this.btn_checkout.TabIndex = 27;
            this.btn_checkout.Text = "Thanh Toán";
            this.btn_checkout.UseVisualStyleBackColor = true;
            // 
            // btn_del_item
            // 
            this.btn_del_item.Location = new System.Drawing.Point(11, 479);
            this.btn_del_item.Name = "btn_del_item";
            this.btn_del_item.Size = new System.Drawing.Size(117, 52);
            this.btn_del_item.TabIndex = 25;
            this.btn_del_item.Text = "Xóa vật phẩm";
            this.btn_del_item.UseVisualStyleBackColor = true;
            this.btn_del_item.Click += new System.EventHandler(this.btn_del_item_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 401);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(268, 433);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Vcoin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 401);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 14);
            this.label5.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(265, 369);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Vcoin";
            // 
            // txt_tongCong
            // 
            this.txt_tongCong.Location = new System.Drawing.Point(82, 430);
            this.txt_tongCong.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_tongCong.Name = "txt_tongCong";
            this.txt_tongCong.ReadOnly = true;
            this.txt_tongCong.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_tongCong.Size = new System.Drawing.Size(180, 20);
            this.txt_tongCong.TabIndex = 18;
            // 
            // txt_giamGia
            // 
            this.txt_giamGia.Location = new System.Drawing.Point(82, 398);
            this.txt_giamGia.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_giamGia.Name = "txt_giamGia";
            this.txt_giamGia.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_giamGia.Size = new System.Drawing.Size(74, 20);
            this.txt_giamGia.TabIndex = 19;
            // 
            // txt_tienHang
            // 
            this.txt_tienHang.Location = new System.Drawing.Point(82, 366);
            this.txt_tienHang.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_tienHang.Name = "txt_tienHang";
            this.txt_tienHang.ReadOnly = true;
            this.txt_tienHang.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_tienHang.Size = new System.Drawing.Size(180, 20);
            this.txt_tienHang.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 433);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Tổng cộng:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(2, 401);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Giảm giá: %";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(2, 369);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Tiền hàng:";
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(309, 360);
            this.dgv.TabIndex = 0;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // panel_Rifle
            // 
            this.panel_Rifle.AutoScroll = true;
            this.panel_Rifle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Rifle.Location = new System.Drawing.Point(326, 32);
            this.panel_Rifle.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel_Rifle.Name = "panel_Rifle";
            this.panel_Rifle.Size = new System.Drawing.Size(544, 544);
            this.panel_Rifle.TabIndex = 3;
            // 
            // panel_MG
            // 
            this.panel_MG.AutoScroll = true;
            this.panel_MG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_MG.Location = new System.Drawing.Point(326, 32);
            this.panel_MG.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel_MG.Name = "panel_MG";
            this.panel_MG.Size = new System.Drawing.Size(544, 544);
            this.panel_MG.TabIndex = 0;
            this.panel_MG.Visible = false;
            // 
            // panel_Melee
            // 
            this.panel_Melee.AutoScroll = true;
            this.panel_Melee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Melee.Location = new System.Drawing.Point(326, 32);
            this.panel_Melee.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel_Melee.Name = "panel_Melee";
            this.panel_Melee.Size = new System.Drawing.Size(544, 544);
            this.panel_Melee.TabIndex = 0;
            this.panel_Melee.Visible = false;
            // 
            // panel_Pistol
            // 
            this.panel_Pistol.AutoScroll = true;
            this.panel_Pistol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Pistol.Location = new System.Drawing.Point(326, 32);
            this.panel_Pistol.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel_Pistol.Name = "panel_Pistol";
            this.panel_Pistol.Size = new System.Drawing.Size(528, 544);
            this.panel_Pistol.TabIndex = 0;
            this.panel_Pistol.Visible = false;
            // 
            // panel_Sniper
            // 
            this.panel_Sniper.AutoScroll = true;
            this.panel_Sniper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Sniper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Sniper.Location = new System.Drawing.Point(311, 31);
            this.panel_Sniper.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel_Sniper.Name = "panel_Sniper";
            this.panel_Sniper.Size = new System.Drawing.Size(567, 544);
            this.panel_Sniper.TabIndex = 0;
            this.panel_Sniper.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 575);
            this.Controls.Add(this.panel_Sniper);
            this.Controls.Add(this.panel_Pistol);
            this.Controls.Add(this.panel_Melee);
            this.Controls.Add(this.panel_MG);
            this.Controls.Add(this.panel_Rifle);
            this.Controls.Add(this.panel_dgv);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cross Fire Store";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_dgv.ResumeLayout(false);
            this.panel_dgv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_MG;
        private System.Windows.Forms.ToolStripMenuItem menu_Rifle;
        private System.Windows.Forms.ToolStripMenuItem menu_Pistol;
        private System.Windows.Forms.ToolStripMenuItem menu_Melee;
        private System.Windows.Forms.ToolStripMenuItem menu_Sniper;
        private System.Windows.Forms.Panel panel_dgv;
        private System.Windows.Forms.Panel panel_Rifle;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Panel panel_MG;
        private System.Windows.Forms.Panel panel_Melee;
        private System.Windows.Forms.Panel panel_Pistol;
        private System.Windows.Forms.Panel panel_Sniper;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_tongCong;
        private System.Windows.Forms.TextBox txt_giamGia;
        private System.Windows.Forms.TextBox txt_tienHang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_del_item;
        private System.Windows.Forms.Button btn_checkout;
    }
}

