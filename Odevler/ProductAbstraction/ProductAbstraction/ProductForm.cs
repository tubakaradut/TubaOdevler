using ProductAbstraction.FakeDatabase;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ProductAbstraction
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            Product product = new Product();   // yeni bir ürün ekleme işlemi olusturulan ürün arka tarafta otomotik olarak listeye eklenir.

            Category category = new Category();
            category.CategoryName = cmbCategory.SelectedItem.ToString();

            Supplier supplier = new Supplier();
            supplier.CompanyName = cmbSupplier.SelectedItem.ToString();

            product.ProductName = txtProductName.Text;
            product.UnitPrice = Convert.ToDecimal(txtUnitPrice.Text);
            product.UnitsInStock = Convert.ToByte(txtUnitStock.Text);
            product.Category = category;
            product.Supplier = supplier;

            string message = product.Add();  // ekleme metodu bize string olarak donus yapacagından degisken belirlenir ve ona atanır.

            lstProduct.Items.Add($"Urün Adı: {product.ProductName}, Birim fiyat: { product.UnitPrice}, Birim Stok:  {product.UnitsInStock}, Kategori: {product.Category.CategoryName}, Tedarikçi: {product.Supplier}"); // listboxda gösterim.

            MessageBox.Show(message);  //ekleme metodunda donen string deger gösterimi.

            listBox1.DataSource = Database.productList.ToList();  //daha anlasılır olması acısından databasedei listenin de gösterimi.

            txtProductName.Text = "";
            txtUnitPrice.Text = "";
            txtUnitStock.Text = "";
            cmbCategory.SelectedIndex = -1;
            cmbSupplier.SelectedIndex = -1;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedIndex = lstProduct.SelectedIndex;   //silme islemi secilen ındeksle yapıldı.
            if (selectedIndex >= 0)
            {
                Product product = new Product();
                string message = product.Delete(selectedIndex); // silme metodu da geriye string deger döndugu icin degıskene atama yapıldı.

                lstProduct.Items.RemoveAt(selectedIndex);   //listboxdan silme ıslemi. arka tarafta otomotik olarak database listesinden silinir.

                MessageBox.Show(message);

                listBox1.DataSource = Database.productList.ToList();
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int selectedIndex = lstProduct.SelectedIndex;
            if (selectedIndex >= 0)
            {
                Product product = new Product();
                product.ProductName = txtProductName.Text;
                product.UnitPrice = Convert.ToDecimal(txtUnitPrice.Text);
                product.UnitsInStock = Convert.ToInt16(txtUnitStock.Text);
                product.Category = (Category)cmbCategory.SelectedItem;
                product.Supplier = (Supplier)cmbSupplier.SelectedItem;

                string message = product.Update(selectedIndex);

                lstProduct.Items[selectedIndex] = $"Urün Adı: {product.ProductName}, Birim fiyat: { product.UnitPrice}, Birim Stok:  {product.UnitsInStock}, Kategori: {product.Category.CategoryName}, Tedarikçi: {product.Supplier}";

                MessageBox.Show(message);

                listBox1.DataSource = Database.productList.ToList();
                txtProductName.Text = "";
                txtUnitPrice.Text = "";
                txtUnitStock.Text = "";
                cmbCategory.SelectedIndex = -1;
                cmbSupplier.SelectedIndex = -1;
            }
        }

        private void btnTedarikci_Click(object sender, EventArgs e)
        {
            SupplierForm sf = new SupplierForm();
            sf.Show();
            this.Hide();
        }

        private void btnKategori_Click(object sender, EventArgs e)
        {

            CategoryForm cf = new CategoryForm();
            cf.Show();
            this.Hide();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {

            cmbCategory.DataSource = Database.categoryList;
            cmbSupplier.DataSource = Database.supplierList;

            cmbCategory.DisplayMember = "CategoryName";
            cmbSupplier.DisplayMember = "CompanyName";

            cmbCategory.SelectedIndex = -1;
            cmbSupplier.SelectedIndex = -1;

        }
    }
}
