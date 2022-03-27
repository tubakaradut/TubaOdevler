using System.Windows.Forms;

namespace Sinifornekleri
{
    public class Bankamatik
    {

        public decimal kasa = 500;
        private decimal _yatirmaBolmesi;

        public decimal YatirmaBolmesi
        {
            get { return _yatirmaBolmesi; }
            set
            {
                if (value <= 0)
                {
                    MessageBox.Show("0 tutarında Para yatırma işlemi yapılamaz");
                }
                else
                {
                    _yatirmaBolmesi = value;
                }
            }
        }

        private decimal _cekmeBolmesi;

        public decimal CekmeBolmesi
        {
            get { return _cekmeBolmesi; }
            set
            {
                if (kasa < value)
                {
                    MessageBox.Show("Yetersiz Bakiye");
                }
                else if (value == 0)
                {
                    MessageBox.Show("0 para cekilmez");
                }
                else
                {
                    _cekmeBolmesi = value;
                }
            }
        }




    }
}
