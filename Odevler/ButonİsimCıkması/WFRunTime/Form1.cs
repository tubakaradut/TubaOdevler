using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFRunTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string[] ogrenciAdlari = { "AZAD", "SILA", "UMUT", "SARUHAN MERT", "ONUR", "Emre", "ENES", "FURKAN SEMİH", "KAAN", "BAHADIR", "MERT", "BURAK", "AHMET CANER", "TUBA", "MAHMURE", "ARYA", "BERK", "FATİH" };
            string[] isimler = new string[18];
            int dikey = 0;
            int yatay = 0;
            int a = 0;
            int sayi = 0;
            Button btn = new Button();
            for (int i = 1; i < 4; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    btn = new Button();
                   
                    int rastgele = rnd.Next(0, 18);

                  
                    if (isimler.Contains(rastgele.ToString())) 
                    {
                        j--;
                        continue;
                    }
                    else
                    {
                        isimler[a] = rastgele.ToString();
                        a++;

                        btn.Name = ogrenciAdlari[rastgele];
                    }
                    sayi++;
                    btn.Text = sayi.ToString();
                    btn.Width = 80;
                    btn.Height = 40;
                    btn.Left += yatay;
                    yatay = yatay + 80;
                    btn.Top += dikey;
                    this.Controls.Add(btn);
                    btn.Click += Btn_Click;


                }
                dikey = dikey + 40;
                yatay = 0;

            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            MessageBox.Show(btn.Name);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int yatay = 0;
            int dikey = 0;
            Button btn1 = new Button();
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    btn1 = new Button();
                    btn1.Text = i+" x "+j;
                    btn1.Width = 50;
                    btn1.Height = 30;
                    btn1.Left += yatay;
                    yatay = yatay + 50;
                    btn1.Top += dikey;
                    this.Controls.Add(btn1);

                    if (i%2==0)
                    {
                        btn1.BackColor = Color.Red;
                    }
                    else
                    {
                        btn1.BackColor = Color.Yellow;
                    }

                }
                dikey = dikey + 30;
                yatay = 0;
            }

            this.Width = (btn1.Width * 10) + 20;
            this.Height = button2.Bottom + 50;


        }
    }
}
