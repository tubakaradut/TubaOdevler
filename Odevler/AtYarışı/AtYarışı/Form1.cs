using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtYarışı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int sayi;
        int At2Yatirilan = 0;
        int At3Yatirilan = 0;
        int At1Yatirilan = 0;
        int toplamPuan = 500;


        private void Form1_Load(object sender, EventArgs e)
        {
            sayi = rnd.Next(1, 4);
            this.Text = sayi.ToString();
            if (sayi == 1)
            {
                this.BackColor = Color.Brown;
            }
            else if (sayi == 2)
            {
                this.BackColor = Color.Green;
            }
            else if (sayi == 3)
            {
                this.BackColor = Color.Gray;
            }
            btnBaslat.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button3.Enabled = false;
            if (Convert.ToInt32(nAt1.Value) <= toplamPuan)
            {
                At1Yatirilan = Convert.ToInt32(nAt1.Value);
                lblOrtaB.Text = At1Yatirilan.ToString();
                toplamPuan -= At1Yatirilan;
                lbtToplam.Text = toplamPuan.ToString();
                btnBaslat.Enabled = true;
                button1.Enabled = false;
                nAt1.Value = 0;
            }
            else
            {
                MessageBox.Show("Bakiyeniz yetersizdir. Lütfen bakiyeniz kadar yatırma işlemi yapın! :(");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button3.Enabled = false;
            if (Convert.ToInt32(nAt2.Value) <= toplamPuan)
            {
                At2Yatirilan = Convert.ToInt32(nAt2.Value);
                lblOrtaB.Text = At2Yatirilan.ToString();
                toplamPuan -= Convert.ToInt32(At2Yatirilan);
                lbtToplam.Text = toplamPuan.ToString();
                btnBaslat.Enabled = true;
                button2.Enabled = false;
                nAt2.Value = 0;
            }
            else
            {
                MessageBox.Show("Bakiyeniz yetersizdir. Lütfen bakiyeniz kadar yatırma işlemi yapın! :(");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            if (Convert.ToInt32(nAt2.Value) <= toplamPuan)
            {
                At3Yatirilan = (int)nAt3.Value;
                lblOrtaB.Text = At3Yatirilan.ToString();
                toplamPuan -= Convert.ToInt32(At3Yatirilan);
                lbtToplam.Text = toplamPuan.ToString();
                btnBaslat.Enabled = true;
                button3.Enabled = false;
                nAt3.Value = 0;
            }
            else
            {
                MessageBox.Show("Bakiyeniz yetersizdir. Lütfen bakiyeniz kadar yatırma işlemi yapın! :(");
            }
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            timer1.Start();

            if (sayi == 0)
            {
                sayi = rnd.Next(1, 4);
            }

            if (sayi == 1)
            {
                this.BackColor = Color.Brown;
            }
            else if (sayi == 2)
            {
                this.BackColor = Color.Green;
            }
            else if (sayi == 3)
            {
                this.BackColor = Color.Gray;
            }
            this.Text = sayi.ToString();
            btnBaslat.Enabled = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sayi == 1)
            {
                pbAt1.Left += rnd.Next(10, 30);
                pbAt2.Left += rnd.Next(1, 30);
                pbAt3.Left += rnd.Next(1, 30);

            }
            else if (sayi == 2)
            {
                pbAt2.Left += rnd.Next(10, 30);
                pbAt1.Left += rnd.Next(1, 30);
                pbAt3.Left += rnd.Next(1, 30);

            }
            else if (sayi == 3)
            {
                pbAt3.Left += rnd.Next(10, 30);
                pbAt2.Left += rnd.Next(1, 30);
                pbAt1.Left += rnd.Next(1, 30);

            }

            if (pbAt1.Right >= lblFinish.Left)
            {
                timer1.Stop();
                toplamPuan += (int)(At1Yatirilan * 1.50);
                lbtToplam.Text = toplamPuan.ToString();
                lblSpiker.Text = "1. At kazandı.";
                lblsonuc.Text = "1. At kazandı. Bakiyeniz : " + toplamPuan.ToString();
                DialogResult dr = MessageBox.Show("1. at kazandı!\nTekrar Oynamak İster misin? :))", "Oyun bitti", MessageBoxButtons.YesNo, MessageBoxIcon.Information);


                lblOrtaB.Text = "";

                if (dr == DialogResult.Yes)
                {
                    pbAt1.Left = 12;
                    pbAt2.Left = 12;
                    pbAt3.Left = 12;
                    sayi = 0;
                    this.BackColor = Color.White;
                    lblSpiker.Text = "";
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button1.Enabled = true;
                    lblsonuc.Text = "";


                }
                else
                {
                    MessageBox.Show("Katıldığınız için Tşk Ederiz...");
                    Application.Exit();
                }

            }
            else if (pbAt2.Right >= lblFinish.Left)
            {
                timer1.Stop();
                toplamPuan += Convert.ToInt32((At2Yatirilan * 1.30));
                lbtToplam.Text = toplamPuan.ToString();
                lblSpiker.Text = "2. At kazandı.";
                lblsonuc.Text = "2. At kazandı. Bakiyeniz : " + toplamPuan.ToString();
                DialogResult dr = MessageBox.Show("2. at kazandı!\nTekrar Oynamak İster misin? :))", "Oyun bitti", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                lblOrtaB.Text = "";
                if (dr == DialogResult.Yes)
                {
                    pbAt1.Left = 12;
                    pbAt2.Left = 12;
                    pbAt3.Left = 12;
                    sayi = 0;
                    this.BackColor = Color.White;
                    lblSpiker.Text = "";
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button1.Enabled = true;
                    lblsonuc.Text = "";

                }
                else
                {
                    MessageBox.Show("Katıldığınız için Tşk Ederiz...");
                    Application.Exit();
                }
            }
            else if (pbAt3.Right >= lblFinish.Left)
            {
                timer1.Stop();
                toplamPuan += (int)(At3Yatirilan * 1.80);
                lbtToplam.Text = toplamPuan.ToString();
                lblSpiker.Text = "3. At kazandı.";
                lblsonuc.Text = "3. At kazandıgı için kazancınız : " + toplamPuan.ToString();
                DialogResult dr = MessageBox.Show("3. at kazandı!\nTekrar Oynamak İster misin? :))", "Oyun bitti", MessageBoxButtons.YesNo, MessageBoxIcon.Information);


                lblOrtaB.Text = "";

                if (dr == DialogResult.Yes)
                {
                    pbAt1.Left = 12;
                    pbAt2.Left = 12;
                    pbAt3.Left = 12;
                    sayi = 0;
                    this.BackColor = Color.White;
                    lblSpiker.Text = "";
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button1.Enabled = true;
                    lblsonuc.Text = "";

                }
                else
                {
                    MessageBox.Show("Katıldığınız için Tşk Ederiz...");
                    Application.Exit();
                }
            }
            if (pbAt1.Right > pbAt2.Right && pbAt1.Right > pbAt3.Right)
            {
                lblSpiker.Text = "1. at önde gidiyor...";
            }
            else if (pbAt2.Right > pbAt1.Right && pbAt2.Right > pbAt3.Right)
            {
                lblSpiker.Text = "2. at önde gidiyor...";
            }
            else if (pbAt3.Right > pbAt1.Right && pbAt3.Right > pbAt2.Right)
            {
                lblSpiker.Text = "3. at önde gidiyor";
            }
        }
    }
}
