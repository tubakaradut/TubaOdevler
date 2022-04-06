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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //todo: her form açıldığında aşağıtya kaydırıyor. 
        //45. satır dahil edildiğinde sorun çözüldü.
        void childForm(Form _childForm)
        {
            this.Width = _childForm.Width+22;
            this.Height = _childForm.Height+68;
            bool durum = false;

            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Text == _childForm.Text)
                {
                    durum = true;
                    frm.Activate();
                }
                else
                {
                    frm.Close();
                }

            }

            if (durum == false)
            {
                _childForm.MdiParent = this;
                _childForm.StartPosition = FormStartPosition.Manual;
                _childForm.FormBorderStyle = FormBorderStyle.None;
                _childForm.Show();
            }
        }

        private void siparişToolStripMenuItem_Click(object sender, EventArgs e)
        {
        //    SiparisOlustur siparisOlustur = new SiparisOlustur();
        //    childForm(siparisOlustur);
            childForm(new SiparisOlustur());
          
        }

        private void menuOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new MenuOlustur());
            
        }

        private void ekstraOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new EkstraOlustur());
        }

        private void siparişlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new Siparisler());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Menuu h1 = new Menuu();
            Menuu h2 = new Menuu();
            Menuu h3 = new Menuu();

            h1.MenuAdi = "Whooper";
            h1.Fiyati = 25;

            h2.MenuAdi = "Tavuklu Menü";
            h2.Fiyati = 20;

            h3.MenuAdi = "SteakHouse";
            h3.Fiyati = 35;

            Menuu.MenuListesi.Add(h1);
            Menuu.MenuListesi.Add(h2);
            Menuu.MenuListesi.Add(h3);


            Ekstra e1 = new Ekstra();
            Ekstra e2 = new Ekstra();
            Ekstra e3 = new Ekstra();

            e1.EkstraAdi = "Mayonez";
            e1.Fiyati = 2;
            e2.EkstraAdi = "Ranch";
            e2.Fiyati = 2;
            e3.EkstraAdi = "Chaddar";
            e3.Fiyati = 2;

            Ekstra.EkstraListesi.Add(e1);
            Ekstra.EkstraListesi.Add(e2);
            Ekstra.EkstraListesi.Add(e3);
        }
    }
}
