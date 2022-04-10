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
    public partial class KitapSiparisOlustur : Form
    {
        public KitapSiparisOlustur()
        {
            InitializeComponent();
        }
        decimal toplamkitapTutar = 0;

        public static List<Siparis> siparisListesi = new List<Siparis>();
        public static List<Kitap> KitapListesi = new List<Kitap>()
        {
            new Kitap{Kitapadi="Şeker Portakalı",Yazari="Jose Mauro De Vasconceles",Fiyati=22},
            new Kitap{Kitapadi="Son Şiirleri",Yazari="Nazım Hikmet",Fiyati=35}
        };

        public static List<KitapEkstra> kitapEkstraListesi = new List<KitapEkstra>()
        {
            new KitapEkstra{Adi="Ayırac",Fiyati=2},
            new KitapEkstra{Adi="Magnet",Fiyati=2.5m},
        };

        private void btnHesaplaıcecek_Click(object sender, EventArgs e)
        {
            if (nudAdet.Value > 0)
            {
                Siparis siparis = new Siparis();
                siparis.SeciliKitap = (Kitap)cmbKitap.SelectedItem;

                siparis.EkitapListesi = new List<KitapEkstra>();
                foreach (CheckBox chc in GrpKitapEkstralar.Controls)
                {
                    if (chc.Checked == true)
                    {
                        KitapEkstra ke = (KitapEkstra)chc.Tag;
                        siparis.EkitapListesi.Add(ke);
                    }
                }

                siparis.Adet = Convert.ToInt32(nudAdet.Value);
                siparis.KitapHesapla();
                listBox1.Items.Add(siparis.Kitapyaz());
                toplamkitapTutar += siparis.KitapHesapla();

                lblToplamTutar.Text = toplamkitapTutar.ToString();

                siparis.Ekle(siparis);
            }
            else
            {
                MessageBox.Show("Sipariş Adedi Giriniz..");
            }
        }

        private void KitapSiparisOlustur_Load(object sender, EventArgs e)
        {
            cmbKitap.DataSource = KitapListesi.ToList();
            cmbKitap.DisplayMember = "Kitapadi";

            cmbKitap.SelectedIndex = -1;
            this.cmbKitap.TextChanged += new System.EventHandler(this.cmbKitap_TextChanged);

            foreach (KitapEkstra ekstra in kitapEkstraListesi)
            {
                CheckBox chk = new CheckBox();
                chk.Text = ekstra.Adi + " " + ekstra.Fiyati.ToString("C2");
                chk.Tag = ekstra;//boxing
                GrpKitapEkstralar.Controls.Add(chk);
            }

        }

        private void cmbKitap_TextChanged(object sender, EventArgs e)
        {
            Font lblFont = new Font("Microsoft Sans Serif", 14);
            foreach (Kitap kitap in KitapListesi)
            {
                if (cmbKitap.Text == kitap.Kitapadi)
                {
                    groupBox1.Controls.RemoveByKey("lbl1");
                    groupBox1.Controls.RemoveByKey("lbl2");
                    Label lbl = new Label();
                    lbl.Text = "Yazar : " + kitap.Yazari;
                    lbl.Name = "lbl1";
                    lbl.Width = 400;
                    lbl.Left = label4.Left;
                    lbl.Top = label4.Top;
                    lbl.AutoSize = false;
                    lbl.Font = lblFont;
                    groupBox1.Controls.Add(lbl);

                    lbl = new Label();
                    lbl.Text = "Fiyatı: " + kitap.Fiyati.ToString("C2");
                    lbl.Name = "lbl2";
                    lbl.Width = 400;
                    lbl.Font = lblFont;
                    lbl.Left = label5.Left;
                    lbl.Top = label5.Top;
                    groupBox1.Controls.Add(lbl);

                }
            }

        }

        private void btnSiparisiTamamla_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Toplam Sipariş Tutarı :" + toplamkitapTutar.ToString("C2") + " satın almayı tamamlamak istiyor musunuz?", "Sipariş Tamamla", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                {
                    if (dr == DialogResult.Yes)
                    {
                        toplamkitapTutar = 0;
                        Temizle();
                        lblToplamTutar.Text = "0 TL";
                        MessageBox.Show("Sipariş tamamlandı");
                    }
                    else
                    {
                        Siparis siparis = new Siparis();
                        siparis.Sil();

                        toplamkitapTutar = 0;
                        Temizle();
                        lblToplamTutar.Text = "0 TL";
                        MessageBox.Show("Sipariş İptal Edildi");
                    }
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

                foreach (CheckBox chc in GrpKitapEkstralar.Controls)
                {
                    chc.Checked = false;

                }

                foreach (Label lbl in groupBox1.Controls)
                {
                    lbl.Visible = false;

                }
            }
        }

    }
}
