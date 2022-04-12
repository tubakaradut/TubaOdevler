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
    public partial class EmployeForm : Form
    {
        public EmployeForm()
        {
            InitializeComponent();
        }
        NORTHWNDEntities db = new NORTHWNDEntities();
        private void EmployeForm_Load(object sender, EventArgs e)
        {
            GetEmploye();
            lblTotalEmploye.Text = db.Employees.Count().ToString();
        }
        private void GetEmploye()
        {
            listView1.Items.Clear();
            foreach (Employee employee  in db.Employees)
            {
                ListViewItem lv = new ListViewItem();
                lv.Text = employee.EmployeeID.ToString();
                lv.SubItems.Add(employee.FirstName);
                lv.SubItems.Add(employee.LastName);
                lv.SubItems.Add(employee.Country);
                lv.SubItems.Add(employee.TitleOfCourtesy);
                listView1.Items.Add(lv);
            }
        }
        private void EkleEmploye(Employee employee)
        {
            try
            {
                db.Employees.Add(employee);
                db.SaveChanges();
                GetEmploye();
                MessageBox.Show(employee.FirstName + " " + employee.LastName + " Eklendi");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void btnSaveEmploye_Click(object sender, EventArgs e)
        {
            Employee em = new Employee();
            em.EmployeeID =int.Parse( txtEmployeId.Text);
            em.FirstName = txtFirstName.Text;
            em.LastName = txtLastName.Text;
            em.Country = txtEmployeCouıntry.Text;
            em.TitleOfCourtesy = txtCTitleOfCourtesy.Text;
            EkleEmploye(em);
            GetEmploye();

        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            AraEmploye(txtArama.Text);
        }
        private void AraEmploye(string param)
        {
            listView1.Items.Clear();
            foreach (Employee employee in db.Employees.Where(x=>x.FirstName.Contains(param) ||x.LastName.Contains(param)))
            {
                ListViewItem lv = new ListViewItem();
                lv.Text = employee.EmployeeID.ToString();
                lv.SubItems.Add(employee.FirstName);
                lv.SubItems.Add(employee.LastName);
                lv.SubItems.Add(employee.Country);
                lv.SubItems.Add(employee.TitleOfCourtesy);
                listView1.Items.Add(lv);
            }
        }
    }
}
