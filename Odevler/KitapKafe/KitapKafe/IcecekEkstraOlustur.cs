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
    public partial class IcecekEkstraOlustur : Form
    {
        public IcecekEkstraOlustur()
        {
            InitializeComponent();
        }

        private void btnEkstraIcecekEkle_Click(object sender, EventArgs e)
        {
            IcecekEkstra ekstra = new IcecekEkstra();
            ekstra.Adi = txtEkstraAdi.Text;
            ekstra.Fiyati = nudEkstraFiyat.Value;

            if (txtEkstraAdi.Text != null && nudEkstraFiyat.Value != 0)
            {

                IcecekSiparisOlustur.icecekEkstraListesi.Add(ekstra);
                MessageBox.Show("Ekstra Urün Eklendi!");

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
