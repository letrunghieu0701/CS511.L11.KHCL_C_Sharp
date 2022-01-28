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
using System.Drawing.Imaging;
using RasterEdge.XImage.Raster;
using RasterEdge.Imaging.Basic;

namespace Do_An_New
{
    public partial class Edit_form : Form
    {
        public static Edit_form __instance = new Edit_form();
        public event EventHandler BackBtnClicked;

        Image edit_img = null;

        public Edit_form()
        {
            InitializeComponent();
            openChildFormInPanel(Rotate_form.__instance);
            Rotate_form.__instance.BtnRotateClicked += new EventHandler(OnBtnRotateClicked);
            Rotate_form.__instance.BtnFlipClicked += new EventHandler(OnBtnFlipClicked);

            Adjustments_form.__instance.LightChanged += new EventHandler<int>(OnLightChanged);
            Adjustments_form.__instance.ColorChanged += new EventHandler<int>(OnColorChanged);
            Adjustments_form.__instance.BtnGrayClicked += new EventHandler(OnBtnGrayClicked);
            Adjustments_form.__instance.BtnNegativeClicked += new EventHandler(OnBtnNegativeClicked);

            Filter_form.__instance.ChangedToPosterize += new EventHandler(OnChangedToPosterize);
            Filter_form.__instance.ChangedToOilPaint += new EventHandler(OnChangedToOilPaint);
            Filter_form.__instance.ChangedToCharcoalSkectch += new EventHandler(OnChangedToCharcoalSkectch);
        }

        private void Edit_form_Load(object sender, EventArgs e)
        {
            edit_img = (Image)Image_form.img_main.Clone();
            picBox_edit.Image = (Image)Image_form.img_main.Clone();
        }

        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Visible = false;
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelFunctions.Controls.Add(childForm);
            panelFunctions.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void picBox_crop_edit_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(Rotate_form.__instance);
        }

        private void picBox_filter_Click(object sender, EventArgs e)
        {
            edit_img = (Image)picBox_edit.Image.Clone();
            
            Filter_form.__instance.picBox_posterize.Image = Posterize(7);
            Filter_form.__instance.picBox_charcoalSkectch.Image = CharcoalSkectch();
            Filter_form.__instance.picBox_oilPaint.Image = OilPaint();

            openChildFormInPanel(Filter_form.__instance);
        }

        private void picBox_adjustment_Click(object sender, EventArgs e)
        {
            edit_img = (Image)picBox_edit.Image.Clone();

            openChildFormInPanel(Adjustments_form.__instance);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            OnBackBtnClicked();
        }

        protected void OnBackBtnClicked()
        {
            if (BackBtnClicked != null)
            {
                BackBtnClicked(this, EventArgs.Empty);
            }
        }

        private void btn_save_a_copy_Click(object sender, EventArgs e)
        {
            string img_path = Image_form.img_full_file_path;
            string path_to_file = Path.GetDirectoryName(img_path);
            string file_name = Path.GetFileNameWithoutExtension(img_path);
            string extension_of_file = Path.GetExtension(img_path);
            int index_of_copy_file = 0;

            string full_copy_file_name = path_to_file + "\\(copy)" + file_name + extension_of_file;
            while (File.Exists(full_copy_file_name) == true)
            {
                index_of_copy_file += 1;
                full_copy_file_name = path_to_file + "\\(copy " + index_of_copy_file + ")"  + file_name + extension_of_file;
            }

            RasterImage img = new RasterImage((Bitmap)picBox_edit.Image.Clone());
            img.Save(full_copy_file_name);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string img_path = Image_form.img_full_file_path;
            string path_to_file = Path.GetDirectoryName(img_path);
            string file_name = Path.GetFileNameWithoutExtension(img_path);
            string extension_of_file = Path.GetExtension(img_path).ToLower();

            SaveFileDialog save = new SaveFileDialog();

            save.Filter = "Jpeg Image|*.jpg|Bitmap Image|*.bmp|PNG Image|*.png";
            save.Title = "Save the File";
            save.InitialDirectory = path_to_file;
            save.DefaultExt = extension_of_file;

            if (save.ShowDialog() == DialogResult.OK)
            {
                RasterImage img = new RasterImage((Bitmap)picBox_edit.Image.Clone());
                img.Save(save.FileName);
            }    
            
            MessageBox.Show("File has been saved to: " + "\n" + path_to_file);
        }

        private void OnBtnRotateClicked(object source, EventArgs args)
        {
            edit_img.RotateFlip(RotateFlipType.Rotate90FlipNone);
            picBox_edit.Image.Dispose();
            picBox_edit.Image = (Image)edit_img.Clone();
        }

