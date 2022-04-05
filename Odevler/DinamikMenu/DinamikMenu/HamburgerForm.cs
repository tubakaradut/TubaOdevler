using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinamikMenu
{
    public partial class HamburgerForm : Form
    {
        public HamburgerForm()
        {
            InitializeComponent();
           
        }
     
        private void HamburgerForm_Load(object sender, EventArgs e)
        {

            foreach (Hamburger hamburger in Hamburger.hamburgerListesi)
            {
                cbmMenü.Items.Add(hamburger.Adi);

            }

            foreach (Ekstra ekstra in Ekstra.ekstraListesi)
            {
                cmbEkstralar.Items.Add(ekstra.Adi);
              
            }
                  

            //cbmMenü.DataSource = Hamburger.hamburgerListesi.ToList();
            //cmbEkstralar.DataSource = Ekstra.ekstraListesi.ToList();

            cmbEkstralar.SelectedIndex = -1;
            cbmMenü.SelectedIndex = -1;

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            AdminForm af = new AdminForm();
            af.Show();
            this.Hide();
        }

        static List<decimal> fiyatListesi = new List<decimal>();

        decimal toplamTutar = 0;
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            decimal siparisFiyat = 0;

            string siparisBilgisi = "";

            siparisBilgisi += cbmMenü.SelectedItem + " ";

            foreach (Hamburger hf in Hamburger.hamburgerListesi)
            {
                if ((string)cbmMenü.SelectedItem==hf.Adi)
                {
                    siparisFiyat += hf.Fiyati;
                   
                }

            }
            siparisBilgisi += cmbEkstralar.SelectedItem + " ";
            foreach (Ekstra ek in Ekstra.ekstraListesi)
            {
                if ((string)cmbEkstralar.SelectedItem==ek.Adi)
                {
                    siparisFiyat += ek.Fiyati;
                }
            }

            if (rbKucuk.Checked)
            {
                siparisBilgisi += rbKucuk.Text + " ";

            }
            else if (rbOrta.Checked)
            {
                siparisBilgisi += rbOrta.Text + " ";
                siparisFiyat += 3;
            }
            else if (rbBuyuk.Checked)
            {
                siparisBilgisi += rbBuyuk.Text + " ";
                siparisFiyat += 5;
            }

            siparisFiyat *= nmdAdet.Value;

            siparisBilgisi += "Adet: " + nmdAdet.Value + " ";

            siparisBilgisi += "Toplam Tutar :" + siparisFiyat.ToString("C2");

          
            toplamTutar += siparisFiyat;
            lblToplamFiyat.Text = toplamTutar.ToString("C2");

            listBox1.Items.Add(siparisBilgisi);
        }

        private void btnSiparis_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show($"Toplam Sipariş Sayısı: {listBox1.Items.Count}\nÖdemeniz gereken toplam tutar: {toplamTutar.ToString("C2")}", "Sipariş Tamamla", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                Temizle();
                lblToplamFiyat.Text = "0";
                toplamTutar = 0;

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

                toplamTutar = 0;
                lblToplamFiyat.Text = "0";
            }
        }

    }
}
    
