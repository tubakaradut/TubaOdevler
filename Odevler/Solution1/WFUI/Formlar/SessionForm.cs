using Business.Service;
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

namespace WFUI.Formlar
{
    public partial class SessionForm : Form
    {
        public SessionForm()
        {
            InitializeComponent();
        }
        SessionService sessionService = new SessionService();
        private void btnListele_Click(object sender, EventArgs e)
        {
            GetSessionList();
        }
        public void GetSessionList()
        {
            listView1.Items.Clear();
            List<Session> sessionsListesi = sessionService.SessionsList();

            foreach (Session session in sessionsListesi)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = session.Id.ToString();
                lvi.SubItems.Add(session.Duration);
                lvi.Tag = session;
                listView1.Items.Add(lvi);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Session s = new Session();
            s.Duration = textBox1.Text;
            sessionService.CreateSession(s);
            GetSessionList();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Session s = (Session)listView1.SelectedItems[0].Tag;
            sessionService.DeleteSession(s.Id);
        }
        Session guncellenecek = new Session();
        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            guncellenecek.Duration = textBox1.Text;
            sessionService.UpdateSession(guncellenecek);
            GetSessionList();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {

            guncellenecek = (Session)listView1.SelectedItems[0].Tag;
            textBox1.Text = guncellenecek.Duration;

        }
    }
}
