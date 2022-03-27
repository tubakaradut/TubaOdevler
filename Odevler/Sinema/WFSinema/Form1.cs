using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFSinema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int seans1 = 0;
        int ucret1 = 0;
        int seans2 = 0;
        int ucret2 = 0;
        int seans3 = 0;
        int ucret3 = 0;
        int misir = 0;
        int misirFiyat = 0;
        int kola = 0;
        int kolaFiyat = 0;
        int su = 0;
        int suFiyat = 0;


        private void btnArti1_Click(object sender, EventArgs e)
        {
            seans1++;
            ucret1 = ucret1 + 25;
            if (seans1 >= 0 && seans1 <= 20)
            {
               
                textBox1.Text = seans1.ToString();
                textBox2.Text = ucret1.ToString();
            }
          
        }

        private void btnEksi1_Click(object sender, EventArgs e)
        {
            seans1--;
            ucret1 = ucret1 - 25;
            if (seans1 >= 0 && seans1 <= 20)
            {
               
                textBox1.Text = seans1.ToString();
                textBox2.Text = ucret1.ToString();
            }

           

        }

        private void btnArti2_Click(object sender, EventArgs e)
        {
            seans2++;
            ucret2 = ucret2 + 25;
            if (seans2 >= 0 && seans2 <= 20)
            {

                textBox3.Text = seans2.ToString();
                textBox4.Text = ucret2.ToString();
            }
        }

        private void btnEksi2_Click(object sender, EventArgs e)
        {
            seans2--;
            ucret2 = ucret2 - 25;
            if (seans2 >= 0 && seans2 <= 20)
            {

                textBox3.Text = seans2.ToString();
                textBox4.Text = ucret2.ToString();
            }
        }

        private void btnArti3_Click(object sender, EventArgs e)
        {
            seans3++;
            ucret3 = ucret3 + 25;
            if (seans3 >= 0 && seans3 <= 20)
            {

                textBox5.Text = seans3.ToString();
                textBox6.Text = ucret3.ToString();
            }
        }

        private void btnEksi3_Click(object sender, EventArgs e)
        {
            seans3--;
            ucret3 = ucret3 - 25;
            if (seans3 >= 0 && seans3 <= 20)
            {

                textBox5.Text = seans3.ToString();
                textBox6.Text = ucret3.ToString();
            }
        }

        private void btnMartı_Click(object sender, EventArgs e)
        {
            misir++;
            misirFiyat = misirFiyat + 20;
            if (misir>=0)
            {
                txtMısır.Text = misir.ToString();
                txtMısır2.Text = misirFiyat.ToString();

            }
        }

        private void btnMeksi_Click(object sender, EventArgs e)
        {
            misir--;
            misirFiyat = misirFiyat - 20;
            if (misir >= 0)
            {
                txtMısır.Text = misir.ToString();
                txtMısır2.Text = misirFiyat.ToString();

            }
        }

        private void btnKartı_Click(object sender, EventArgs e)
        {
            kola++;
            kolaFiyat = kolaFiyat + 15;
            if (kola>= 0)
            {
                txtKola.Text = kola.ToString();
                txtKola2.Text = kolaFiyat.ToString();

            }
        }

        private void btnKeksi_Click(object sender, EventArgs e)
        {
            kola--;
            kolaFiyat = kolaFiyat - 15;
            if (kola >= 0)
            {
                txtKola.Text = kola.ToString();
                txtKola2.Text = kolaFiyat.ToString();

            }
        }

        private void btnSarti_Click(object sender, EventArgs e)
        {
            su ++;
            suFiyat = suFiyat + 5;
            if (su>=0)
            {
                txtSu.Text = su.ToString();
                txtSu2.Text = suFiyat.ToString();

            }
        }

        private void btnHesapBilet_Click(object sender, EventArgs e)
        {
            txtToplam.Text = (seans1 + seans2 + seans3).ToString();
            txtToplam2.Text = (ucret1 + ucret2 + ucret3).ToString();
            textBox1.Text = "";
            textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = ""; textBox4.Text = ""; textBox5.Text = ""; textBox6.Text = "";

        }

        private void btnBüfeHesap_Click(object sender, EventArgs e)
        {
            txtToplam3.Text = (misir + kola + su).ToString();
            txtToplam4.Text = (misirFiyat + kolaFiyat + suFiyat).ToString();
            txtMısır.Text = ""; txtMısır2.Text = ""; txtKola.Text = ""; txtKola2.Text = ""; txtSu.Text = ""; txtSu2.Text = "";
        }
    }
    
}
