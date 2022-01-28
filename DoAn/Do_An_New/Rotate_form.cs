using System;
using System.Windows.Forms;

namespace Do_An_New
{
    public partial class Rotate_form : Form
    {
        public static Rotate_form __instance = new Rotate_form();
        public event EventHandler BtnRotateClicked;
        public event EventHandler BtnFlipClicked;
        public Rotate_form()
        {
            InitializeComponent();

            //Edit_form.__instance.BtnResetClicked += new EventHandler(OnBtnResetClicked);

        }

        private void btn_rotate_Click(object sender, EventArgs e)
        {
            OnBtnRotateClicked();
        }

        protected  void OnBtnRotateClicked()
        {
            if (BtnRotateClicked != null)
            {
                BtnRotateClicked(this, EventArgs.Empty);
            }
        }

        private void btn_flip_Click(object sender, EventArgs e)
        {
            OnBtnFlipClicked();
        }

        protected void OnBtnFlipClicked()
        {
            if (BtnFlipClicked != null)
            {
                BtnFlipClicked(this, EventArgs.Empty);
            }
        }
    }
}
