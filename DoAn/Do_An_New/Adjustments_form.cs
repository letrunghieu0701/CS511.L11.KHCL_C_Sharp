using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_An_New
{
    public partial class Adjustments_form : Form
    {
        public static Adjustments_form __instance = new Adjustments_form();
        public event EventHandler<int> LightChanged;
        public event EventHandler<int> ColorChanged;
        public event EventHandler BtnGrayClicked;
        public event EventHandler BtnNegativeClicked;
        public Adjustments_form()
        {
            InitializeComponent();
        }

        private void numUpDownLight_ValueChanged(object sender, EventArgs e)
        {
            trackBar_light.Value = Convert.ToInt32(numUpDown_light.Value);
            OnLightChanged(trackBar_light.Value);
        }

        private void trackBar_light_ValueChanged(object sender, EventArgs e)
        {
            numUpDown_light.Value = trackBar_light.Value;
            OnLightChanged(trackBar_light.Value);
        }

        private void numUpDownColor_ValueChanged(object sender, EventArgs e)
        {
            trackBar_color.Value = Convert.ToInt32(numUpDown_color.Value);
        }

        private void trackBar_color_ValueChanged(object sender, EventArgs e)
        {
            numUpDown_color.Value = trackBar_color.Value;
            OnColorChanged(trackBar_color.Value);
        }

        protected void OnLightChanged(int e)
        {
            if (LightChanged != null)
            {
                LightChanged(this, e);
            }
        }

        protected void OnColorChanged(int e)
        {
            if (ColorChanged != null)
            {
                ColorChanged(this, e);
            }
        }

        private void btn_gray_Click(object sender, EventArgs e)
        {
            OnBtnGrayClicked();
        }

        protected void OnBtnGrayClicked()
        {
            if (BtnGrayClicked != null)
            {
                BtnGrayClicked(this, EventArgs.Empty);
            }
        }

        private void btn_negative_Click(object sender, EventArgs e)
        {
            OnBtnNegativeClicked();
        }

        protected void OnBtnNegativeClicked()
        {
            if (BtnNegativeClicked != null)
            {
                BtnNegativeClicked(this, EventArgs.Empty);
            }
        }
    }
}
