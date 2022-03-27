using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_TahminEt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayi;
        int tahminHakki = 5;
        int seviye = 1;
        Random rnd = new Random();
        int oyunSayisi = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            sayi = rnd.Next(1, 11);
            lblSayi.Text = sayi.ToString();
            btnTahminEt.Enabled = false;
            textBox1.Enabled = false;

        }

        private void btnTahminEt_Click(object sender, EventArgs e)
        {
            int tahmin = int.Parse(textBox1.Text);
            seviye = int.Parse(lblSeviye.Text);
            string aciklama = "";
            tahminHakki--;

            if (tahminHakki > 0)
            {
                if (sayi > tahmin)
                {
                    lblDurum.Text = "Tahmin sayınızı artırın...";
                    lblTahminHakkı.Text = tahminHakki.ToString();
                    aciklama = oyunSayisi + ". Oyun => " + " Tahmin Edilen Sayı: " + tahmin + " , Seviye: " + seviye;
                    listBox1.Items.Add(aciklama);
                }
                else if (sayi < tahmin)
                {
                    lblDurum.Text = "Tahmin sayınızı azaltın";
                    lblTahminHakkı.Text = tahminHakki.ToString();
                    aciklama = oyunSayisi + ". Oyun => " +  " Tahmin Edilen Sayı: " + tahmin + " , Seviye: " + seviye;
                    listBox1.Items.Add(aciklama);
                }
                else if (sayi == tahmin)
                {
                    lblDurum.Text = "Tebrikler Bildiniz ve Üst seviyeye Çıktınız";
                    aciklama = oyunSayisi + ". Oyun => " + " Tutulan Sayı: " + sayi + " ,  Tahmin Edilen Sayı: " +tahmin+"  "+ lblDurum.Text+ " , Seviye: " + seviye;
                    listBox1.Items.Add(aciklama);
                    textBox1.Text = "";
                    tahminHakki = 5;
                    lblTahminHakkı.Text = tahminHakki.ToString();
                    seviye++;
                    sayi = rnd.Next(1, (seviye * 10+1));
                    lblSayi.Text = sayi.ToString();
                    lblSeviye.Text = seviye.ToString();
                }
            } else if(tahminHakki==0)
            {
                lblDurum.Text = "Tahmin Hakkınız Kalmamıştır.";
                lblTahminHakkı.Text = tahminHakki.ToString();
                aciklama = oyunSayisi+". Oyun => "+" Tutulan Sayı: " + sayi + " Tahmin Edilen Sayı: " +tahmin+ " , Seviye: " + seviye +"  "+ lblDurum.Text;
                listBox1.Items.Add(aciklama);
                textBox1.Text = "";
                btnTahminEt.Enabled = false;
                textBox1.Enabled = false;
                btnBaslat.Enabled = true;
            }
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            btnTahminEt.Enabled = true;
            textBox1.Enabled = true;
            seviye = 1;
            lblSeviye.Text = seviye.ToString();
            sayi = rnd.Next(1, (seviye * 10+1));
            lblSayi.Text = sayi.ToString();
            lblSeviye.Text = seviye.ToString();
            tahminHakki = 5;
            lblTahminHakkı.Text = tahminHakki.ToString();
            btnBaslat.Enabled = false;
            oyunSayisi++;
        }
    }
}
