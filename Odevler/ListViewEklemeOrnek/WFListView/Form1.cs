using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFListView
{
    public partial class btnEkle : Form
    {
        public btnEkle()
        {
            InitializeComponent();
        }

        private void btnEkle_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("İlkokul");
            comboBox1.Items.Add("Ortaokul");
            comboBox1.Items.Add("Lise");
            comboBox1.Items.Add("Lisans");
            comboBox1.Items.Add("YüksekLisans");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem();

            lvi.UseItemStyleForSubItems = false;

            lvi.Text = txtTC.Text;
            lvi.SubItems.Add(txtAdSoyad.Text);
            lvi.SubItems.Add(txtYas.Text);
            lvi.SubItems.Add(comboBox1.Text);

            if (radioButton1.Checked == true)
            {
                lvi.SubItems.Add(radioButton1.Text);
            }
            else if (radioButton2.Checked == true)
            {
                lvi.SubItems.Add(radioButton2.Text);
            }
            lvi.SubItems.Add(dateTimePicker1.Value.Year.ToString());
            lvi.SubItems.Add("");
            lvi.SubItems[6].BackColor = btnRenk.BackColor;
        

            listView1.Items.Add(lvi);

            lblKayitSayisi.Text=listView1.Items.Count.ToString();

            txtTC.Text = "";
            txtAdSoyad.Text = "";
            txtYas.Text = "";
            comboBox1.SelectedIndex = -1;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            btnRenk.BackColor =Color.Black;
            
        }

        private void btnRenk_Click(object sender, EventArgs e)
        {
            DialogResult drr = colorDialog1.ShowDialog();
            if (drr == DialogResult.OK)
            {
                btnRenk.BackColor = colorDialog1.Color;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {


            if (listView1.SelectedItems.Count > 0)
            {
                DialogResult dr = MessageBox.Show("silmek istediğinize emin misiniz?", "Silme işlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    listView1.Items.Remove(listView1.SelectedItems[0]);
                    lblKayitSayisi.Text = listView1.Items.Count.ToString();
                }
                else
                {
                    MessageBox.Show("işlem iptal edildi!");
                }

            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            lbl1.Text = listView1.SelectedItems[0].SubItems[0].Text;
            lbl2.Text = listView1.SelectedItems[0].SubItems[1].Text;
            lbl3.Text = listView1.SelectedItems[0].SubItems[2].Text;
            lbl4.Text = listView1.SelectedItems[0].SubItems[3].Text;
            lbl5.Text = listView1.SelectedItems[0].SubItems[4].Text;
            lbl6.Text = listView1.SelectedItems[0].SubItems[5].Text;
            lbl7.Text = listView1.SelectedItems[0].SubItems[6].Text;


        }
    }
}
