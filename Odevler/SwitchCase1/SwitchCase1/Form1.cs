using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwitchCase1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Kullanici = txtKullaniciAdi.Text.ToLower();
            string sifre = txtSifre.Text;

            switch (Kullanici)
            {
                case "bilgeadam":

                    switch (sifre)
                    {
                        case "1234":
                            MessageBox.Show("Profil sayfasına yönlendiriliyorsunuz...");
                            break;

                        default:
                            MessageBox.Show("kullanıcı adınız doğru ancak şifreniz yanlış");
                            break;
                    }

                    break;
                default:

                    MessageBox.Show("kullanıcı adınız yanlış şifreye bakmadım bile");

                    break;
            }
        }
    }
}
