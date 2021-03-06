using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitapKafe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void childForm(Form _childForm)
        {
            this.Width = _childForm.Width + 22;
            this.Height = _childForm.Height + 60;
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

        private void kİTAPSİPARİŞİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new KitapSiparisOlustur());
        }

        private void içecekSiparişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new IcecekSiparisOlustur());
        }

        private void KitapOlusturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new KitapOlustur());
        }

        private void içecekOlusturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new IcecekOlustur());
        }

       
        private void siparisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new Siparisler());
        }

        private void kitapEkstraOlusturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new KitapEkstraOlustur());

        }

        private void içecekEkstraOlusturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new IcecekEkstraOlustur());
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
