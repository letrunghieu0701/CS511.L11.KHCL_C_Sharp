using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrossFire_windowsForm
{
    public class OrderEventArgs
    {
        private string _tenMon;

        public string TenMon
        {
            get { return _tenMon; }
            set { _tenMon = value; }
        }

        private double _gia;

        public double Gia
        {
            get { return _gia; }
            set { _gia = value; }
        }

        public OrderEventArgs(string tenMon, double gia)
        {
            TenMon = tenMon;
            Gia = gia;
        }
    }
}
