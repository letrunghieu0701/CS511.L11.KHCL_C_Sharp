using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using RasterEdge.XImage.Raster;

namespace Do_An_New
{
    public partial class Image_form : Form
    {
        public static Image_form __instance = new Image_form();
        public static Image img_main = null;
        public static string img_full_file_path = string.Empty;

        public Image_form()
        {
            InitializeComponent();
        }

        private void Image_form_Load(object sender, EventArgs e)
        {
            Edit_form.__instance.BackBtnClicked += new EventHandler(OnBackBtnClicked);
            Change_format_form.__instance.radioBtnChecked += new EventHandler<string>(OnRadioBtnChecked);
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
            panelToSwitch.Controls.Add(childForm);
            panelToSwitch.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (activeForm == null)
            {
                openChildFormInPanel(Edit_form.__instance);
            }
            else
            {
                activeForm.Visible = true;
            }

            browseToolStripMenuItem.Enabled = false;
        }

        private void browseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // image filters  
            openFileDialog.Filter = "Image Files(*.png; *.jpg; *.jpeg; *.bmp)|*.png; *.jpg; *.jpeg; *.bmp";
            openFileDialog.FileName = string.Empty;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box
                Image img_temp = new Bitmap(openFileDialog.FileName);
                img_main = (Image)img_temp.Clone();
                picBox_main.Image = (Image)img_temp.Clone();
                // image file path  
                img_full_file_path = openFileDialog.FileName;
                editToolStripMenuItem.Enabled = true;
                formatToolStripMenuItem.Enabled = true;
            }
        }

        private void formatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Change_format_form.__instance.ShowDialog();
        }

        private void OnRadioBtnChecked(object sender, string format)
        {
            
            if (format == "png")
            {
                ConvertFormat(img_full_file_path, ".png");
            }
            else if (format == "jpeg")
            {
                ConvertFormat(img_full_file_path, ".jpeg");
            }
            else if (format == "bmp")
            {
                ConvertFormat(img_full_file_path, ".bmp");
            }
        }

        private void ConvertFormat(string file_path, string new_format)
        {
            string path_to_file = Path.GetDirectoryName(file_path);
            string file_name = Path.GetFileNameWithoutExtension(file_path);
            string extension_of_file = new_format;

            int index_of_new_file = 0;

            string full_new_file_name = path_to_file + "\\" + file_name + extension_of_file;
            while (File.Exists(full_new_file_name) == true)
            {
                index_of_new_file += 1;
                full_new_file_name = path_to_file + "\\(" + index_of_new_file + ")" + file_name + extension_of_file;
            }

            ConvertHandler.Convert(file_path, full_new_file_name);

            MessageBox.Show("The new image format has been saved:" + "\n" + full_new_file_name, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        protected void OnBackBtnClicked(object sender, EventArgs e)
        {
            browseToolStripMenuItem.Enabled = true;
            editToolStripMenuItem.Enabled = false;
            formatToolStripMenuItem.Enabled = false;
        }
    }
}
