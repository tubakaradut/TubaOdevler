using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_BakiyeIslemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        decimal bakiye = 500;
        decimal cekilen;
        decimal yatirilan;
        decimal ekmekFiyat = 4;
        decimal yumurtaFiyat = 20;
        decimal cayFiyat = 35;
        decimal cikolataFiyat = 30;
        decimal peynirFiyat = 45;

        private void Form1_Load(object sender, EventArgs e)
        {
            lblBakiye.Text = "500 TL";
        }
        private void btnParaCek_Click(object sender, EventArgs e)
        {
            cekilen = nudParaCek.Value;

            if (cekilen == 0)
            {
                MessageBox.Show("0 tutarında para çekilme sağlanamaz");
            }
            else if (bakiye > 0 && bakiye >= cekilen)
            {
                bakiye -= cekilen;
                lblBakiye.Text = bakiye.ToString() + " TL";
                listBox1.Items.Add("Çekilen Tutar:" + cekilen + " TL ," + "Bakiyeniz: " + bakiye + " TL");

                if (bakiye <= 0)
                {
                    btnParaCek.Enabled = false;
                }
            }
            else if (cekilen > bakiye && bakiye > 0)
            { MessageBox.Show("Bakiyeniz Yetersizdir."); }
        }

        private void btnParaYatir_Click(object sender, EventArgs e)
        {
            yatirilan = nudParaYatir.Value;

            if (yatirilan >= 1)
            {
                bakiye += yatirilan;
                lblBakiye.Text = bakiye.ToString() + " TL";
                btnParaCek.Enabled = true;
                listBox1.Items.Add("Yatırılan Tutar: " + yatirilan + " Bakiye: " + bakiye + " TL");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            decimal ekmekTutar = nudEkmek.Value * ekmekFiyat;
            decimal peynirTutar = nudPeynir.Value * peynirFiyat;
            decimal cayTutar = nudCay.Value * cayFiyat;
            decimal cikolataTutar = nudCikolata.Value * cikolataFiyat;
            decimal yumurtaTutar = nudYumurta.Value * yumurtaFiyat;
            decimal alisverisTutar = 0;
            string liste = "";

            if (chcEkmek.Checked && nudEkmek.Value >= 1)
            {
                if (bakiye >= ekmekTutar && bakiye > 0)
                {
                    bakiye -= ekmekTutar;
                    lblBakiye.Text = bakiye.ToString() + " TL";
                    alisverisTutar += ekmekTutar;
                    if (liste.Length > 0)
                    {
                        liste = chcEkmek.Text + " + " + liste;
                    }
                    else
                    {
                        liste = chcEkmek.Text;
                    }
                }
                else if (ekmekTutar >= bakiye)
                { MessageBox.Show("Bakiyeniz Yetersizdir"); }

            }
            if (chcCay.Checked && nudCay.Value >= 1)
            {
                if (bakiye >= cayTutar && bakiye > 0)
                {
                    bakiye -= cayTutar;
                    lblBakiye.Text = bakiye.ToString() + " TL";
                    alisverisTutar += cayTutar;
                    if (liste.Length > 0)
                    {
                        liste = chcCay.Text + " + " + liste;
                    }
                    else
                    {
                        liste = chcCay.Text;
                    }
                }
                else if (cayTutar > bakiye)
                { MessageBox.Show("Bakiyeniz Yetersizdir"); }
            }
            if (chcYumurta.Checked && nudYumurta.Value >= 1)
            {
                if (bakiye >= yumurtaTutar && bakiye > 0)
                {
                    bakiye -= yumurtaTutar;
                    lblBakiye.Text = bakiye.ToString() + " TL";
                    alisverisTutar += yumurtaTutar;
                    if (liste.Length > 0)
                    {
                        liste = chcYumurta.Text + " + " + liste;
                    }
                    else
                    {
                        liste = chcYumurta.Text;
                    }
                }
                else if (yumurtaTutar > bakiye)
                { MessageBox.Show("Bakiyeniz Yetersizdir"); }
            }
            if (chcPeynir.Checked && nudPeynir.Value >= 1)
            {
                if (bakiye >= peynirTutar && bakiye > 0)
                {
                    bakiye -= peynirTutar;
                    lblBakiye.Text = bakiye.ToString() + " TL";
                    alisverisTutar += peynirTutar;
                    if (liste.Length > 0)
                    {
                        liste = chcPeynir.Text + " + " + liste;
                    }
                    else
                    {
                        liste = chcPeynir.Text;
                    }
                }
                else if (peynirTutar > bakiye)
                { MessageBox.Show("Bakiyeniz Yetersizdir"); }
            }
            if (chcCikolata.Checked && nudCikolata.Value >= 1)
            {
                if (bakiye >= cikolataTutar && bakiye > 0)
                {
                    bakiye -= cikolataTutar;
                    lblBakiye.Text = bakiye.ToString() + " TL";
                    alisverisTutar += cikolataTutar;
                    if (liste.Length > 0)
                    {
                        liste = chcCikolata.Text + " + " + liste;
                    }
                    else
                    {
                        liste = chcCikolata.Text;
                    }
                }
                else if (cikolataTutar > bakiye)
                { MessageBox.Show("Bakiyeniz Yetersizdir"); }
            }

            if (alisverisTutar > 0)
            {
                listBox1.Items.Add("Toplam Alışveriş Tutarı : " + alisverisTutar + " TL");
                listBox2.Items.Add(liste + " => " + alisverisTutar + " TL");
            }

        }
    }
}





