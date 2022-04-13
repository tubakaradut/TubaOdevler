using System;
using System.Windows.Forms;
using WFKuzeyYeli.Entity;

namespace WFKuzeyYeli.Forms
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }
        ProjeContext.ProjeContext db = new ProjeContext.ProjeContext();
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
                lv.SubItems.Add(order.OrderDate.ToString());
                lv.SubItems.Add(order.Customer.CompanyName);
                lv.SubItems.Add(order.Shipper.CompanyName);
                listView1.Items.Add(lv);
            }

        }
        private void GetOrderDetails()
        {
            //listView2.Items.Clear();
            //foreach (Order_Detail orderdetay  in db.Order_Details)
            //{
            //    ListViewItem lv = new ListViewItem();
            //    lv.Text = orderdetay.OrderID.ToString();
            //    lv.SubItems.Add(orderdetay.Product.ProductName);
            //    lv.SubItems.Add(orderdetay.UnitPrice.ToString());
            //    lv.SubItems.Add(orderdetay.Quantity.ToString());

            //    listView2.Items.Add(lv);

            //}


        }

    }
}
