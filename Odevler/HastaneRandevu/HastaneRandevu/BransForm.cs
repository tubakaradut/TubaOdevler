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
    public partial class BransForm : Form
    {
        public BransForm()
        {
            InitializeComponent();
        }


        private void btnBransEkle_Click(object sender, EventArgs e)
        {
            Brans brans = new Brans();
            brans.BransAd = txtBrans.Text;
            Brans.BransListesi.Add(brans);

            txtBrans.Text = "";
          
        }

        private void btnSonraki_Click(object sender, EventArgs e)
        {
            DoktorForm dr = new DoktorForm();
            dr.Show();
            this.Hide();
        }
    }
}
