using System;
using System.Linq;
using System.Windows.Forms;
using WFKuzeyYeli.Entity;

namespace WFKuzeyYeli.Forms
{
    public partial class SupplierForm : Form
    {
        public SupplierForm()
        {
            InitializeComponent();
        }
        ProjeContext.ProjeContext db = new ProjeContext.ProjeContext();
        private void SupplierForm_Load(object sender, EventArgs e)
        {
            GetSuplier();
            lblTotalSuppliers.Text = db.Suppliers.Count().ToString();
        }
        private void GetSuplier()
        {
            listView1.Items.Clear();

            foreach (Supplier supplier in db.Suppliers)
            {
                ListViewItem lv = new ListViewItem();
                lv.Text = supplier.SupplierID.ToString();
                lv.SubItems.Add(supplier.CompanyName);
                lv.SubItems.Add(supplier.City);
                listView1.Items.Add(lv);

            }

        }
        private void EkleShipper(Supplier supplier)
        {
            try
            {
                db.Suppliers.Add(supplier);
                db.SaveChanges();
                MessageBox.Show(supplier.CompanyName + " kaydedildi!");
                GetSuplier();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Supplier s = new Supplier();
            s.CompanyName = txtCompanyName.Text;
            s.City = txtCity.Text;
            EkleShipper(s);
        }
    }
}
