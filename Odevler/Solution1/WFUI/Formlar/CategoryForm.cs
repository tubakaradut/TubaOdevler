using Business.Service;
using DataAcces.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFUI.Formlar
{
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        CategoryService categoryService = new CategoryService();
        private void CategoryForm_Load(object sender, EventArgs e)
        {

        }
        public void GetCategoryList()
        {
            listView1.Items.Clear();
            List<Category> categoriesListe = categoryService.CategoriesList();
            foreach (Category category in categoriesListe)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = category.Id.ToString();
                lvi.SubItems.Add(category.CategoryName);
                lvi.Tag = category;
                listView1.Items.Add(lvi);
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            GetCategoryList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryName = txtCategoryName.Text;
            categoryService.CreatedCategory(category);
            GetCategoryList();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Category category = (Category)listView1.SelectedItems[0].Tag;
            categoryService.DeleteCategory(category.Id);
            GetCategoryList();
        }
        Category guncellencek;
        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            guncellencek.CategoryName = txtCategoryName.Text;
            categoryService.Updatecayegory(guncellencek);
            GetCategoryList();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            guncellencek = (Category)listView1.SelectedItems[0].Tag;
            txtCategoryName.Text = guncellencek.CategoryName;
        }
    }
}
