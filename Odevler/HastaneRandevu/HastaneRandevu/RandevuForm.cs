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
    public partial class RandevuForm : Form
    {
        public RandevuForm()
        {
            InitializeComponent();
        }

        private void RandevuForm_Load(object sender, EventArgs e)
        {
            foreach (Brans brans in Brans.BransListesi)
            {
                cmbBrans.Items.Add(brans);
            }

            dateTimePicker1.MinDate = DateTime.Today; //Form acıldıgında tarih ayarı bugune ceker ancak valuechanged aktif olmaması için eventi manuel olarak atıyoruz.
            dateTimePicker1.ValueChanged += new EventHandler(dateTimePicker1_ValueChanged);// 
        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            Brans secilenBrans = (Brans)cmbBrans.SelectedItem; // bransa ait doktorların gelmesi için degisken olustuyoruz.

            cmcDoktor.Items.Clear();

            foreach (Doktor doktor in Doktor.DoktorListesi)
            {

                if (doktor.brans == secilenBrans)
                {

                    cmcDoktor.Items.Add(doktor);
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (txtTckn.Text != "" && txtAd.Text != "" && txtSoyad.Text != "" && cmbBrans.SelectedIndex != -1 && cmcDoktor.SelectedIndex != -1)
            {

                Randevu rd = new Randevu();
                rd.Tckn = txtTckn.Text;
                rd.HastaAd = txtAd.Text;
                rd.HastaSoyad = txtSoyad.Text;
                rd.Brans = (Brans)cmbBrans.SelectedItem;
                rd.Doktor = (Doktor)cmcDoktor.SelectedItem;
                rd.RandevuTarihi = dateTimePicker1.Value;
               

                Randevu.RandevuListesi.Add(rd);

                Randevu.Bilgi = $" {rd.Tckn} Kimlik Nolu {rd.AdSoyad}\n {rd.Brans} Bölümüne, Doktor {rd.Doktor} için \n{rd.RandevuTarihi.ToLongDateString()} ";

                RandevuSaatiFormu rs = new RandevuSaatiFormu();
                MessageBox.Show("Randevu saati seciniz");
                rs.Show();
                this.Hide();
               
            }
            else
            {
                MessageBox.Show("Tüm Alanları Doldurunuz...");
            }
        }
    }
}
