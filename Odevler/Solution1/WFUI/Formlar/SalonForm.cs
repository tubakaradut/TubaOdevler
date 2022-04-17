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
    public partial class SalonForm : Form
    {
        public SalonForm()
        {
            InitializeComponent();
        }
        SalonService salonService = new SalonService();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Salon salon = new Salon();
            salon.SalonAd = txtSalonName.Text;
            salon.Capasity = (int)nmCapasity.Value;
            salonService.CreateSalon(salon);
            GetSalonList();

        }

        public void GetSalonList()
        {
            listView1.Items.Clear();
            List<Salon> salonlistesi = salonService.SalonsList();

            foreach (Salon salon in salonlistesi)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = salon.Id.ToString();
                lvi.SubItems.Add(salon.SalonAd);
                lvi.SubItems.Add(salon.Capasity.ToString());
                lvi.Tag = salon;
                listView1.Items.Add(lvi);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Salon s = (Salon)listView1.SelectedItems[0].Tag;
            salonService.DeleteSalon(s.Id);
            GetSalonList();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            guncellencek.SalonAd = txtSalonName.Text;
            guncellencek.Capasity =(int) nmCapasity.Value;
            salonService.UpdateSalon(guncellencek);
            GetSalonList();
        }
        Salon guncellencek=new Salon();
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            guncellencek = (Salon)listView1.SelectedItems[0].Tag;
            txtSalonName.Text = guncellencek.SalonAd;
            nmCapasity.Value = guncellencek.Capasity;

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            GetSalonList();
        }
    }
}
