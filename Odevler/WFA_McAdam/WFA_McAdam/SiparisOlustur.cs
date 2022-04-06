using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WFA_McAdam
{
    public partial class SiparisOlustur : Form
    {
        public SiparisOlustur()
        {
            InitializeComponent();
        }

        private void SiparisOlustur_Load(object sender, EventArgs e)
        {
            cmbMenu.DataSource = Menuu.MenuListesi.ToList();
      
            cmbMenu.SelectedIndex = -1;

            foreach (var ekstra in Ekstra.EkstraListesi)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Name = "check_" + ekstra.EkstraAdi;
                checkBox.Text = $"{ekstra.EkstraAdi} {ekstra.Fiyati.ToString("C2")}";

                flowPanelEkstra.Controls.Add(checkBox);
            }
        }
        decimal toplamTutar = 0;
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            List<Ekstra> ekstralar = new List<Ekstra>();
            decimal siparisFiyat = 0;
            decimal boyutFiyat = 0;
            string siparisBilgisi = "";

            siparisBilgisi += cmbMenu.SelectedItem + " ";
           
            foreach (Menuu menu in Menuu.MenuListesi)
            {
                if (cmbMenu.SelectedItem.ToString() == menu.MenuAdi)
                {
                    if (rbBuyuk.Checked == true)
                    {
                        siparisFiyat += menu.Fiyati;
                        siparisFiyat += 5;
                        siparisBilgisi += Boyut.Buyuk + " Boy ";
                        boyutFiyat = 5;
                    }
                    else if (rbOrta.Checked == true)
                    {
                        siparisFiyat += menu.Fiyati;
                        siparisFiyat += 3;
                        siparisBilgisi += Boyut.Orta + " Boy ";
                        boyutFiyat = 3;
                    }
                    else if (rbKucuk.Checked == true)
                    {
                        siparisFiyat += menu.Fiyati;
                        siparisFiyat += 0;
                        siparisBilgisi += Boyut.Kucuk + " Boy ";
                    }
                }
            }

            foreach (CheckBox chc in flowPanelEkstra.Controls)
            {
                if (chc.Checked == true)
                {

                    foreach (Ekstra ekstra in Ekstra.EkstraListesi)
                    {

                        if ("check_" + ekstra.EkstraAdi == chc.Name.ToString())
                        {
                            siparisFiyat += ekstra.Fiyati;
                            siparisBilgisi += ekstra.EkstraAdi + " ";
                            ekstralar.Add(ekstra);
                        }
                    }
                }
            }

            siparisFiyat *= nudAdet.Value;

            toplamTutar += siparisFiyat;

            siparisBilgisi += "Adet: " + nudAdet.Value + " ";

            siparisBilgisi += "Toplam Tutar :" + siparisFiyat.ToString("C2");

            lblToplamTutar.Text = toplamTutar.ToString("C2");

            listBox1.Items.Add(siparisBilgisi);

            Siparis siparis = new Siparis(); 
            Menuu secilenMenu = (Menuu)cmbMenu.SelectedItem;

            siparis.Menuu = secilenMenu;
            siparis.Ekstralar = ekstralar;
            siparis.AdetSayisi = (int)nudAdet.Value;
            siparis.BoyutFiyat = boyutFiyat;

            siparis.Ekle(siparis);
        }

        private void btnSiparisiTamamla_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show($"Toplam Sipariş Sayısı: {listBox1.Items.Count}\nÖdemeniz gereken toplam tutar: {toplamTutar.ToString("C2")}", "Sipariş Tamamla", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                Temizle();
                lblToplamTutar.Text = "0";
                toplamTutar = 0;
            }
            else
            {
                Siparis siparis = new Siparis();
                siparis.Sil();
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
                   
                    foreach (CheckBox chc in flowPanelEkstra.Controls)
                    {
                        chc.Checked = false;
                    }

                }
            }
        }
    }
}