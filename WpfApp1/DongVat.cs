using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1
{
    class DongVat
    {
            private string Keu;

            public string DongvatKeu
            {
                get { return Keu; }
                set { Keu = value; }
            }

            public DongVat(string keu)
            {
                this.Keu = keu;
            }

            public DongVat()
            {
            }
            private string maulong;
            public string MauLong
            {
                get { return maulong; }
                set { maulong = value; }
            }

            public virtual void Talk()
            {
                if (DongvatKeu.Equals("Meo meo") && (MauLong.Equals("Trắng")))
                    MessageBox.Show(this.DongvatKeu + "Tôi là Mèo lông màu" + this.MauLong);
                else if (DongvatKeu.Equals("Gâu gâu") && (MauLong.Equals("Vàng")))
                    MessageBox.Show(this.DongvatKeu + "Tôi là Chó lông màu" + this.MauLong);
            }
        }
}
