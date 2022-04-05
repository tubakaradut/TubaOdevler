using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinamikMenu
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        List<User> KullaniciLİstesi = new List<User>()
        { new User{ KullaniciAdi="tuba", Sifre="1234", Rolu=Rol.admin  },
          new User{KullaniciAdi="berkan", Sifre="1234", Rolu=Rol.kullanici },
        };

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string gelendeger = textBox1.Text.ToLower();
            string gelensifre = textBox2.Text;

            foreach (User kullanici in KullaniciLİstesi)
            {
                if (kullanici.KullaniciAdi == gelendeger && kullanici.Sifre == gelensifre)
                {
                    switch (kullanici.Rolu)
                    {
                        case Rol.admin:

                            AdminForm adminForm = new AdminForm();
                            adminForm.Show();
                            this.Hide();
                            break;

                        case Rol.kullanici:
                            HamburgerForm hamburgerForm = new HamburgerForm();
                            hamburgerForm.Show();
                            this.Hide();
                            break;
                    }

                }
                
            }

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            Hamburger h1 = new Hamburger();
            Hamburger h2 = new Hamburger();
            Hamburger h3 = new Hamburger();

            h1.Adi = "Whooper";
            h1.Fiyati = 25;

            h2.Adi = "Tavuklu Menü";
            h2.Fiyati = 20;

            h3.Adi = "SteakHouse";
            h3.Fiyati = 35;

            Hamburger.hamburgerListesi.Add(h1);
            Hamburger.hamburgerListesi.Add(h2);
            Hamburger.hamburgerListesi.Add(h3);


            Ekstra e1 = new Ekstra();
            Ekstra e2 = new Ekstra();
            Ekstra e3 = new Ekstra();

            e1.Adi = "Mayonez";
            e1.Fiyati = 2;
            e2.Adi = "Ranch";
            e2.Fiyati = 2;
            e3.Adi = "Chaddar";
            e3.Fiyati = 2;

            Ekstra.ekstraListesi.Add(e1);
            Ekstra.ekstraListesi.Add(e2);
            Ekstra.ekstraListesi.Add(e3);



        }
    }
}
