using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_McAdam
{
    public partial class MenuOlustur : Form
    {
        public MenuOlustur()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Menuu menu = new Menuu();
            menu.MenuAdi = txtMenuAd.Text;
            menu.Fiyati = nudMenuFiyat.Value;

            menu.Ekle(menu);

            txtMenuAd.Text = "";
            nudMenuFiyat.Value = 0;
        }
    }
}
