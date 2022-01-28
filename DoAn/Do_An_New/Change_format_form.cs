using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace Do_An_New
{
    public partial class Change_format_form : Form
    {
        public static Change_format_form __instance = new Change_format_form();
        public event EventHandler<string> radioBtnChecked;
        Image format_img;
        public Change_format_form()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (radioBtn_png.Checked == true)
            {
                OnRadioBtnChecked("png");
            }
            else if (radioBtn_jpg.Checked == true)
            {
                OnRadioBtnChecked("jpg");
            }
            else if (radioBtn_bmp.Checked == true)
            {
                OnRadioBtnChecked("bmp");
            }

            this.Close();
        }

        protected void OnRadioBtnChecked(string format)
        {
            if (radioBtnChecked != null)
            {
                radioBtnChecked(this, format);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void enableFormatChoice(string format)
        {
            lbl_format.Text = "From " + format + " to:";

            if (format == "png")
            {
                radioBtn_png.Enabled = false;

                radioBtn_jpg.Checked = true;
                radioBtn_bmp.Checked = false;
            }
            else if (format == "jpeg")
            {
                radioBtn_jpg.Enabled = false;

                radioBtn_png.Checked = true;
                radioBtn_bmp.Checked = false;
            }
            else if (format == "bmp")
            {
                radioBtn_bmp.Enabled = false;

                radioBtn_png.Checked = true;
                radioBtn_jpg.Checked = false;
            }
        }

        private void Change_format_form_Load(object sender, EventArgs e)
        {
            format_img = (Image)Image_form.img_main.Clone();

            if (format_img.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Jpeg))
            {
                //MessageBox.Show("jpeg");
                enableFormatChoice("jpeg");
            }
            else if (format_img.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Bmp))
            {
                //MessageBox.Show("bmp");
                enableFormatChoice("bmp");
            }
            else if (format_img.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Png))
            {
                //MessageBox.Show("png");
                enableFormatChoice("png");
            }

            btn_ok.Focus();
        }
    }
}
