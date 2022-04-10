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
    public partial class KitapOlustur : Form
    {
        public KitapOlustur()
        {
            InitializeComponent();
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            Kitap kitap = new Kitap();
            kitap.Kitapadi = txtKitapAdi.Text;
            kitap.Yazari = txtYazarAdi.Text;
            kitap.Fiyati = nudKitapFiyat.Value;

            if (txtKitapAdi.Text != null || nudKitapFiyat.Value != 0 || (txtYazarAdi.Text != null))
            {

                KitapSiparisOlustur.KitapListesi.Add(kitap);

            }
            else
            {
                MessageBox.Show("boş değer eklenemez!");
            }

            txtKitapAdi.Text = "";
            txtYazarAdi.Text = "";
            nudKitapFiyat.Value = 0;

            MessageBox.Show("Yeni Kitap Eklendi!");
        }
    }
}
