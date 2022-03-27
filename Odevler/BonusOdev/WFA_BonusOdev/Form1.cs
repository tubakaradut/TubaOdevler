using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_BonusOdev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnKaydet_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = txtUrunAdi.Text;
            lvi.SubItems.Add(cmbKategori.Text);
            lvi.SubItems.Add(nudFiyat.Value.ToString()+" TL ");

            string color = "";
            if (chkBeyaz.Checked)
            {
                color += " " + chkBeyaz.Text;
            }
            if (chkFusya.Checked)
            {
                color += " " + chkFusya.Text;
            }
            if (chkKirmizi.Checked)
            {
                color += " " + chkKirmizi.Text;
            }
            if (chkMavi.Checked)
            {
                color += " " + chkMavi.Text;
            }
            if (chkSari.Checked)
            {
                color += " " + chkSari.Text;
            }
            if (chkSiyah.Checked)
            {
                color += " " + chkSiyah.Text;
            }
            if (chkTitanBeyazi.Checked)
            {
                color += " " + chkTitanBeyazi.Text;
            }
            if (chkToricelliMavisi.Checked)
            {
                color += " " + chkToricelliMavisi.Text;
            }
            if (chkYavruAgzi.Checked)
            {
                color += " " + chkYavruAgzi.Text;
            }
            if (chkYeşil.Checked)
            {
                color += " " + chkYeşil.Text;
            }

            lvi.SubItems.Add(color);
            listView1.Items.Add(lvi);

            txtUrunAdi.Text = "";
            cmbKategori.Text = "";
            ////cmbKategori.SelectedItem = null;
            //cmbKategori.SelectedIndex = -1;
            nudFiyat.Value = 0;
            chkBeyaz.Checked = false;
            chkFusya.Checked = false;
            chkKirmizi.Checked = false;
            chkMavi.Checked = false;
            chkSari.Checked = false;
            chkSiyah.Checked = false;
            chkTitanBeyazi.Checked = false;
            chkToricelliMavisi.Checked = false;
            chkYavruAgzi.Checked = false;
            chkYeşil.Checked = false;

        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            lblSeciliUrunAd.Text = listView1.SelectedItems[0].SubItems[0].Text;
            lblSeciliKategori.Text = listView1.SelectedItems[0].SubItems[1].Text;
            lblSeciliFiyat.Text = listView1.SelectedItems[0].SubItems[2].Text;
            lblRenk.Text = listView1.SelectedItems[0].SubItems[3].Text;

            Secilenler.Items.Add(lblSeciliUrunAd.Text + " reyonundan "+lblRenk.Text+" renkli "+lblSeciliKategori.Text+lblSeciliFiyat.Text);


        }

        private void txtUrunAdi_TextChanged(object sender, EventArgs e)
        {
            string urun = txtUrunAdi.Text;
            cmbKategori.Items.Clear();
            switch (urun)
            {
                case "Ayakkabı":
                    cmbKategori.Items.Add("Spor Ayakkabı");
                    cmbKategori.Items.Add("Sandalet");
                    cmbKategori.Items.Add("Çizme");
                    cmbKategori.Items.Add("Topuklu Ayakkabı");
                    cmbKategori.Items.Add("Babet Ayakkbı");
                    break;

                case "Giyim":
                    cmbKategori.Items.Add("Elbise");
                    cmbKategori.Items.Add("Kazak");
                    cmbKategori.Items.Add("Pantolon");
                    cmbKategori.Items.Add("Etek");
                    cmbKategori.Items.Add("Sweatshirt");
                    break;

                case "Çanta":
                    cmbKategori.Items.Add("Bel Çantası");
                    cmbKategori.Items.Add("Sırt Çantası");
                    cmbKategori.Items.Add("Kol Çantası");
                    cmbKategori.Items.Add("Abiye Çanta");
                    cmbKategori.Items.Add("Postacı Çanta");
                    break;


            }
        }

    }
}

