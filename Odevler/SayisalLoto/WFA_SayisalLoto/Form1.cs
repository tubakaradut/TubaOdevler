using System;
using System.Windows.Forms;

namespace WFA_SayisalLoto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();


        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is ListBox)
                {
                    ListBox lst = (ListBox)ctrl;

                    int sayac = 0;
                    
                    while (sayac < 6)
                    {
                        int sayı = rnd.Next(1, 50);
                        if (!lst.Items.Contains(sayı))
                        {
                            lst.Items.Add(sayı);
                            sayac++;
                        }
                    }

                }
            }


            //for (int i = 0; i < tahmin1.Length; i++)
            //{
            //    int rastgeleSayi = rnd.Next(1, 50);
            //    if (listBox1.Items.Contains(rastgeleSayi))
            //    {
            //        i--;

            //    }
            //    else
            //    {
            //        listBox1.Items.Add(rastgeleSayi);
            //        tahmin1[i] = rastgeleSayi;
            //    }
            //}
            //for (int i = 0; i < 6; i++)
            //{
            //    int rastgeleSayi = rnd.Next(1, 50);
            //    if (listBox2.Items.Contains(rastgeleSayi))
            //    {
            //        i--;

            //    }
            //    else
            //    {
            //        listBox2.Items.Add(rastgeleSayi);
            //        tahmin2[i] = rastgeleSayi;
            //    }
            //}

            //for (int i = 0; i < 6; i++)
            //{
            //    int rastgeleSayi = rnd.Next(1, 50);
            //    if (listBox3.Items.Contains(rastgeleSayi))
            //    {
            //        i--;

            //    }
            //    else
            //    {
            //        listBox3.Items.Add(rastgeleSayi);
            //        tahmin3[i] = rastgeleSayi;
            //    }
            //}
            //for (int i = 0; i < 6; i++)
            //{
            //    int rastgeleSayi = rnd.Next(1, 50);
            //    if (listBox4.Items.Contains(rastgeleSayi))
            //    {
            //        i--;

            //    }
            //    else
            //    {
            //        listBox4.Items.Add(rastgeleSayi);
            //        tahmin4[i] = rastgeleSayi;
            //    }
            //}
            //for (int i = 0; i < 6; i++)
            //{
            //    int rastgeleSayi = rnd.Next(1, 50);
            //    if (listBox5.Items.Contains(rastgeleSayi))
            //    {
            //        i--;

            //    }
            //    else
            //    {
            //        listBox5.Items.Add(rastgeleSayi);
            //        tahmin5[i] = rastgeleSayi;
            //    }
            //}
            //for (int i = 0; i < 6; i++)
            //{
            //    int rastgeleSayi = rnd.Next(1, 50);
            //    if (listBox6.Items.Contains(rastgeleSayi))
            //    {
            //        i--;

            //    }
            //    else
            //    {
            //        listBox6.Items.Add(rastgeleSayi);
            //        tahmin6[i] = rastgeleSayi;
            //    }
            //}

            //for (int i = 0; i < 6; i++)
            //{
            //    int rastgeleSayi = rnd.Next(1, 50);
            //    if (listBox7.Items.Contains(rastgeleSayi))
            //    {
            //        i--;

            //    }
            //    else
            //    {
            //        listBox7.Items.Add(rastgeleSayi);
            //        tahmin7[i] = rastgeleSayi;
            //    }
            //}
            //for (int i = 0; i < 6; i++)
            //{
            //    int rastgeleSayi = rnd.Next(1, 50);
            //    if (listBox8.Items.Contains(rastgeleSayi))
            //    {
            //        i--;

            //    }
            //    else
            //    {
            //        listBox8.Items.Add(rastgeleSayi);
            //        tahmin8[i] = rastgeleSayi;

            //    }
            //}
        }

        private void btnSecim_Click(object sender, EventArgs e)
        {
            //foreach (Control ctrl in this.Controls)
            //{
            //    if (ctrl is RichTextBox)
            //    {
            //       RichTextBox rch = (RichTextBox)ctrl;
            //        rch.Clear();
            //    }
            //}

            //for (int i = 0; i < sayi.Length; i++)
            //{
            //    int secim = rnd.Next(1, 50);

            //    if (Array.IndexOf(sayi, secim) == -1)
            //    {
            //        sayi[i] = secim;

            //    }
            //    else
            //    {
            //        i--;

            //    }

            //    richTextBox1.Text = sayi[0].ToString();
            //    richTextBox2.Text = sayi[1].ToString();
            //    richTextBox3.Text = sayi[2].ToString();
            //    richTextBox4.Text = sayi[3].ToString();
            //    richTextBox5.Text = sayi[4].ToString();
            //    richTextBox6.Text = sayi[5].ToString();

        }


    }

   
    }


















