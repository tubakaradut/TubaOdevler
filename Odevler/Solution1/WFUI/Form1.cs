using DataAcces.Context;
using DataAcces.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFUI.Formlar;

namespace WFUI
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

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new CategoryForm());
        }

        private void filmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new FilmlerForm());
        }

        private void salonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new SalonForm());
        }

        private void sessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new SessionForm());
        }

        private void weekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new WeekForm());
        }

        private void theaterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new TheaterForm());
        }

        private void raporlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new RaporlarForm());
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
