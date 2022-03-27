using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_AracKaiytFormu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Combobox değer tanımlama
        //cmbDeger.Items.Add("Mercedes");//0
        //cmbDeger.Items.Add("Renault");//1
        //cmbDeger.Items.Add("Honda");//2

        //Combobox değer çağırma
        //int secili = cmbDeger.SelectedIndex;
        //MessageBox.Show(secili.ToString());

        //MessageBox.Show(cmbDeger.SelectedItem.ToString());



        private void Form1_Load(object sender, EventArgs e)
        {
            cmbMarka.Items.Clear();
            #region Örnek ListView
            //ListViewItem lvi = new ListViewItem();//instance
            //lvi.Text = "Renault"; //0=>Column
            //lvi.SubItems.Add("Megane");//1=>Column
            //lvi.SubItems.Add("Benzin");//2=>Column
            //lvi.SubItems.Add("Otomatik");//3=>Column

            //listView1.Items.Add(lvi); 
            #endregion

            //Marka
            cmbMarka.Items.Add("Alfa Romeo");
            cmbMarka.Items.Add("Renault");
            cmbMarka.Items.Add("Ferrari");
            cmbMarka.Items.Add("Porsche");
            cmbMarka.Items.Add("Tesla");


            //Model


            //Yakıt Tip
            cmbYakit.Items.Add("Dizel");
            cmbYakit.Items.Add("Benzin");
            cmbYakit.Items.Add("Elektrik");


            //Vites Tip
            cmbVites.Items.Add("Otomatik");
            cmbVites.Items.Add("Manuel");



        }

        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbModel.Items.Clear();
            //MessageBox.Show("seçili değer değişti!");

            //MessageBox.Show(cmbMarka.Text);

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

            //if(cmbMarka.Text=="Alfa Romeo")
            //{
            //    cmbModel.Items.Add("Guiletta");
            //}
            //else if (cmbMarka.Text == "Ferrari")
            //{

            //}
            //else if (cmbMarka.Text == "Renault")
            //{

            //}


        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.UseItemStyleForSubItems = false; //eğer subitemlarda bir stil işlemi dahil etmek istiyorsanız bu özelliği false olarak tanımlamalısınız!!!!
            lvi.Text = cmbMarka.Text; //0
            lvi.SubItems.Add(cmbModel.Text);//1
            lvi.SubItems.Add(cmbYakit.Text);//2
            lvi.SubItems.Add(cmbVites.Text);//3
            //lvi.SubItems.Add(btnRenk.BackColor.ToString());//4 Renk
            lvi.SubItems.Add("");//4
            lvi.SubItems[4].BackColor = btnRenk.BackColor;
            lvi.SubItems.Add(dateTimePicker1.Value.Year.ToString());

            listView1.Items.Add(lvi);

            lblAdet.Text = listView1.Items.Count.ToString();
        }

        private void btnRenk_Click(object sender, EventArgs e)
        {
            DialogResult dr = colorDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                //MessageBox.Show("renk seçildi!");
                btnRenk.BackColor = colorDialog1.Color;
            }
            else
            {
                MessageBox.Show("işlem iptal edildi!");
            }

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            //eğer listview1 içerisinde en az 1 adet item var ise Not: Count sayma işlemini 1'den başlatır.
            if (listView1.SelectedItems.Count > 0)
            {

                DialogResult dr = MessageBox.Show("silmek istediğinize emin misiniz?", "Silme işlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    //listview1 içerisinde bulunan itemlardan seçili olanı kaldır. Not: selectedItems'ın index numaraları 0'dan başlar.
                    listView1.Items.Remove(listView1.SelectedItems[0]);
                    lblAdet.Text = listView1.Items.Count.ToString();
                }
                else
                {
                    MessageBox.Show("işlem iptal edildi!");
                }

            }
            else
            {
                MessageBox.Show("item yokki ben neyi sileyim?");
            }

        }
    }
}
