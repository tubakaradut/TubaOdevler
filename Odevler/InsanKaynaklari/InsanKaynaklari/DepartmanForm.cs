using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsanKaynaklari
{
    public partial class DepartmanForm : Form
    {
        public DepartmanForm()
        {
            InitializeComponent();
        }

        public static List<Departman> DepartmanListesi = new List<Departman>();



        private void btnPersonel_Click(object sender, EventArgs e)
        {
            
            PersonelForm personelForm = new PersonelForm();
            personelForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Departman dp = new Departman();
            dp.Ad = txtDepartman.Text;
            DepartmanListesi.Add(dp);

            MessageBox.Show(dp.ToString());
        }

        private void DepartmanForm_Load(object sender, EventArgs e)
        {

        }
    }
}
