using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hamburgerr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string menu;
        string boyut;
        string ekstralar;
        decimal fiyat = 0;
        decimal güncelFiyat = 0;
        decimal güncelAdet;
        decimal adetSayisi = 0;

        string[] menulerDizi = new string[10];
        string[] boyutlarDizi = new string[10];
        string[] ekstralarDizi = new string[10];
        decimal[] fiyatlarDizi = new decimal[10];
        decimal[] adetlerDizi = new decimal[10];

        int index = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            cbmMenü.Items.Add("Whopper");
            cbmMenü.Items.Add("StackHouse");
            cbmMenü.Items.Add("Tavuk");
        }
        string BoyutEkle()
        {
            string secilen = "";
            if (rbKucuk.Checked == true)
            {
                boyut =" Küçük Boy ";
                fiyat += 0 * nmdAdet.Value;
                secilen = "Küçük Boy";
            }
            else if (rbOrta.Checked == true)
            {
                boyut =" Orta Boy ";
                fiyat += 3 * nmdAdet.Value;
                secilen = "Orta Boy";
            }
            else if (rbBuyuk.Checked == true)
            {
                boyut =" Büyük Boy ";
                fiyat += 5 * nmdAdet.Value;
                secilen = "Büyük Boy";
            }

            return secilen;
        }
        void MenuEkle(string menuler)
        {
            if (cbmMenü.Text == "Whopper")
            {
                fiyat += 25 * nmdAdet.Value;
                menu = " Whopper ";
            }
            else if (cbmMenü.Text == "StackHouse")
            {
                fiyat += 35 * nmdAdet.Value;
                menu =" StackHouse ";
            }
            else if (cbmMenü.Text == "Tavuk")
            {
                fiyat += 20 * nmdAdet.Value;
                menu =" Tavuk ";
            }
        }
        string EkstraEkle()
        {
            ekstralar = "";
            if (chcKetcap.Checked == true)
            {
                fiyat += 2 * nmdAdet.Value;
                ekstralar += " " + " ketcap ";
            }
            if (chcMayonez.Checked == true)
            {
                fiyat += 2 * nmdAdet.Value;
                ekstralar += " " + " mayonez ";
            }

            if (chcRanch.Checked == true)
            {
                fiyat += 2 * nmdAdet.Value;
                ekstralar += " " + " ranch ";
            }
            if (chcSarımsaklı.Checked == true)
            {
                fiyat += 2 * nmdAdet.Value;
                ekstralar += " " + " sarımsaklı ";
            }
            if (chcBufolo.Checked == true)
            {
                fiyat += 2 * nmdAdet.Value;
                ekstralar += " " + " bufola ";
            }
            if (chcChaddar.Checked == true)
            {
                fiyat += 2 * nmdAdet.Value;
                ekstralar += " " + " chaddar ";
            }

            return ekstralar;

        }
        void Temizleme()
        {
            foreach (Control ctrl in this.Controls)
            {

                if (ctrl is NumericUpDown)
                {
                    NumericUpDown nud = (NumericUpDown)ctrl;
                    nud.Value = 0;
                }

                else if (ctrl is ComboBox)
                {
                    ComboBox cmb = (ComboBox)ctrl;
                    cmb.SelectedIndex = -1;
                }
                else if (ctrl is RadioButton)
                {
                    RadioButton rdb = (RadioButton)ctrl;
                    rdb.Checked = false;
                }

            }
            foreach (Control kontrol in this.groupBox2.Controls)
            {
                if (kontrol is CheckBox)
                {
                    CheckBox chc = (CheckBox)kontrol;
                    if (chc.Checked == true)
                    {
                        chc.Checked = false;
                    }

                }
            }
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            MenuEkle(cbmMenü.Text);                             //ListWiew ekleme yapılabilmesi için dizi olusturuldu.
            string boyut = BoyutEkle();                         //BoyutEkle metodundan dönen sonuc için degişken tanımlandı
            string ekstraSecilenler = EkstraEkle();             //EkstraEkle metodundan dönen sonuc için degişken tanımlandı

            adetSayisi = nmdAdet.Value;
            güncelAdet += adetSayisi;
            güncelFiyat += fiyat;

            //dizilere ekleme
            menulerDizi[index] = cbmMenü.Text;                     //ListWiew ekleme yapılabilmesi için dizi olusturuldu.
            boyutlarDizi[index] = boyut;                           // geri döndüren metot kullanıldıgı için dönen sonuc yazıldı.
            ekstralarDizi[index] = ekstraSecilenler;               // geri döndüren metot kullanıldıgı için dönen sonuc yazıldı.
            fiyatlarDizi[index] = fiyat;
            adetlerDizi[index] = adetSayisi;

            index++;                                               //dizilere dogru indeks numarası vermek için globalde tanımlanıp her ekle butonunda artırması saglanacak ki siparis kaymasın...

            string format = string.Format("{0} Menü, {1}, Ekstralar: {2}, {3} Adet, fiyat: {4} TL   ", menu, boyut, ekstralar, adetSayisi.ToString(), fiyat.ToString());
            fiyat += güncelFiyat;


            lblToplamFiyat.Text = güncelFiyat.ToString();
            listBox1.Items.Add(format);

            fiyat = 0;
            Temizleme();
        }
        void ListwiewEkleme()
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {

                ListViewItem lvi = new ListViewItem();
                lvi.Text = menulerDizi[i];
                lvi.SubItems.Add(boyutlarDizi[i]);
                lvi.SubItems.Add(ekstralarDizi[i]);
                lvi.SubItems.Add(fiyatlarDizi[i].ToString() + " TL");
                lvi.SubItems.Add(adetlerDizi[i].ToString());
                listView1.Items.Add(lvi);
            }
        }

        private void btnSiparis_Click(object sender, EventArgs e)
        {
            string format = string.Format("{0} adet siparisiniz bulunmaktadır, Toplam Tutarınız {1} TLdir. ", güncelAdet.ToString(), güncelFiyat.ToString());

            DialogResult dr = MessageBox.Show(format + "Siparişi onaylıyor musunuz?", " :))", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                ListwiewEkleme();
                listBox1.Items.Clear();
                lblToplamFiyat.Text = "0";
                index = 0;
                güncelFiyat = 0;
                güncelAdet = 0;
            }
            else
            {
                Temizleme();
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is ListBox)
                    {
                        ListBox lst = (ListBox)ctrl;
                        lst.Items.Clear();

                    }

                }
               
                lblToplamFiyat.Text = "0";
                index = 0;
                güncelFiyat = 0;
                güncelAdet = 0;
            }
        }
    }
}
