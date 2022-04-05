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
    public partial class AdminForm : Form
    {

        public AdminForm()
        {
            InitializeComponent();

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = Hamburger.hamburgerListesi.ToList();
            listBox2.DataSource = Ekstra.ekstraListesi.ToList();
        }

        private void btnMenuEkle_Click(object sender, EventArgs e)
        {
            Hamburger hm = new Hamburger();
            hm.Adi = txtMenu1.Text;
            hm.Fiyati = nmMenuFiyat.Value;

            string mesaj = hm.Ekle();
            MessageBox.Show(mesaj);

            listBox1.DataSource = Hamburger.hamburgerListesi.ToList();

            txtMenu1.Text = "";
            nmMenuFiyat.Value = 0;

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            HamburgerForm hf = new HamburgerForm();
            hf.Show();
            this.Hide();
        }

        private void btnEkstraEkle_Click(object sender, EventArgs e)
        {
            Ekstra eks = new Ekstra();
            eks.Adi = txtEkstra.Text;
            eks.Fiyati = nmEkstraFiyat.Value;

            string mesaj = eks.Ekle();
            MessageBox.Show(mesaj);

            listBox2.DataSource = Ekstra.ekstraListesi.ToList();
            nmEkstraFiyat.Value = 0;
            txtEkstra.Text = "";
        }

        private void btnMenuGuncelle_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBox1.SelectedIndex;
            if (selectedIndex >= 0)
            {
                Hamburger hm = new Hamburger();
                hm.Adi = txtMenu1.Text;
                hm.Fiyati = nmMenuFiyat.Value;

                string message = hm.Guncelle(selectedIndex);
                MessageBox.Show(message);

                listBox1.DataSource = Hamburger.hamburgerListesi.ToList();

                nmMenuFiyat.Value = 0;
                txtMenu1.Text = "";

            }
        }

        private void btnEkstraGuncelle_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBox2.SelectedIndex;
            if (selectedIndex >= 0)
            {
                Ekstra eks = new Ekstra();
                eks.Adi = txtEkstra.Text;
                eks.Fiyati = nmEkstraFiyat.Value;

                string mesaj = eks.Ekle();
                MessageBox.Show(mesaj);

                listBox2.DataSource = Ekstra.ekstraListesi.ToList();

                nmEkstraFiyat.Value = 0;
                txtEkstra.Text = "";
                
            }
           
        }
    }
}