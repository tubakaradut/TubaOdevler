using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karışık_Alışstırma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] diller = { "Türkçe", "İngilizce", "Almanca", "Arapça", "Fransızca", "Azerice", "Çince" + "İtalyanca", "Osmanlıca", "Gürcüce", "İspanyolca" };//bu alana yazmamızın sebebi dilleri sonradan ekledgimiz için
            checkedListBox1.Items.AddRange(diller); //addrange check butonu olarak eklemesini saglar
            checkedListBox1.MultiColumn = true; //checklist kutularının yan yana düzgün yerleşmesini saglar yukarı asagı butonu yerine yan yana dizilimsaglar.
            checkedListBox1.CheckOnClick = true; //kutucukalrı tek tıkla işaretlemek için yapılır.cunku basta iki tıkla işaretleniyordu.
            btnYeniDil.Enabled = false;

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {//yeni dil eklenmek istediginde 
            if (textBox2.Text == "")//eger yazı yazılmadıysa dil girilmediyse yenidil ekle butonu pasif olsun
            { btnYeniDil.Enabled = false; }
            else
            { btnYeniDil.Enabled = true; }//yazı dil girildiyse yeni dil ekle butonu aktif olsun demek
        }

        private void btnYeniDil_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")  //!= esit degilse "" yani herhangi bir veri yazılmıssa
            {//  alttaki fonk. eger checklistesine textbox da yazılan metin içeriyormu kontrolü için contains içermek. false olası içermiyor anlamında
                if (checkedListBox1.Items.Contains(textBox2.Text) == false)
                    checkedListBox1.Items.Add(textBox2.Text);
                else
                    MessageBox.Show("Belirtilen dil zaten eklidir");
                textBox2.Text = "";
            }

        }

        private void btnDilSil_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Remove(checkedListBox1.SelectedItem);
            //check list içindeki secili olan ögeyi sil demek 
            //selected=secili olan, remove=sil demek
        }

        private void btnSecimleriKaldır_Click(object sender, EventArgs e)
        {
            while (checkedListBox1.CheckedIndices.Count > 0)//check list içinden yapılan secilenleri sayısı 0 dan büyükse ise checkedIndices secşlenleri saydır say
                checkedListBox1.SetItemChecked(checkedListBox1.CheckedIndices[0], false);
            //işaretin ayarlanması setitemchecked. false ile secilenleri kaldır demek

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            lblAS.Text = txtAdsoyad.Text;
            string diller = "", mezuniyet = "";

            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                diller += ", " + checkedListBox1.CheckedItems[i];
            }
            diller = diller.Substring(2);
            lblDil.Text = diller;

            if (rIlkokul.Checked == true)
            { mezuniyet = rIlkokul.Text; }
            else if (rOrtaOkul.Checked == true)
            { mezuniyet = rOrtaOkul.Text; }
            else if (rLise.Checked == true)
            { mezuniyet = rLise.Text; }
            else if (rUniversite.Checked == true)
            { mezuniyet = rUniversite.Text; }

            lblMezun.Text = mezuniyet;
            txtAdsoyad.Text = "";
        }
    }
}
