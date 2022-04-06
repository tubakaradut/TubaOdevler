using System;
using System.Linq;
using System.Windows.Forms;

namespace WFA_McAdam
{
    public partial class Siparisler : Form
    {
        public Siparisler()
        {
            InitializeComponent();
        }

        private void Siparisler_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            decimal ciro = 0;
            decimal ekstraToplamGelir = 0;
            int toplamAdet = 0;

            foreach (var siparis in Siparis.SiparisListesi)
            {
                string ekstraDetay = "";
                decimal ekstralarToplamFiyat = 0;

                foreach (Ekstra ekstra in siparis.Ekstralar)
                {
                    ekstraDetay += $"{ekstra.EkstraAdi} ";
                    ekstralarToplamFiyat += ekstra.Fiyati;
                }

                ekstraToplamGelir += ekstralarToplamFiyat * siparis.AdetSayisi;

                string siparisDetay = $"Menu: {siparis.Menuu.MenuAdi} Ekstralar:  {ekstraDetay} Adet Sayısı:  {siparis.AdetSayisi}";

                listBox1.Items.Add(siparisDetay);

                ciro += ((siparis.Menuu.Fiyati) + (ekstralarToplamFiyat) + (siparis.BoyutFiyat)) * siparis.AdetSayisi;
                toplamAdet += siparis.AdetSayisi;

            }

            lblCiro.Text = ciro.ToString("C2");
            lblEkstraGelir.Text = ekstraToplamGelir.ToString("C2");
            lblSatilanUrunAdedi.Text = toplamAdet.ToString();
            lblToplamSiparis.Text = Siparis.SiparisListesi.Count.ToString();
        }
    }
}
