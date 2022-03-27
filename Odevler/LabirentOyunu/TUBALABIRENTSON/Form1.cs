using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TUBALABIRENTSON
{
    public partial class Frm1Labirent : Form
    {
        int puan = 0;
        int artis =2;

        public Frm1Labirent()
        {
            InitializeComponent();
        }

        private void Frm1Labirent_Load(object sender, EventArgs e)
        {

            MessageBox.Show("Labirent Oyununa Hosgeldiniz...");
            groupBox1.Visible = false;
            lblPuan.Visible = false;
            lblSkor.Visible = false;
            btnBaslat.Visible = false;
            lblOyuncu.Visible = false;
            lblAd_Soyad.Visible = false;

          
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            string ad, soyad;
            ad = txtad.Text;
            soyad = txtSoyad.Text;
            lblAd_Soyad.Text = ad +" " +soyad;
            lblAd.Visible = false;
            lblSoyad.Visible = false;
            btnKaydet.Visible = false;
            txtad.Visible = false;
            txtSoyad.Visible = false;
            btnBaslat.Visible = true;
            lblOyuncu.Visible = true;
            lblAd_Soyad.Visible = true;
            btn1.Visible = true;
            btn2.Visible = true;
            btn3.Visible = true;
            btn4.Visible = true;
            btn5.Visible = true;
            btn6.Visible = true;
            btn7.Visible = true;
            btn8.Visible = true;
            btnBonus.Visible = true;


        }

        private void lbl1_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Kaybettiniz,Yeniden Deneyiniz...");

            lblAd_Soyad.Text = "";
            lblSkor.Text = "";
            txtad.Text = "";
            txtSoyad.Text = "";
            groupBox1.Visible = false;
            btnBaslat.Visible = false;
            lblSkor.Visible = false;
            lblPuan.Visible = false;
            lblOyuncu.Visible = false;
            lblAd_Soyad.Visible = false;
            lblAd.Visible = true;
            lblSoyad.Visible = true;
            txtad.Visible = true;
            txtSoyad.Visible = true;
            btnKaydet.Visible = true;

        }

        private void btn1_MouseHover(object sender, EventArgs e)
        {
            puan += artis;
            lblSkor.Text = puan.ToString();
            btn1.Visible = false;

        }

        private void btn2_MouseHover(object sender, EventArgs e)
        {
            puan += artis;
            lblSkor.Text = puan.ToString();
            btn2.Visible = false;
        }

        private void btn3_MouseHover(object sender, EventArgs e)
        {
            puan += artis;
            lblSkor.Text = puan.ToString();
            btn3.Visible = false;
        }

        private void btn4_MouseHover(object sender, EventArgs e)
        {
            puan += artis;
            lblSkor.Text = puan.ToString();
            btn4.Visible = false;
        }

        private void btn5_MouseHover(object sender, EventArgs e)
        {
            puan += artis;
            lblSkor.Text = puan.ToString();
            btn5.Visible = false;
        }

        private void btn6_MouseHover(object sender, EventArgs e)
        {
            puan += artis;
            lblSkor.Text = puan.ToString();
            btn6.Visible = false;
        }

        private void btn7_MouseHover(object sender, EventArgs e)
        {
            puan += artis;
            lblSkor.Text = puan.ToString();
            btn7.Visible = false;
        }

        private void btn8_MouseHover(object sender, EventArgs e)
        {
            puan += artis;
            lblSkor.Text = puan.ToString();
            btn8.Visible = false;
        }

        private void btnBonus_MouseHover(object sender, EventArgs e)
        {
            puan += 10;
            lblSkor.Text = puan.ToString();
            btnBonus.Visible = false;
        }

        private void btnfinish_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Tebrikler Kazandınız....");
            lblAd_Soyad.Text = "";
            lblSkor.Text = "";
            txtad.Text = "";
            txtSoyad.Text = "";
            groupBox1.Visible = false;
            btnBaslat.Visible = false;
            lblSkor.Visible = false;
            lblPuan.Visible = false;
            lblOyuncu.Visible = false;
            lblAd_Soyad.Visible = false;
            lblAd.Visible = true;
            lblSoyad.Visible = true;
            txtad.Visible = true;
            txtSoyad.Visible = true;
            btnKaydet.Visible = true;
            



        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            lblPuan.Visible = true;
            lblSkor.Visible = true;

        }

     
    }
}
