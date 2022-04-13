using System;
using System.Windows.Forms;
using WFKuzeyYeli.Entity;

namespace WFKuzeyYeli.Forms
{
    public partial class ShipperForm : Form
    {
        public ShipperForm()
        {
            InitializeComponent();
        }
        ProjeContext.ProjeContext db = new ProjeContext.ProjeContext();
        private void ShipperForm_Load(object sender, EventArgs e)
        {
            GetShipper();
        }
        private void GetShipper()
        {
            listView1.Items.Clear();

            foreach (Shipper shipper in db.Shippers)
            {
                ListViewItem lv = new ListViewItem();
                lv.Text = shipper.ShipperID.ToString();
                lv.SubItems.Add(shipper.CompanyName);
                lv.SubItems.Add(shipper.Phone);
                listView1.Items.Add(lv);

            }

        }
        private void EkleShipper(Shipper shipper)
        {
            try
            {
                db.Shippers.Add(shipper);
                db.SaveChanges();
                MessageBox.Show(shipper.CompanyName + " kaydedildi!");
                GetShipper();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Shipper s = new Shipper();
            s.CompanyName = txtCompanyName.Text;
            s.Phone = txtPhone.Text;
            EkleShipper(s);
        }
    }
}
