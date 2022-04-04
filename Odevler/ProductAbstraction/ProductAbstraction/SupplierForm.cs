using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductAbstraction.FakeDatabase;

namespace ProductAbstraction
{
    public partial class SupplierForm : Form
    {
        public SupplierForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Supplier sp = new Supplier();
            sp.CompanyName = txtCompanyName.Text;
            sp.Address = txtAdres.Text;
            sp.PhoneNumber = txtPhoneNumber.Text;

            lstSupplier.Items.Add(sp);

            string message = sp.Add();
            MessageBox.Show(message);

            txtCompanyName.Text = "";
            txtPhoneNumber.Text = "";
            txtAdres.Text = "";

            listBox1.DataSource = Database.supplierList.ToList();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int seciliindex = lstSupplier.SelectedIndex;

            if (seciliindex >= 0)
            {

                Supplier sp = new Supplier();
                sp.CompanyName = txtCompanyName.Text;
                sp.Address = txtAdres.Text;
                sp.PhoneNumber = txtPhoneNumber.Text;

                string message = sp.Update(seciliindex);

                lstSupplier.Items[seciliindex] = $" Şirket Adı: {sp.CompanyName}, Telefon:  {sp.PhoneNumber}, Adres: {sp.Address}";

                MessageBox.Show(message);
                listBox1.DataSource = Database.supplierList.ToList();

            }
            txtCompanyName.Text = "";
            txtPhoneNumber.Text = "";
            txtAdres.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int seciliindex = lstSupplier.SelectedIndex;

            if (seciliindex >= 0)
            {

                Supplier sp = new Supplier();
                string message = sp.Delete(seciliindex);

                lstSupplier.Items.RemoveAt(seciliindex);

                MessageBox.Show(message);
                listBox1.DataSource = Database.supplierList.ToList();

            }
        }

        private void btnKategori_Click(object sender, EventArgs e)
        {
            CategoryForm cf = new CategoryForm();
            cf.Show();
            this.Hide();
        }

        private void btnUrun_Click(object sender, EventArgs e)
        {
            ProductForm pf = new ProductForm();
            pf.Show();
            this.Hide();
        }
    }
}