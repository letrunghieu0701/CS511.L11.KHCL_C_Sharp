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
    public partial class Filter_form : Form
    {
        public static Filter_form __instance = new Filter_form();
        public event EventHandler ChangedToPosterize;
        public event EventHandler ChangedToOilPaint;
        public event EventHandler ChangedToCharcoalSkectch;
        public Filter_form()
        {
            InitializeComponent();
        }

        private void picBox_posterize_Click(object sender, EventArgs e)
        {
            OnChangedToPosterize();
        }

        protected void OnChangedToPosterize()
        {
            if (ChangedToPosterize != null)
            {
                ChangedToPosterize(this, EventArgs.Empty);
            }
        }
        private void picBox_oilPaint_Click(object sender, EventArgs e)
        {
            OnChangedToOilPaint();
        }

        protected void OnChangedToOilPaint()
        {
            if (ChangedToOilPaint != null)
            {
                ChangedToOilPaint(this, EventArgs.Empty);
            }
        }

        private void picBox_charcoalSkectch_Click(object sender, EventArgs e)
        {
            OnChangedToCharcoalSkectch();
        }

        protected void OnChangedToCharcoalSkectch()
        {
            if (ChangedToCharcoalSkectch != null)
            {
                ChangedToCharcoalSkectch(this, EventArgs.Empty);
            }
        }
    }
}
