using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFKuzeyYeli.Entity;

namespace WFKuzeyYeli.Forms
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }
        ProjeContext.ProjeContext db = new ProjeContext.ProjeContext();
        private void ProductForm_Load(object sender, EventArgs e)
        {
            GetProductList();
          
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryID";
            cmbCategory.DataSource = db.Categories.ToList();


            cmbSelectCategory.DisplayMember = "CategoryName";
            cmbSelectCategory.ValueMember = "CategoryID";
            cmbSelectCategory.DataSource = db.Categories.ToList();

            lblTotalCategories.Text = db.Categories.Count().ToString();
            lblTotalProducts.Text = db.Products.Count().ToString();
        }

        //ürünleri listeleme
        private void GetProductList()
        {
            listView1.Items.Clear();
            foreach (Product product in db.Products)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = product.ProductID.ToString();
                lvi.SubItems.Add(product.ProductName);
                lvi.SubItems.Add(product.UnitPrice.ToString());
                lvi.SubItems.Add(product.UnitsInStock.ToString());
                lvi.SubItems.Add(product.Category.CategoryName);
                listView1.Items.Add(lvi);
            }
        }

        //ürünleri fiyata göre artan veya azalan listeleme (val paramatresine true değeri gönderilirse artan, false parametresi gönderilirse azalan sıralama yapar.)
        private void GetProductList(bool val)
        {
            listView1.Items.Clear();
            List<Product> products;
            if (val)
            {
               products = db.Products.OrderBy(x => x.UnitPrice).ToList();
            }
            else
            {
                products = db.Products.OrderByDescending(x => x.UnitPrice).ToList();
            }
            

            foreach (Product product in products)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = product.ProductID.ToString();
                lvi.SubItems.Add(product.ProductName);
                lvi.SubItems.Add(product.UnitPrice.ToString());
                lvi.SubItems.Add(product.UnitsInStock.ToString());
                lvi.SubItems.Add(product.Category.CategoryName);
                listView1.Items.Add(lvi);
            }
        }

        //dışarıdan gönderilen karaktere göre ürün arama (param isimli parametreye gönderilen string değere göre ürün içerisinde arama işlemi gerçekleştirir.)
        private void GetProductList(string param)
        {
            listView1.Items.Clear();

            List<Product> products = db.Products.Where(x => x.ProductName.Contains(param)).ToList();

            foreach (Product product in products)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = product.ProductID.ToString();
                lvi.SubItems.Add(product.ProductName);
                lvi.SubItems.Add(product.UnitPrice.ToString());
                lvi.SubItems.Add(product.UnitsInStock.ToString());
                lvi.SubItems.Add(product.Category.CategoryName);
                listView1.Items.Add(lvi);
            }
        }

        private void GetProductList(int? id)
        {
            listView1.Items.Clear();

            List<Product> products = db.Products.Where(x=>x.CategoryId==id).ToList();

            foreach (Product product in products)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = product.ProductID.ToString();
                lvi.SubItems.Add(product.ProductName);
                lvi.SubItems.Add(product.UnitPrice.ToString());
                lvi.SubItems.Add(product.UnitsInStock.ToString());
                lvi.SubItems.Add(product.Category.CategoryName);
                listView1.Items.Add(lvi);
            }
        }

        //ürün ekleme. (parametre olarak Product tipinde bir nesne gönderildikten sonra o nesne northwind içerisinde bulunan Product tablosuna eklenir.)
        private void AddProduct(Product product)
        {
            try
            {
                db.Products.Add(product);
                db.SaveChanges();
                MessageBox.Show(product.ProductName + " kaydedildi!");
                GetProductList();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            p.ProductName = txtProductName.Text;
            p.UnitPrice = nudUnitPrice.Value;
            p.UnitsInStock = Convert.ToInt16(nudUnitsInStock.Value);
            p.CategoryId = (int)cmbCategory.SelectedValue;

            AddProduct(p);
            
        }

        private void rbUnitPriceAsc_CheckedChanged(object sender, EventArgs e)
        {
            GetProductList(true);
        }

        private void rbUnitPriceDesc_CheckedChanged(object sender, EventArgs e)
        {
            GetProductList(false);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            GetProductList(txtSearch.Text);
        }

        private void cmbSelectCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int categoryId = Convert.ToInt32(cmbSelectCategory.SelectedValue);
            GetProductList(categoryId);
        }
    }
}
