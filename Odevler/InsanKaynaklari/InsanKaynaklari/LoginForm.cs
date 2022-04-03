using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsanKaynaklari
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        string kullanıcı = "admin";
        string sifre = "1234";

        private void button2_Click(object sender, EventArgs e)
        {
            string gelendeger = txtKullaniciAdi.Text;
            string gelensifre = txtSifre.Text;
            if (gelendeger==kullanıcı && gelensifre==sifre)
            {
                PersonelForm p1 = new PersonelForm();
                p1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı.Yeniden deneyiniz... ");
            }



        }
    }
}
