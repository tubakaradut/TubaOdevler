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
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }
        NORTHWNDEntities db = new NORTHWNDEntities();
        private void OrderForm_Load(object sender, EventArgs e)
        {
            GetOrderLİste();
            GetOrderDetails();
        }
        private void GetOrderLİste()
        {
            listView1.Items.Clear();

            foreach (Order order in db.Orders)
            {
                ListViewItem lv = new ListViewItem();
                lv.Text = order.OrderID.ToString();

                string customername = order.CustomerID == null ? "Tanımsız" : order.Customer.CompanyName;
                lv.SubItems.Add(customername);

                string employename = order.EmployeeID == null ? "Tanımsız" : order.Employee.FirstName + " " + order.Employee.LastName;
                lv.SubItems.Add(employename);
                lv.SubItems.Add(order.OrderDate.ToString());

                listView1.Items.Add(lv);

            }

        }
        private void GetOrderDetails()
        {
            listView2.Items.Clear();
            foreach (Order_Detail orderdetay  in db.Order_Details)
            {
                ListViewItem lv = new ListViewItem();
                lv.Text = orderdetay.OrderID.ToString();
                lv.SubItems.Add(orderdetay.Product.ProductName);
                lv.SubItems.Add(orderdetay.UnitPrice.ToString());
                lv.SubItems.Add(orderdetay.Quantity.ToString());

                listView2.Items.Add(lv);

            }


        }

    }
}
