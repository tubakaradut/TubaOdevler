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
    public partial class KimBilirForm : Form
    {
        public KimBilirForm()
        {
            InitializeComponent();
        }
        SinifListeEntities1 db = new SinifListeEntities1();
        Random rnd = new Random();

        private void KimBilirForm_Load(object sender, EventArgs e)
        {
            foreach (Ogrenciler ogrenci in db.Ogrencilers)
            {
                listBox1.Items.Add(ogrenci.Ad + " " + ogrenci.Soyad);
            }
        }
        int sayac =30;
        private void BtnBilirKisi_Click(object sender, EventArgs e)
        {

            if (listBox1.Items.Count > 0)
            {
                int sayi = rnd.Next(0, listBox1.Items.Count);
                string secilenKisi = listBox1.Items[sayi].ToString();

                ListViewItem lv = new ListViewItem();
                if (listBox1.Items.Count > 0)
                {
                    foreach (Ogrenciler ogrencı in db.Ogrencilers)
                    {
                        if (secilenKisi == (ogrencı.Ad + " " + ogrencı.Soyad))
                        {
                            timer1.Start();
                            DialogResult dr = MessageBox.Show(ogrencı.Ad + " " + ogrencı.Soyad+" " +"Soruyu Bildi mi","Soru!!!",MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            int puan = 0;
                            if (dr == DialogResult.Yes)
                            {
                                puan = 5;
                                timer1.Stop();
                                lblSayac.Text = sayac.ToString();
                                lv.Text = ogrencı.Ad;
                                lv.SubItems.Add(ogrencı.Soyad);
                                ogrencı.Puan =puan;
                                lv.SubItems.Add(ogrencı.Puan.ToString());
                                listBox1.Items.Remove(secilenKisi);
                            }
                            else
                            {
                                puan = 0;
                                timer1.Stop();
                                lblSayac.Text = sayac.ToString();
                                lv.Text = ogrencı.Ad;
                                lv.SubItems.Add(ogrencı.Soyad);
                                ogrencı.Puan = puan;
                                lv.SubItems.Add(ogrencı.Puan.ToString());
                                listBox1.Items.Remove(secilenKisi);
                            }

                        }
                    }
                    db.SaveChanges();
                }
                listView1.Items.Add(lv);
            }
            else
            {
                btnBilirKisi.Enabled = false;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int sayac = Convert.ToInt32(lblSayac.Text);
            if (sayac > 0)
            {
                sayac--;
                lblSayac.Text = sayac.ToString();
            }
            else
            {
                timer1.Stop();

            }
        }
    }
}