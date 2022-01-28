using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace CrossFire_windowsForm
{
    [Designer(typeof(MyDesigner))]   // Note: custom designer
    public partial class ucItem : UserControl
    {
        public event EventHandler<OrderEventArgs> ButttonClicked;
        public ucItem()
        {
            InitializeComponent();
        }

        public PictureBox pictureBox_Item
        {
            get { return pic_Item; }
            set { pic_Item = value; }
        }

        public TextBox textBox_Name
        {
            get { return txt_Name; }
            set { txt_Name = value; }
        }

        public TextBox textBox_Price
        {
            get { return txt_Price; }
            set { txt_Price = value; }
        }

        protected virtual void OnButtonClicked(OrderEventArgs e)
        {
            ButttonClicked?.Invoke(this, e);
        }

        private void btn_Buy_Click(object sender, EventArgs e)
        {
            OrderEventArgs info = new OrderEventArgs(txt_Name.Text, int.Parse(txt_Price.Text));
            OnButtonClicked(info);
        }
    }

    class MyDesigner : ControlDesigner
    {
        public override void Initialize(IComponent comp)
        {
            base.Initialize(comp);
            var uc = (ucItem)comp;
        }
    }
}
