using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsanKaynaklari
{
    public partial class PersonelForm : Form
    {
        public PersonelForm()
        {
            InitializeComponent();
        }

      
        private void btnDepartman_Click(object sender, EventArgs e)
        {
            DepartmanForm dp = new DepartmanForm();
            dp.Show();
            this.Hide();
        }

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {

            Personel p = new Personel();
            p.Ad = txtAd.Text;
            p.Soyad = txtSoyad.Text;
            p.TCKN = txtTc.Text;
            p.Departman = (Departman)cmbDepartman.SelectedItem;

            listBox1.Items.Add($"Adı: {p.Ad}, Soyadı: {p.Soyad}, Departman: {p.Departman}, IseGirisTarihi: {p.IseGiris}" );

            txtAd.Text = "";
            txtSoyad.Text = "";
            txtTc.Text = "";
            cmbDepartman.Text="";

        }

        private void PersonelForm_Load(object sender, EventArgs e)
        {
            foreach (Departman departman in DepartmanForm.DepartmanListesi)
            {
                cmbDepartman.Items.Add(departman);
            }
        }
    }
}
