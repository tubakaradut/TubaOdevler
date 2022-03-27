using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinifornekleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Bankamatik bakiye = new Bankamatik();
        Arabalar arabam = new Arabalar();

        private void Form1_Load(object sender, EventArgs e)
        {
            lblBakiye.Text = bakiye.kasa.ToString();

        }

        private void btnParaCek_Click(object sender, EventArgs e)
        {
            bakiye.CekmeBolmesi = nudParaCek.Value;


            if (bakiye.kasa >= bakiye.CekmeBolmesi && bakiye.CekmeBolmesi > 0)
            {
                bakiye.kasa -= bakiye.CekmeBolmesi;
                lblBakiye.Text = bakiye.kasa.ToString();
                string format = $"Çekilen: {bakiye.CekmeBolmesi}, Bakiye:{ bakiye.kasa} ";
                listBox1.Items.Add(format);
            }

        }

        private void btnParaYatir_Click(object sender, EventArgs e)
        {
            bakiye.YatirmaBolmesi = nudParaYatir.Value;

            if (bakiye.YatirmaBolmesi >= 1)
            {
                bakiye.kasa += bakiye.YatirmaBolmesi;
                lblBakiye.Text = bakiye.kasa.ToString();
                string format = $"Yatırılan: {bakiye.YatirmaBolmesi}, Bakiye:{ bakiye.kasa} ";
                listBox1.Items.Add(format);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (cmbMarka.Text == "" || cmbModel.Text == "" || cmbYakit.Text == "" ||
                cmbVites.Text == "" || txtModelYil.Text == "" || btnRenk.BackColor.ToString() == "" || numericUpDown1.Value <= 0)
            {
                MessageBox.Show("Eksik bilgi girdiniz. Lütfen düzeltin!");
            }
            else
            {

                arabam.Marka = cmbMarka.Text;
                arabam.Model = cmbModel.Text;
                arabam.Yakit = cmbYakit.Text;
                arabam.VitesTipi = cmbVites.Text;
                arabam.Yil = Convert.ToInt32(txtModelYil.Text);
                arabam.renk = btnRenk.BackColor.ToString();
                arabam.fiyat = numericUpDown1.Value;


                ListViewItem lvi = new ListViewItem();
                lvi.UseItemStyleForSubItems = false;
                lvi.Text = arabam.Marka; //0
                lvi.SubItems.Add(arabam.Model);//1
                lvi.SubItems.Add(arabam.Yakit);//2
                lvi.SubItems.Add(arabam.VitesTipi);//3
                lvi.SubItems.Add(arabam.renk);//4
                lvi.SubItems[4].ForeColor = btnRenk.BackColor;
                lvi.SubItems[4].BackColor = btnRenk.BackColor;

                lvi.SubItems.Add(arabam.Yil.ToString());//5
                lvi.SubItems.Add(arabam.fiyat.ToString());//6
                listView1.Items.Add(lvi);

                //silme işlemi
                cmbMarka.Text = "";
                cmbModel.Text = "";
                cmbVites.Text = "";
                cmbYakit.Text = "";
                txtModelYil.Text = "";
                btnRenk.BackColor = Color.White;
                numericUpDown1.Value = 0;
            }
        }

        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbModel.Items.Clear();

            switch (cmbMarka.Text)//Alfa Romeo
            {
                case "Alfa Romeo":
                    cmbModel.Items.Add("Guiletta");
                    cmbModel.Items.Add("159");
                    break;

                case "Renault":
                    cmbModel.Items.Add("Megane");
                    cmbModel.Items.Add("Clio");
                    break;

                case "Ferrari":
                    cmbModel.Items.Add("143");
                    cmbModel.Items.Add("California");
                    break;

                case "Porsche":
                    cmbModel.Items.Add("Carrera");
                    cmbModel.Items.Add("Cayane");
                    break;

                case "Tesla":
                    cmbModel.Items.Add("Model s");
                    break;
            }
        }

        private void btnRenk_Click(object sender, EventArgs e)
        {
            DialogResult dr = colorDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                btnRenk.BackColor = colorDialog1.Color;
            }
            else
            {
                MessageBox.Show("işlem iptal edildi!");
            }

        }


        private void btnSatinAl_Click(object sender, EventArgs e)
        {
            bool sagliyormu = true;

            for (int i = 0; i < listView1.Items.Count; i++)
            {
                bool dongudenCiksinMi = false;
                for (int j = 0; j < listView1.Items[i].SubItems.Count; j++)
                {
                    string text = listView1.Items[i].SubItems[j].Text;

                    if (text == "")
                    {
                        MessageBox.Show("Eksik Bigileriniz var. Bu yüzden satın alamazsınız! Nasıl alabilirsiniz bilmiyorum :)");
                        dongudenCiksinMi = true;
                        sagliyormu = false;
                        break;
                    }


                }
                if (dongudenCiksinMi)
                {
                    break;
                }
            }



            if (sagliyormu)
            {
                if (bakiye.kasa >= arabam.fiyat)
                {
                    bakiye.kasa -= arabam.fiyat;
                    lblBakiye.Text = bakiye.kasa.ToString();

                    string format = $"Markası: {arabam.Marka}, Modeli: {arabam.Model}, Fiyatı: {arabam.fiyat}, Kalan Bakiyeniz: {bakiye.kasa} ";
                    MessageBox.Show(format);

                }
                else
                {
                    string format = $"Bakiyeniz: {bakiye.kasa}, İstediğiniz Araba Fiyatı: {arabam.fiyat}\n, Bakiyeniz yetersizdir.Bakiye yüklendikten sonra tekrar deneyiniz..";
                    MessageBox.Show(format);

                }
            }
        }
    }
}
