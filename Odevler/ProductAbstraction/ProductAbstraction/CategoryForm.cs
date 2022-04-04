using ProductAbstraction.FakeDatabase;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ProductAbstraction
{
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Category cg = new Category();

            cg.CategoryName = txtCategoryName.Text;
            cg.Description = txtDescription.Text;

            lstCategori.Items.Add(cg);

            string message = cg.Add();
            MessageBox.Show(message);

            txtCategoryName.Text = "";
            txtDescription.Text = "";

            listBox1.DataSource = Database.categoryList.ToList();
         
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int seciliindex = lstCategori.SelectedIndex;

            if (seciliindex >= 0)
            {

                Category cg = new Category();
                cg.CategoryName = txtCategoryName.Text;
                cg.Description = txtDescription.Text;

                string message = cg.Update(seciliindex);

                lstCategori.Items[seciliindex] = $" Kategori Adı: {cg.CategoryName}, Açıklama: {cg.Description} "; 

                MessageBox.Show(message);

                listBox1.DataSource = Database.categoryList.ToList();

            }

            txtCategoryName.Text = "";
            txtDescription.Text = "";

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int seciliindex = lstCategori.SelectedIndex;

            if (seciliindex >= 0)
            {

                Category cg = new Category();
                string message = cg.Delete(seciliindex);

                lstCategori.Items.RemoveAt(seciliindex);

                MessageBox.Show(message);
                listBox1.DataSource = Database.categoryList.ToList();
            }
        }

        private void btnUrun_Click(object sender, EventArgs e)
        {
            ProductForm pf = new ProductForm();
            pf.Show();
            this.Hide();
        }

        private void btnTedarikci_Click(object sender, EventArgs e)
        {
           SupplierForm sf = new SupplierForm();
            sf.Show();
            this.Hide();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {

        }
    }
}
