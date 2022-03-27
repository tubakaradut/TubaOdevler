using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Barbut
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random x = new Random();
        int zar1;
        int zar2;
        decimal paraYatir1;
        decimal paraYatir2;
        decimal bakiye1 = 500;
        decimal bakiye2 = 500;
        decimal orta = 0;
        string aciklama = "";
        int oyunSayisi = 0;


        private void btnZar1_Click(object sender, EventArgs e)
        {
            oyunSayisi++;
            zar1 = x.Next(1, 7);
            lblZar1.Text = zar1.ToString();
            btnZar1.Enabled = false;
            btnZar2.Enabled = true;
            aciklama = oyunSayisi.ToString() + ". oyun => 1.Oyuncu " + zar1.ToString() + " attı.";
            lstOyuncu1.Items.Add(aciklama);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnZar1.Enabled = false;
            btnZar2.Enabled = false;
            groupBox4.Enabled = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            paraYatir1 = numericUpDown3.Value;
            bakiye1 -= paraYatir1;
            orta += paraYatir1;
            lblOrta.Text = orta.ToString();
            lblBakiye1.Text = bakiye1.ToString();
            groupBox4.Enabled = true;
            groupBox3.Enabled = false;
            lstOyuncu1.Items.Add("1.Oyuncu " + paraYatir1 + " puan yatırdı.");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            paraYatir2 = numericUpDown4.Value;
            bakiye2 -= paraYatir2;
            orta += paraYatir2;
            lblBakiye2.Text = bakiye2.ToString();
            lblOrta.Text = orta.ToString();
            btnZar1.Enabled = true;
            groupBox4.Enabled = false;
            lstOyuncu2.Items.Add("2.Oyuncu " + paraYatir2 + " puan yatırdı.");
        }

        private void btnZar2_Click(object sender, EventArgs e)
        {
            zar2 = x.Next(1, 7);
            lblZar2.Text = zar2.ToString();
            btnZar2.Enabled = false;
            groupBox4.Enabled = false;
            groupBox3.Enabled = true;

            string oyuncu2Aciklama = oyunSayisi.ToString() + ". oyun => 2.Oyuncu " + zar2.ToString() + " attı.";

            lstOyuncu2.Items.Add(oyuncu2Aciklama);

            aciklama += "2.Oyuncu " + zar2.ToString() + " attı.";

            if (zar1 > zar2)
            {
                bakiye1 += orta;
                lblBakiye1.Text = bakiye1.ToString();
                orta = 0;
                lblOrta.Text = orta.ToString();
                lblSonuc.Text = "Oyuncu 1 kazandı.";
                aciklama += "Sonuç : " + lblSonuc.Text;
            }
            else if (zar1 < zar2)
            {
                bakiye2 += orta;
                lblBakiye2.Text = bakiye2.ToString();
                orta = 0;
                lblOrta.Text = orta.ToString();
                lblSonuc.Text = "Oyuncu 2 kazandı";
                aciklama += "Sonuç : " + lblSonuc.Text;
            }
            else
            {
                lblSonuc.Text = "Berabere kaldınız";
                btnZar1.Enabled = true;
                groupBox3.Enabled = false;
                aciklama += "Sonuç : " + lblSonuc.Text;
            }

            listBox1.Items.Add(aciklama);

        }
    }
}
