using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFKimBilirSql
{
    public partial class OgrenciBilgileriForm : Form
    {
        public OgrenciBilgileriForm()
        {
            InitializeComponent();
        }
        SinifListeEntities1 db = new SinifListeEntities1();

        private void OgrenciBilgileriForm_Load(object sender, EventArgs e)
        {
            GetPersons();
        }
        public void GetPersons()
        {
            listView1.Items.Clear();
            foreach (Ogrenciler ogrenci in db.Ogrencilers)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = ogrenci.Id.ToString();
                lvi.SubItems.Add(ogrenci.Ad);
                lvi.SubItems.Add(ogrenci.Soyad);
                lvi.SubItems.Add(ogrenci.Puan.ToString());
                lvi.SubItems.Add(ogrenci.Facebook);
                lvi.SubItems.Add(ogrenci.Twitter);
                lvi.SubItems.Add(ogrenci.Github);
                lvi.Tag = ogrenci;
                listView1.Items.Add(lvi);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Ogrenciler ogrenci = new Ogrenciler();
            ogrenci.Ad = txtAd.Text;
            ogrenci.Soyad = txtSoyad.Text;
            ogrenci.Puan = Convert.ToInt32(txtPuan.Text);
            ogrenci.Facebook = txtFacebook.Text;
            ogrenci.Twitter = txtTwitter.Text;
            ogrenci.Github = txtGithub.Text;

            db.Ogrencilers.Add(ogrenci);
            db.SaveChanges();
            MessageBox.Show("Kişi kaydedildi!");
            GetPersons();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                Ogrenciler o = (Ogrenciler)listView1.SelectedItems[0].Tag;
                db.Ogrencilers.Remove(o);
                db.SaveChanges();
                MessageBox.Show("kişi silindi!");
                GetPersons();
            }
            else
            {
                MessageBox.Show("önce bir veri ekleyin");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            guncellencek.Ad = txtAd.Text;
            guncellencek.Soyad = txtSoyad.Text;
            guncellencek.Puan = Convert.ToInt32(txtPuan.Text);
            guncellencek.Facebook = txtFacebook.Text;
            guncellencek.Twitter = txtTwitter.Text;
            guncellencek.Github = txtGithub.Text;

            db.SaveChanges();
            MessageBox.Show("Veri güncellendi!");
            GetPersons();

        }
        Ogrenciler guncellencek;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                guncellencek = (Ogrenciler)listView1.SelectedItems[0].Tag;
                txtAd.Text = guncellencek.Ad;
                txtSoyad.Text = guncellencek.Soyad;
                txtPuan.Text = guncellencek.Puan.ToString();
                txtFacebook.Text = guncellencek.Facebook;
                txtTwitter.Text = guncellencek.Twitter;
                txtGithub.Text = guncellencek.Github;

                btnKaydet.Enabled = false;
            }
        }

        public void GetOgrenciArama(string aranacak)
        {
            listView1.Items.Clear();

            foreach (Ogrenciler ogrenci in db.Ogrencilers.Where(x=>x.Ad.StartsWith(aranacak)|| x.Soyad.StartsWith(aranacak)))
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = ogrenci.Id.ToString();
                lvi.SubItems.Add(ogrenci.Ad);
                lvi.SubItems.Add(ogrenci.Soyad);
                lvi.SubItems.Add(ogrenci.Puan.ToString());
                lvi.SubItems.Add(ogrenci.Facebook);
                lvi.SubItems.Add(ogrenci.Twitter);
                lvi.SubItems.Add(ogrenci.Github);
                lvi.Tag = ogrenci;
                listView1.Items.Add(lvi);
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            GetOgrenciArama(textBox1.Text);
        }
    }
}
