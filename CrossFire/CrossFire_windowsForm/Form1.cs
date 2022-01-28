using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrossFire_windowsForm
{
    public partial class Form1 : Form
    {
        List<Panel> listPanel = new List<Panel>();
        int index = 0;
        bool moveRight = false;

        DataTable dt = new DataTable();
        double tienHang = 0;
        int giamGia = 0;
        double tongCong = 0;

        public Form1()
        {
            InitializeComponent();

            listPanel.Add(panel_Melee);     // 0
            listPanel.Add(panel_MG);        // 1
            listPanel.Add(panel_Pistol);    // 2
            listPanel.Add(panel_Rifle);     // 3
            listPanel.Add(panel_Sniper);    // 4

            dgv.Columns.Clear();
            dt.Columns.Add("Tên", typeof(string));
            dt.Columns.Add("Số lượng", typeof(int));
            dt.Columns.Add("Giá", typeof(double));
            dt.Columns.Add("Thành tiền", typeof(double));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            char[] spearator = { '-' };
            Point nextLocation = new Point(10, 15);
            string[] dirPath_Guns = Directory.GetDirectories(@"CF_Gun");        
            //MessageBox.Show(filePath_Guns.Length.ToString());
            //for (int i = 0; i < filePath_Guns.Length; i++)
            //    MessageBox.Show(filePath_Guns[i]);
            for (int i = 0; i < dirPath_Guns.Length; i++)
            {
                string[] filePath = Directory.GetFiles(dirPath_Guns[i]);
                for (int j = 0; j < filePath.Length; j++)
                {
                    string fileName = Path.GetFileNameWithoutExtension(filePath[j]);
                    string[] itemInfo = fileName.Split(spearator, StringSplitOptions.RemoveEmptyEntries);
                    string itemName = itemInfo[0];
                    string itemPrice = itemInfo[1];

                    ucItem item = new ucItem();
                    item.pictureBox_Item.BackgroundImage = Image.FromFile(filePath[j]);
                    item.pictureBox_Item.BackgroundImageLayout = ImageLayout.Stretch;
                    item.textBox_Name.Text = itemName;
                    item.textBox_Price.Text = itemPrice;
                    item.Location = nextLocation;

                    if (moveRight == false)
                    {
                        moveRight = true;
                        nextLocation.X = 10 + item.Size.Width + 20;
                    }
                    else if (moveRight == true)
                    {
                        moveRight = false;
                        nextLocation.X = 10;
                        nextLocation.Y += item.Height + 20;
                    }
                    //SetLocation(item.Location);
                    listPanel[index].Controls.Add(item);
                }
                index++;
                nextLocation = new Point(10, 15);
                moveRight = false;
            }

            foreach (ucItem i in listPanel[3].Controls)
            {
                i.ButttonClicked += new EventHandler<OrderEventArgs>(child_DataAvailable);
            }
        }

        private void ThemVaoTienHangVaTongCong(double donGia)
        {
            try
            {
                if (txt_giamGia.Text != string.Empty)
                {
                    giamGia = int.Parse(txt_giamGia.Text);
                    if (giamGia < 0 || giamGia > 100)
                    {
                        giamGia = 0;
                        MessageBox.Show("0 <= Giảm giá <= 100 !!!" + "\n" + "Mời nhập lại.");
                    }
                }
                tienHang += donGia;
                tongCong = tienHang - (tienHang * giamGia / 100);
                txt_tienHang.Text = tienHang.ToString();
                txt_tongCong.Text = tongCong.ToString();
            }
            catch
            {
                MessageBox.Show("Đã có lỗi xảy ra khi thêm tiền, không thể thêm tiền được !!!");
            }
        }

        private void themVaoHoaDon(string tenMonThemVao, double donGia)
        {
            try
            {
                DataRow rw = dt.AsEnumerable().FirstOrDefault(tt => tt.Field<string>("Tên") == tenMonThemVao);
                if (rw != null)
                {
                    // row exists
                    int soLuongMoi = int.Parse(rw[1].ToString()) + 1;
                    rw[1] = soLuongMoi;

                    double thanhTien = soLuongMoi * donGia;
                    rw[3] = thanhTien;

                    ThemVaoTienHangVaTongCong(donGia);

                    return;
                }

                dt.Rows.Add(tenMonThemVao, 1, donGia, donGia);
                dgv.DataSource = dt;

                ThemVaoTienHangVaTongCong(donGia);

                return;
            }
            catch
            {
                MessageBox.Show("Đã có lỗi xảy ra khi thêm item, không thể thêm item được !!!");
            }
        }

        private void child_DataAvailable(object sender, OrderEventArgs e)
        {
            themVaoHoaDon(e.TenMon, e.Gia);
        }

        private void menu_Rifle_Click(object sender, EventArgs e)
        {
            listPanel[0].Visible = false;
            listPanel[1].Visible = false;
            listPanel[2].Visible = false;
            listPanel[3].Visible = true;    // true
            listPanel[4].Visible = false;
            foreach (ucItem i in listPanel[3].Controls)
            {
                i.ButttonClicked += new EventHandler<OrderEventArgs>(child_DataAvailable);
            }
        }

        private void menu_MG_Click(object sender, EventArgs e)
        {
            listPanel[0].Visible = false;
            listPanel[1].Visible = true;    // true
            listPanel[2].Visible = false;
            listPanel[3].Visible = false;
            listPanel[4].Visible = false;

            foreach (ucItem i in listPanel[1].Controls)
            {
                i.ButttonClicked += new EventHandler<OrderEventArgs>(child_DataAvailable);
            }
        }

        private void menu_Sniper_Click(object sender, EventArgs e)
        {
            listPanel[0].Visible = false;
            listPanel[1].Visible = false;
            listPanel[2].Visible = false;
            listPanel[3].Visible = false;
            listPanel[4].Visible = true;    // true

            foreach (ucItem i in listPanel[4].Controls)
            {
                i.ButttonClicked += new EventHandler<OrderEventArgs>(child_DataAvailable);
            }
        }

        private void menu_Pistol_Click(object sender, EventArgs e)
        {
            listPanel[0].Visible = false;
            listPanel[1].Visible = false;
            listPanel[2].Visible = true;    // true
            listPanel[3].Visible = false;
            listPanel[4].Visible = false;

            foreach (ucItem i in listPanel[2].Controls)
            {
                i.ButttonClicked += new EventHandler<OrderEventArgs>(child_DataAvailable);
            }
        }

        private void menu_Melee_Click(object sender, EventArgs e)
        {
            listPanel[0].Visible = true;    //true
            listPanel[1].Visible = false;
            listPanel[2].Visible = false;
            listPanel[3].Visible = false;
            listPanel[4].Visible = false;

            foreach (ucItem i in listPanel[0].Controls)
            {
                i.ButttonClicked += new EventHandler<OrderEventArgs>(child_DataAvailable);
            }
        }

        private int indexRowDangClickTrongDGV = -1;

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    indexRowDangClickTrongDGV = e.RowIndex;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message + " - " + ex.Source);
            }
        }

        private void btn_del_item_Click(object sender, EventArgs e)
        {
            if (indexRowDangClickTrongDGV != -1)
            {
                int temp = int.Parse(dgv.Rows[indexRowDangClickTrongDGV].Cells[1].Value.ToString());
                
                if (temp > 1)
                {
                    dgv.Rows[indexRowDangClickTrongDGV].Cells[1].Value = temp - 1;
                    dgv.Rows[indexRowDangClickTrongDGV].Cells[3].Value = (temp - 1) * int.Parse(dgv.Rows[indexRowDangClickTrongDGV].Cells[2].Value.ToString());
                } 
                else dgv.Rows.Remove(dgv.Rows[indexRowDangClickTrongDGV]);
            }
        }


    }
}
