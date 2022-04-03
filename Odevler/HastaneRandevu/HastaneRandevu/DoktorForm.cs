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
    public partial class DoktorForm : Form
    {
        public DoktorForm()
        {
            InitializeComponent();
        }
       
        private void DoktorForm_Load(object sender, EventArgs e)
        {
            foreach (Brans brans in Brans.BransListesi)
            {
                    cmbBrans.Items.Add(brans);    
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Doktor dr = new Doktor();
            dr.DoktorAdSoyad = txtDoktorAd.Text;
            dr.brans = (Brans)cmbBrans.SelectedItem;
            Doktor.DoktorListesi.Add(dr);

            cmbBrans.Text = "";
            txtDoktorAd.Text = "";

            //lstDoktorlistesi.Items.Add(dr.DoktorAdSoyad+" "+dr.brans);

        }

        private void BtnOnceki_Click(object sender, EventArgs e)
        {
            BransForm brf = new BransForm();
            brf.Show();
            this.Hide();
        }

        private void btnSonraki2_Click(object sender, EventArgs e)
        {
            LoginForm lg = new LoginForm();
            lg.Show();
            this.Hide();

        }
    }
}
