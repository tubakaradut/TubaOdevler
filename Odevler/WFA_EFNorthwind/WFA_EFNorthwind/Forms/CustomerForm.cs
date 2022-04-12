using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_EFNorthwind.Forms
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }
        NORTHWNDEntities db = new NORTHWNDEntities();
        private void CustomerForm_Load(object sender, EventArgs e)
        {
            GetCustomerList();

            lblTotalCustomer.Text = db.Customers.Count().ToString();
        }
        private void GetCustomerList()
        {
            listView1.Items.Clear();
            foreach (Customer customer in db.Customers)
            {
                ListViewItem lv = new ListViewItem();
                lv.Text = customer.CustomerID.ToString();
                lv.SubItems.Add(customer.CompanyName);
                lv.SubItems.Add(customer.ContactName);
                lv.SubItems.Add(customer.Country);
                lv.SubItems.Add(customer.Address);
                listView1.Items.Add(lv);
            }

        }
        private void GetCustomerList(string param)
        {
            listView1.Items.Clear();
           
            foreach (Customer customer in db.Customers.Where(x => x.Country.Contains(param)).ToList())
            {
                ListViewItem lv = new ListViewItem();
                lv.Text = customer.CustomerID.ToString();
                lv.SubItems.Add(customer.CompanyName);
                lv.SubItems.Add(customer.ContactName);
                lv.SubItems.Add(customer.Country);
                lv.SubItems.Add(customer.Address);
                listView1.Items.Add(lv);
            }

        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            GetCustomerList(txtArama.Text);
        }

        private void EkleCustomerList(Customer customer)
        {
            try
            {
                db.Customers.Add(customer);
                db.SaveChanges();
                MessageBox.Show(customer.CompanyName + "eklendi");
                GetCustomerList();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSaveCustomer_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.CustomerID = textBox1.Text;
            customer.CompanyName = txtCompanyName.Text;
            customer.ContactName = txtContactName.Text;
            customer.Country = txtCouıntry.Text;
            customer.Address = txtCustomerAdres.Text;

            EkleCustomerList(customer);
            GetCustomerList();
        }
    }
}
