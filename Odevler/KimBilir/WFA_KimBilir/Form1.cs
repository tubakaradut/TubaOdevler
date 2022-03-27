using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_KimBilir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] ogrenciAdlari = { "EDEBALİ MERT", "AZAD", "SILA", "UMUT", "SARUHAN MERT", "ONUR", "EMRE", "ENES", "FURKAN SEMİH", "KAAN", "BAHADIR", "MERT", "BURAK", "AHMET CANER", "TUBA" };
        string[] ogrenciSoyadlari = { "ATALAY", "MAJIDLI", "ŞİRİN", "YILBAŞ", "DEMİRAY", "DOĞRU", "BEKTAŞOĞLU", "SERENLİ", "GÜNEŞ", "ÜNAL", "ARDA", "ÇINAR", "UYSAL", "TATLI", "KARADUT BUĞDAY" };

        Random rnd = new Random();
        int sayi;
        string format;
        int sayac = 30;

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < ogrenciAdlari.Length; i++)
            {
                string ad = ogrenciAdlari[i];
                string soyad = ogrenciSoyadlari[i];

                format = string.Format("{0} {1}", ad, soyad);
                listBox1.Items.Add(format);
            }
        }

        private void btnBilirKisi_Click(object sender, EventArgs e)
        {

            sayi = rnd.Next(0, listBox1.Items.Count);
            ListViewItem lvi = new ListViewItem();

            if (listBox1.Items.Count > 0)
            {
                string secilenKisi = listBox1.Items[sayi].ToString();

                for (int i = 0; i < ogrenciAdlari.Length; i++)
                {
                    format = string.Format("{0} {1}", ogrenciAdlari[i], ogrenciSoyadlari[i]);

                    if (secilenKisi == format)
                    {
                        timer1.Start();
                        DialogResult dr = MessageBox.Show(format, "Sanslı sayi Soruyu Bildi mi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        int puan = 0;
                        if (dr == DialogResult.Yes)
                        {
                            puan = 5;
                            timer1.Stop();
                            lblSayac.Text = sayac.ToString();
                        }
                        else
                        {
                            puan = 0;
                            timer1.Stop();
                            lblSayac.Text = sayac.ToString();
                        }

                        lvi.Text = ogrenciAdlari[i];
                        lvi.SubItems.Add(ogrenciSoyadlari[i]);
                        lvi.SubItems.Add(puan.ToString());
                        listView1.Items.Add(lvi);
                        listBox1.Items.RemoveAt(sayi);
                        break;
                    }

                }

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
