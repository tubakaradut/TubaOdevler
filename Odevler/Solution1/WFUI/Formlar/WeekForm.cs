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
    public partial class WeekForm : Form
    {
        public WeekForm()
        {
            InitializeComponent();
        }
        WeekService weekService = new WeekService();
        private void btnListele_Click(object sender, EventArgs e)
        {
            GetWeekList();
        }
        public void GetWeekList()
        {
            listView1.Items.Clear();
            List<Week> weeksListe = weekService.WeeksList();

            foreach (Week week  in weeksListe)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = week.Id.ToString();
                lvi.SubItems.Add(week.WeekAd);
                lvi.SubItems.Add(week.FirstDay.ToLongDateString());
                lvi.SubItems.Add(week.LastDay.ToLongDateString());
                lvi.Tag = week;
                listView1.Items.Add(lvi);
            }

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Week week = new Week();
            week.WeekAd = txtWeekName.Text;
            week.FirstDay = dateTimePicker1.Value;
            week.LastDay = dateTimePicker2.Value;
            weekService.CrutedWeek(week);
            GetWeekList();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Week week = (Week)listView1.SelectedItems[0].Tag;
            weekService.DeleteWeek(week.Id);
            GetWeekList();
        }
        Week guncellenecek=new Week();
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            guncellenecek = (Week)listView1.SelectedItems[0].Tag;
            txtWeekName.Text = guncellenecek.WeekAd;
            dateTimePicker1.Value = guncellenecek.FirstDay;
            dateTimePicker2.Value = guncellenecek.LastDay;
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            
            guncellenecek.WeekAd = txtWeekName.Text;
            guncellenecek.FirstDay = dateTimePicker1.Value;
            guncellenecek.LastDay = dateTimePicker2.Value;
            weekService.UpdateWeek(guncellenecek);
            GetWeekList();
        }

    }
}