        private void OnBtnFlipClicked(object source, EventArgs args)
        {
            edit_img.RotateFlip(RotateFlipType.RotateNoneFlipX);
            picBox_edit.Image.Dispose();
            picBox_edit.Image = (Image)edit_img.Clone();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            edit_img.Dispose();
            picBox_edit.Image.Dispose();

            edit_img = (Image)Image_form.img_main.Clone();
            picBox_edit.Image = (Image)Image_form.img_main.Clone();

            ResetRotateForm();
            ResetFilterForm();
        }

        private void ResetRotateForm()
        {
            Adjustments_form.__instance.trackBar_light.Value = 0;
            Adjustments_form.__instance.trackBar_color.Value = 255;
        }

        private void ResetFilterForm()
        {
            Filter_form.__instance.picBox_posterize.Image = Posterize(7);
            Filter_form.__instance.picBox_charcoalSkectch.Image = CharcoalSkectch();
            Filter_form.__instance.picBox_oilPaint.Image = OilPaint();
        }

        private void OnLightChanged(object sender, int e)
        {
            RasterImage img = new RasterImage((Bitmap)edit_img.Clone());
            ImageProcess process = new ImageProcess(img);

            double brightness = (double)e;
            //modify the brightness and contrast
            process.BrightnessContrastImage(brightness, 0.0f);

            picBox_edit.Image.Dispose();
            picBox_edit.Image = (Image)img.ToBitmap().Clone();

            img.Dispose();
        }

        private void OnColorChanged(object sender, int e)
        {
            picBox_edit.Image.Dispose();
            picBox_edit.Image = Solorize((double)e);
        }

        private void OnBtnGrayClicked(object sender, EventArgs e)
        {
            Image img = (Image)picBox_edit.Image.Clone();
            Bitmap bmpInverted = new Bitmap(img.Width, img.Height);
            ImageAttributes ia = new ImageAttributes();
            ColorMatrix cmPicture = new ColorMatrix(new float[][]
                {
                new float[] {0.299f, 0.299f, 0.299f, 0, 0},
                new float[] {0.587f, 0.587f, 0.587f, 0, 0},
                new float[] {0.114f, 0.114f, 0.114f, 0, 0},
                new float[] {     0,      0,      0, 1, 0},
                new float[] {     0,      0,      0, 0, 0}
                });
            ia.SetColorMatrix(cmPicture);
            Graphics g = Graphics.FromImage(bmpInverted);
            g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
            ia.Dispose();
            g.Dispose();

            edit_img.Dispose();
            edit_img = (Image)bmpInverted.Clone();
            picBox_edit.Image.Dispose();
            picBox_edit.Image = (Image)bmpInverted.Clone();
        }

        private void OnBtnNegativeClicked(object sender, EventArgs e)
        {
            RasterImage img = new RasterImage((Bitmap)picBox_edit.Image.Clone());
            ImageProcess process = new ImageProcess(img);
            process.NegateImage(false);

            edit_img.Dispose();
            edit_img = (Image)img.ToBitmap().Clone();
            picBox_edit.Image.Dispose();
            picBox_edit.Image = (Image)img.ToBitmap().Clone();
        }

        private Image Posterize(int level_poster) // Lam anh nhu poster phim
        {
            RasterImage img = new RasterImage((Bitmap)edit_img.Clone());
            ImageProcess process = new ImageProcess(img);
            process.PosterizeImage(level_poster, true); // Gia tri thu 2 ko doi, level_poster ko nen cho qua thap

            return (Image)img.ToBitmap().Clone();
        }

        private Image Solorize(double factor) // Luoc bo cac mau co gia tri cao hon factor (0 - 255)
        {
            RasterImage img = new RasterImage((Bitmap)edit_img.Clone());
            ImageProcess process = new ImageProcess(img);
            process.SolarizeImage(factor);

            return (Image)img.ToBitmap().Clone();
        }

        private Image CharcoalSkectch() // Lam anh nhu tranh ve bang but chi
        {
            RasterImage img = new RasterImage((Bitmap)edit_img.Clone());
            ImageProcess process = new ImageProcess(img);
            process.CharcoaImage(3f, 3f);

            return (Image)img.ToBitmap().Clone();
        }

        private Image OilPaint() // Lam anh nhu tranh son dau, ham xu li hoi lau
        {
            RasterImage img = new RasterImage((Bitmap)edit_img.Clone());
            ImageProcess process = new ImageProcess(img);
            process.OilPaintImage(4f);

            return (Image)img.ToBitmap().Clone();
        }

        private void OnChangedToPosterize(object sender, EventArgs e)
        {
            picBox_edit.Image = (Image)Filter_form.__instance.picBox_posterize.Image.Clone();
        }

        private void OnChangedToOilPaint(object sender, EventArgs e)
        {
            picBox_edit.Image = (Image)Filter_form.__instance.picBox_oilPaint.Image.Clone();
        }

        private void OnChangedToCharcoalSkectch(object sender, EventArgs e)
        {
            picBox_edit.Image = (Image)Filter_form.__instance.picBox_charcoalSkectch.Image.Clone();
        }
    }
}
