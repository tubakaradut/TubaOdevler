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
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }
        NORTHWNDEntities db = new NORTHWNDEntities ();
        private void CategoryForm_Load(object sender, EventArgs e)
        {
            GetCategories();
        }

        private void GetCategories()
        {
            listView1.Items.Clear();
            foreach (Category category in db.Categories)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = category.CategoryID.ToString();
                lvi.SubItems.Add(category.CategoryName);
                lvi.SubItems.Add(category.Description);
                listView1.Items.Add(lvi);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AddCategory();
        }

        private void AddCategory()
        {
            try
            {
                Category category = new Category();
                category.CategoryName = txtCategoryName.Text;
                category.Description = txtDescription.Text;
                db.Categories.Add(category);
                db.SaveChanges();
                MessageBox.Show(category.CategoryName + " kaydedildi!");
                GetCategories();
                txtCategoryName.Text = "";
                txtDescription.Text = "";
                txtCategoryName.Focus();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
