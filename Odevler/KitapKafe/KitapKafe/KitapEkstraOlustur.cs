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
    public partial class KitapEkstraOlustur : Form
    {
        public KitapEkstraOlustur()
        {
            InitializeComponent();
        }

        private void btnEkstraEkle_Click(object sender, EventArgs e)
        {
            KitapEkstra ekstra = new KitapEkstra();
            ekstra.Adi = txtEkstraAdi.Text;
            ekstra.Fiyati = nudEkstraFiyat.Value;

            if (txtEkstraAdi.Text != null || nudEkstraFiyat.Value != 0)
            {

                KitapSiparisOlustur.kitapEkstraListesi.Add(ekstra);
                MessageBox.Show("Ekstra Eklendi!");
            }
            else
            {
                MessageBox.Show("boş değer eklenemez!");
            }

            txtEkstraAdi.Text = "";
            nudEkstraFiyat.Value = 0;


        }
    }
}
