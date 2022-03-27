using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFBlackJack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random x = new Random();
        int sayac = 0;
        int toplam1 = 0;
        int toplam2 = 0;
        int oyuncuPuan = 0;
        int bilgisaraypuan = 0;
        private void btnSouc_Click(object sender, EventArgs e)
        {
            btnSouc.Enabled = false;
            btnOyna.Enabled = true;
            if (toplam1 > toplam2 && toplam1<=21)
            {
                oyuncuPuan += 10;
                lbl3.Text = oyuncuPuan.ToString();
            }
            if (toplam1 < toplam2 && toplam2 <= 21)
            {
                bilgisaraypuan += 10;
                lbl4.Text = bilgisaraypuan.ToString();
            }
             if (toplam1 == toplam2 && toplam1 <= 21 && toplam2 <= 21)
            {
                oyuncuPuan += 10;
                bilgisaraypuan += 10;
                lbl3.Text = oyuncuPuan.ToString();
                lbl4.Text = bilgisaraypuan.ToString();
            }
            if (toplam1>21 && toplam2<=21 )
            {
                bilgisaraypuan += 10;
                lbl4.Text = bilgisaraypuan.ToString();
            }

            if (toplam2 > 21 && toplam1 <= 21)
            {
                oyuncuPuan += 10;
                lbl3.Text = oyuncuPuan.ToString();
            }

            if (oyuncuPuan==50)
            {
                MessageBox.Show("Tebrikler Oyuncu Kazandı...");
                oyuncuPuan = 0;
                lbl3.Text = oyuncuPuan.ToString();
                bilgisaraypuan = 0;
                lbl4.Text = bilgisaraypuan.ToString();

            }
            if (bilgisaraypuan==50)
            {
                MessageBox.Show("Malesef Bilgisaray Kazandı :((");
                bilgisaraypuan = 0;
                lbl4.Text = bilgisaraypuan.ToString();
                oyuncuPuan = 0;
                lbl3.Text = oyuncuPuan.ToString();
            }

        }
        private void btnKartCek1_Click_1(object sender, EventArgs e)
        {
            sayac++;
            if (sayac == 1)
            {
                int kart1 = x.Next(1, 11);
                int kart2 = x.Next(1, 11);
                label1.Text = kart1.ToString();
                label2.Text = kart2.ToString();
                toplam1 = kart1 + kart2;
                lblToplam1.Text = toplam1.ToString();
            }
            if (sayac == 2)
            {
                int kart3 = x.Next(1, 11);
                label3.Text = kart3.ToString();
                toplam1 += kart3;
                lblToplam1.Text = toplam1.ToString();
            }
            if (sayac == 3)
            {
                int kart4 = x.Next(1, 11);
                label4.Text = kart4.ToString();
                toplam1 += kart4;
                lblToplam1.Text = toplam1.ToString();
            }
            
        }

        private void btnKartCek2_Click_1(object sender, EventArgs e)
        {
            int kart5 = x.Next(1, 11);
            int kart6 = x.Next(1, 11);
            label5.Text = kart5.ToString();
            label6.Text = kart6.ToString();
            toplam2 = kart5 + kart6;
            lblToplam2.Text = toplam2.ToString();

            if (toplam2 < 16)
            {
                int kart7 = x.Next(1, 11);
                label7.Text = kart7.ToString();
                toplam2 += kart7;
                lblToplam2.Text = toplam2.ToString();
            }
            if (toplam2 < 16)
            {
                int kart8 = x.Next(1, 11);
                label8.Text = kart8.ToString();
                toplam2 += kart8;
                lblToplam2.Text = toplam2.ToString();
            }
            
        }

        private void btnOyna_Click(object sender, EventArgs e)
        {
            btnOyna.Enabled = false;
            btnSouc.Enabled = true;
            sayac = 0;
            label1.Text = "0";
            label2.Text = "0";
            label3.Text = "0";
            label4.Text = "0";
            label5.Text = "0";
            label6.Text = "0";
            label7.Text = "0";
            label8.Text = "0";
            lblToplam1.Text = "0";
            lblToplam2.Text = "0";




        }
    }
}
