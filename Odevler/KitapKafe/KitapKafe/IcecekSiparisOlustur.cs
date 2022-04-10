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
    public partial class IcecekSiparisOlustur : Form
    {
        public IcecekSiparisOlustur()
        {
            InitializeComponent();
        }
        decimal toplamTutar = 0;
        //public static List<Siparis> siparisListesi = new List<Siparis>();
        public static List<Icecek> IcecekListesi = new List<Icecek>()
        {
            new Icecek{Adi="Çay",Fiyati=5},
            new Icecek{Adi="Kahve",Fiyati=10}

        };
        public static List<IcecekEkstra> icecekEkstraListesi = new List<IcecekEkstra>()
        {
            new IcecekEkstra{Adi="Kurabiye", Fiyati=5},
            new IcecekEkstra{Adi="Kruvasan",Fiyati=8},
        };

        private void btnHesaplaıcecek_Click(object sender, EventArgs e)
        {
            if (nudAdet.Value > 0)
            {
                Siparis siparis = new Siparis();
                siparis.SeciliIcecek = (Icecek)cmbIcecek.SelectedItem;

                if (rbKucuk.Checked)
                {
                    siparis.SeciliIcecek.boyut = Boyut.Küçük;
                }
                else if (rbOrta.Checked)
                {
                    siparis.SeciliIcecek.boyut = Boyut.Orta;
                }
                else if (rbBuyuk.Checked)
                {
                    siparis.SeciliIcecek.boyut = Boyut.Büyük;
                }

                siparis.EIceceklistesi = new List<IcecekEkstra>();

                foreach (CheckBox chk in flEkstralar.Controls)
                {
                    if (chk.Checked)
                    {
                        IcecekEkstra ei = (IcecekEkstra)chk.Tag;
                        siparis.EIceceklistesi.Add(ei);
                    }
                }

                siparis.Adet = Convert.ToInt32(nudAdet.Value);
                siparis.IcecekHesapla();

                listBox1.Items.Add(siparis.Icecekyaz());

                toplamTutar += siparis.IcecekHesapla();
                lblToplamTutar.Text = toplamTutar.ToString();
                siparis.Ekle(siparis);
            }
            else
            {
                MessageBox.Show("Sipariş Adedi Giriniz..");
            }
        }
        
        private void IcecekSiparisOlustur_Load(object sender, EventArgs e)
        {
            cmbIcecek.DataSource = IcecekListesi.ToList();
         
            cmbIcecek.SelectedIndex = -1;
            foreach (IcecekEkstra ekstra in icecekEkstraListesi)
            {
                CheckBox chk = new CheckBox();
                chk.Text = ekstra.Adi + " " + ekstra.Fiyati.ToString("C2");
                chk.Tag = ekstra;//boxing
                flEkstralar.Controls.Add(chk);
            }
        }

        private void btnSepeticecek_Click(object sender, EventArgs e)
        {

        }
        public static List<Siparis> siparisListesi = new List<Siparis>();
        private void btnTamamlaicecek_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Toplam Sipariş Tutarı :" + toplamTutar.ToString("C2") + " satın almayı tamamlamak istiyor musunuz?", "Sipariş Tamamla", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    toplamTutar = 0;
                    Temizle();
                    lblToplamTutar.Text = "0 TL";
                    MessageBox.Show("Sipariş tamamlandı");
                }
                else
                {
                    Siparis siparis = new Siparis();
                    siparis.Sil();
                    toplamTutar = 0;
                    Temizle();
                    lblToplamTutar.Text = "0 TL";
                    MessageBox.Show("Sipariş İptal Edildi");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Sipariş Olustrun....");
            }
        }
        void Temizle()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is ComboBox)
                {
                    ComboBox cmb = (ComboBox)ctrl;
                    cmb.SelectedIndex = -1;

                }
                else if (ctrl is RadioButton)
                {
                    RadioButton rb = (RadioButton)ctrl;
                    rb.Checked = false;
                }

                else if (ctrl is NumericUpDown)
                {
                    NumericUpDown nud = (NumericUpDown)ctrl;
                    nud.Value = 0;

                }
                else if (ctrl is ListBox)
                {
                    ListBox lst = (ListBox)ctrl;
                    lst.Items.Clear();
                }

                foreach (CheckBox chc in flEkstralar.Controls)
                {
                    chc.Checked = false;
                }

            }
        }
    }
}