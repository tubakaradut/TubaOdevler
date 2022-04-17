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
    public partial class TheaterForm : Form
    {
        public TheaterForm()
        {
            InitializeComponent();
        }
        TheaterService theaterService = new TheaterService();
        MovieService movieService = new MovieService();
        SalonService salonService = new SalonService();
        SessionService sessionService = new SessionService();
        WeekService weekService = new WeekService();
        private void TheaterForm_Load(object sender, EventArgs e)
        {
            cmbMovie.DisplayMember = "MovieName";
            cmbMovie.ValueMember = "Id";
            cmbMovie.DataSource = movieService.MoviesList();

            cmbSession.DisplayMember = "Duration";
            cmbSession.ValueMember = "Id";
            cmbSession.DataSource = sessionService.SessionsList();

            cmbSalon.DisplayMember = "SalonAd";
            cmbSalon.ValueMember = "Id";
            cmbSalon.DataSource = salonService.SalonsList();

            cmbWeek.DisplayMember = "WeekAd";
            cmbWeek.ValueMember = "Id";
            cmbWeek.DataSource = weekService.WeeksList();

        }
        public void GetTheaterList()
        {
            listView1.Items.Clear();
            List<Theater> theatersListe = theaterService.TheatersList();

            foreach (Theater theater in theatersListe)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = theater.Id.ToString();
                lvi.SubItems.Add(theater.MovieId.ToString());
                lvi.SubItems.Add(theater.SessionId.ToString());
                lvi.SubItems.Add(theater.SalonId.ToString());
                lvi.SubItems.Add(theater.WeekId.ToString());

                lvi.Tag = theater;
                listView1.Items.Add(lvi);

            }

        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Theater t = new Theater();
            t.MovieId = (int)cmbMovie.SelectedValue;
            t.SessionId = (int)cmbSession.SelectedValue;
            t.SalonId = (int)cmbSalon.SelectedValue;
            t.WeekId = (int)cmbWeek.SelectedValue;

            theaterService.CreatedTheater(t);
            GetTheaterList();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Theater theater = (Theater)listView1.SelectedItems[0].Tag;
            theaterService.DeleteTheater(theater.Id);
            GetTheaterList();
        }
        Theater guncellenecek=new Theater();
        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            guncellenecek.MovieId = (int)cmbMovie.SelectedValue;
            guncellenecek.SessionId = (int)cmbSession.SelectedValue;
            guncellenecek.SalonId = (int)cmbSalon.SelectedValue;
            guncellenecek.WeekId = (int)cmbWeek.SelectedValue;

            theaterService.UpdateTheather(guncellenecek);
            GetTheaterList();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            guncellenecek =(Theater) listView1.SelectedItems[0].Tag;
            cmbMovie.SelectedItem = guncellenecek.Movie.MovieName;
            cmbSession.SelectedItem = guncellenecek.Session.Duration;
            cmbSalon.SelectedItem = guncellenecek.Salon.SalonAd;
            cmbWeek.SelectedItem = guncellenecek.Week.WeekAd;
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            GetTheaterList();
        }
    }
}
