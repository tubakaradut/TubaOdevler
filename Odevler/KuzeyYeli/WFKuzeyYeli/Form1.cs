using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFKuzeyYeli.Forms;

namespace WFKuzeyYeli
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
                _childForm.WindowState = FormWindowState.Maximized;
                _childForm.FormBorderStyle = FormBorderStyle.None;
                _childForm.Show();
            }
        }

        private void kategoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new CategoryForm());
        }

        private void ürünToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new ProductForm());
        }

        private void raporlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new ReportForm());
        }

        private void müşteriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new CustomerForm());
        }

        private void siparişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new OrderForm());
        }

        private void tedarikçiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new ShipperForm());
        }

        private void nakliyeciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new SupplierForm());
        }
    }
}
