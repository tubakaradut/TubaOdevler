using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitapKafe
{
    public partial class IcecekOlustur : Form
    {
        public IcecekOlustur()
        {
            InitializeComponent();
        }

        private void btnİcecekEkle_Click(object sender, EventArgs e)
        {
            Icecek ıcecek = new Icecek();
            ıcecek.Adi = txticecekAdi.Text;
            ıcecek.Fiyati = nudicecekFiyat.Value;

            if (txticecekAdi.Text != null || nudicecekFiyat.Value != 0 )
            {

                IcecekSiparisOlustur.IcecekListesi.Add(ıcecek);

            }
            else
            {
                MessageBox.Show("boş değer eklenemez!");
            }

            txticecekAdi.Text = "";
            nudicecekFiyat.Value = 0;

            MessageBox.Show("Yeni İçecek Eklendi!");

        }
    }
}
