using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneRandevu
{
    public partial class RandevuSaatiFormu : Form
    {
        public RandevuSaatiFormu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RandevuForm r = new RandevuForm();
            r.Show();
            this.Hide();

        }

        private void RandevuSaatiFormu_Load(object sender, EventArgs e)
        {
            double sayi = 0;

            for (int i = 9; i < 13; i++)
            {
                for (int j = 9; j < 13; j++)
                {

                    Button btn = new Button();
                    btn.Width = 90;
                    btn.Height = 23;
                    btn.Top = 23 * j;
                    btn.Left = 90 * i;
                    btn.Text = string.Format($"{i}  : {sayi.ToString("00")}");
                    btn.Name = btn.Text;
                    flowLayoutPanel1.Controls.Add(btn);
                    sayi = sayi + 15;
                    btn.Click += Btn_Click;

                    foreach (Randevu randevu in Randevu.RandevuListesi)
                    {
                        if (randevu.RandevuSaati == btn.Text)
                        {
                            btn.Enabled = false;
                            btn.BackColor = Color.Red;
                        }
                    }
                }

                sayi = 0;
            }


        }
        private void Btn_Click(object sender, EventArgs e)
        {

            string bilgi = Randevu.Bilgi;

            Button btn = (Button)sender;

            DialogResult dr = MessageBox.Show(bilgi + btn.Name + " saatine randevu olusturuldu.Randevuyu onaylıyor musunuz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                MessageBox.Show("Randevunuz Olusturulmustur. Sağlıklı Günler Dileriz...");
                btn.BackColor = Color.Red;
                btn.Enabled = false;

                Randevu randevu = Randevu.RandevuListesi.LastOrDefault();
                randevu.RandevuSaati = btn.Text;

                LoginForm lg = new LoginForm();
                lg.Show();
                this.Hide();

            }
            else
            {
                this.Show();
            }

        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            LoginForm lg = new LoginForm();
            lg.Show();
            this.Hide();
        }
    }
}
