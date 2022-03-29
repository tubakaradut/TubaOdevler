using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Dolap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Urun> UrunListesi = new List<Urun>();
        List<Urun> SecilenUrunListesi = new List<Urun>();

        decimal toplamTutar = 0;

        Urun urun = new Urun();
        private void Form1_Load(object sender, EventArgs e)
        {
            /*
             uygulama açıldığında;
 3 adet ayakkabı
 3 adet tshirt
 3 adet pantolon
 3 adet mont

tanımlayarak ilgili list boxlarda özellikleri ile listeleyin. Kullanıcı listbox içerisinde tanımlı olan item'a çift tıkladıktan sonra lstSepet'e seçili olan item özellikleri ile eklensin ve toplam tutar'a ilgili ürünün fiyatı dahil edilsin.

alışverişi tamamla butonuna basıldıktan sonra lstSepet içerisinde bulunan itemlar listview içerisinde göserilsin ve lstSepet temizlensin.

listboxlar içerisinde fiyatlar kdv hariç sepete eklenildiğinde kdv dahil olarak hem gösterilecek hem de hesaplanacak.
             */


            //Mont
            Mont mont1 = new Mont();
            Mont mont2 = new Mont();
            Mont mont3 = new Mont();

            mont1.UrunAdi = "Kaşe Mont";
            mont1.Fiyat = 650;
            mont1.Beden = "44 Beden";
            mont1.Kalip = "Dar Kalıp";
            mont1.Renk = "Siyah Renk";

            mont2.UrunAdi = "Şişme Mont";
            mont2.Fiyat = 450;
            mont2.Beden = "42 Beden";
            mont2.Kalip = "Oversize Kalıp";
            mont2.Renk = "Kırmızı Renk";


            mont3.UrunAdi = "Deri Mont";
            mont3.Fiyat = 350;
            mont3.Beden = "36 Beden";
            mont3.Kalip = "Standart Kalıp";
            mont3.Renk = "Bordo Renk";

            //Pantolon
            Pantolon pantolon1 = new Pantolon();
            Pantolon pantolon2 = new Pantolon();
            Pantolon pantolon3 = new Pantolon();

            pantolon1.UrunAdi = "İspanyol Paça Pantolon";
            pantolon1.Fiyat = 250;
            pantolon1.Beden = "38 Beden";
            pantolon1.Kalip = "Oversize Kalıp";
            pantolon1.Renk = "Lacivert Renk";

            pantolon2.UrunAdi = "Kumaş Pantolon";
            pantolon2.Fiyat = 150;
            pantolon2.Beden = "44 Beden";
            pantolon2.Kalip = "Normal Kalıp";
            pantolon2.Renk = "Kahverengi Renk";

            pantolon3.UrunAdi = "Deri Pantolon";
            pantolon3.Fiyat = 200;
            pantolon3.Beden = "40 Beden";
            pantolon3.Kalip = "SlimFit Kalıp";
            pantolon3.Renk = "Siyah Renk";

            //Ayakkabı
            Ayakkabi ayakkabi1 = new Ayakkabi();
            Ayakkabi ayakkabi2 = new Ayakkabi();
            Ayakkabi ayakkabi3 = new Ayakkabi();

            ayakkabi1.UrunAdi = "Spor Ayakkabı";
            ayakkabi1.Fiyat = 650;
            ayakkabi1.Numara = "40 Numara";
            ayakkabi1.Materyal = "MikroFiber";
            ayakkabi1.Renk = "Beyaz Renk";

            ayakkabi2.UrunAdi = "Topuklu Ayakkabı";
            ayakkabi2.Fiyat = 250;
            ayakkabi2.Numara = "36 Numara"; ;
            ayakkabi2.Materyal = "Rugan";
            ayakkabi2.Renk = "Krem Renk";

            ayakkabi3.UrunAdi = "Postal Ayakkabı";
            ayakkabi3.Fiyat = 350;
            ayakkabi3.Numara = "44 Numara"; ;
            ayakkabi3.Materyal = "Suni Deri";
            ayakkabi3.Renk = "Siyah Renk";

            // Tshirt
            Tshirt tshirt1 = new Tshirt();
            Tshirt tshirt2 = new Tshirt();
            Tshirt tshirt3 = new Tshirt();

            tshirt1.UrunAdi = "Nasa Baskılı Tshirt ";
            tshirt1.Fiyat = 90;
            tshirt1.Beden = "42 Beden";
            tshirt1.Kalip = "SlimFit Kalıp";
            tshirt1.Renk = "Sarı Renk";

            tshirt2.UrunAdi = "Yakalı Tshirt";
            tshirt2.Fiyat = 80;
            tshirt2.Beden = "38 Beden";
            tshirt2.Kalip = "Standart Kalıp";
            tshirt2.Renk = "Mor Renk";

            tshirt3.UrunAdi = "Bisiklet Yakalı Tshirt";
            tshirt3.Fiyat = 100;
            tshirt3.Beden = "48 Beden";
            tshirt3.Kalip = "Büyük Kalıp";
            tshirt3.Renk = "Mavi Renk";

            //urun listesine atılması

            UrunListesi.Add(ayakkabi1);
            UrunListesi.Add(ayakkabi2);
            UrunListesi.Add(ayakkabi3);

            UrunListesi.Add(pantolon1);
            UrunListesi.Add(pantolon2);
            UrunListesi.Add(pantolon3);

            UrunListesi.Add(mont1);
            UrunListesi.Add(mont2);
            UrunListesi.Add(mont3);

            UrunListesi.Add(tshirt1);
            UrunListesi.Add(tshirt2);
            UrunListesi.Add(tshirt3);


            //listboxlara ekleme işlemi

            foreach (Urun urun in UrunListesi)
            {
                if (urun is Ayakkabi)
                {
                    Ayakkabi ayakkabi = (Ayakkabi)urun;
                    lstAyakkabi.Items.Add(ayakkabi);
                }
                else if (urun is Tshirt)
                {
                    Tshirt tshirt = (Tshirt)urun;
                    lstTshirt.Items.Add(tshirt);
                }
                else if (urun is Pantolon)
                {
                    Pantolon pantolon = (Pantolon)urun;
                    lstPantolon.Items.Add(pantolon);
                }
                else if (urun is Mont)
                {
                    Mont mont = (Mont)urun;
                    lstMont.Items.Add(mont);
                }

            }

        }

        private void lstAyakkabi_DoubleClick(object sender, EventArgs e)
        {
            Ayakkabi ayakkabi = (Ayakkabi)lstAyakkabi.SelectedItem;
            toplamTutar += ayakkabi.KDVDahilFiyat;
            lblToplamTutar.Text = toplamTutar.ToString("C2");
            lstSepet.Items.Add(ayakkabi);

            Urun secilenAyakkabı = new Urun();
            secilenAyakkabı.UrunAdi = ayakkabi.UrunAdi;
            secilenAyakkabı.Kategori = ayakkabi.Kategori;
            secilenAyakkabı.Fiyat = ayakkabi.KDVDahilFiyat;

            SecilenUrunListesi.Add(secilenAyakkabı);

        }

        private void lstTshirt_DoubleClick(object sender, EventArgs e)
        {
            Tshirt tshirt = (Tshirt)lstTshirt.SelectedItem;
            toplamTutar += tshirt.KDVDahilFiyat;
            lblToplamTutar.Text = toplamTutar.ToString("C2");
            lstSepet.Items.Add(tshirt);

            Urun secilenTshirt= new Urun();
            secilenTshirt.UrunAdi = tshirt.UrunAdi;
            secilenTshirt.Kategori = tshirt.Kategori;
            secilenTshirt.Fiyat = tshirt.KDVDahilFiyat;

            SecilenUrunListesi.Add(secilenTshirt);

        }

        private void lstPantolon_DoubleClick(object sender, EventArgs e)
        {
            Pantolon pantolon = (Pantolon)lstPantolon.SelectedItem;
            toplamTutar += pantolon.KDVDahilFiyat;
            lblToplamTutar.Text = toplamTutar.ToString("C2");
            lstSepet.Items.Add(pantolon);

            Urun secilenPantolon = new Urun();
            secilenPantolon.UrunAdi = pantolon.UrunAdi;
            secilenPantolon.Kategori = pantolon.Kategori;
            secilenPantolon.Fiyat = pantolon.KDVDahilFiyat;

            SecilenUrunListesi.Add(secilenPantolon);
        }

        private void lstMont_DoubleClick(object sender, EventArgs e)
        {
            Mont mont = (Mont)lstMont.SelectedItem;
            toplamTutar += mont.KDVDahilFiyat;
            lblToplamTutar.Text = toplamTutar.ToString("C2");
            lstSepet.Items.Add(mont);

            Urun secilenUrun = new Urun() { UrunAdi = mont.UrunAdi, Kategori = mont.Kategori, Fiyat = mont.KDVDahilFiyat };

            SecilenUrunListesi.Add(secilenUrun);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Urun secilen in SecilenUrunListesi)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = secilen.UrunAdi;
                lvi.SubItems.Add(secilen.Kategori);
                lvi.SubItems.Add(DateTime.Now.ToString());
                lvi.SubItems.Add(secilen.KDVDahilFiyat.ToString());
                listView1.Items.Add(lvi);
            }

            SecilenUrunListesi.Clear();
            lstSepet.Items.Clear();
            lstAyakkabi.SelectedIndex = -1;
            lstMont.SelectedIndex = -1;
            lstPantolon.SelectedIndex = -1;
            lstTshirt.SelectedIndex = -1;


        }
    }
}
