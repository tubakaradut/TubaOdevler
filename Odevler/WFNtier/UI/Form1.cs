using Business.Repository;
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

namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        CategoryService categoryService = new CategoryService();
        ProductService productService = new ProductService();
        private void Form1_Load(object sender, EventArgs e)
        {
            //Category category = new Category();
            ////category.CategoryID = 1;
            //category.CategoryName = "Giyim";
            //category.Description = "kıslık giyecekler";
            //categoryService.CreateCategory(category);

            //Category c = new Category();
            //c.CategoryName = "Ayakkanı";
            //c.Description = "kıslık ayakkabılar";
            //categoryService.CreateCategory(c);

            //Category c1 = new Category();
            //c1.CategoryName = "Kozmetik";
            //c1.Description = "kadınlar için";
            //categoryService.CreateCategory(c1);

            //categoryService.DeleteCategory(5);
            //categoryService.DeleteCategory(6);

            //List<Category> liste = categoryService.Categories();

            //Category c = new Category();
            //c.CategoryID = 8;
            //c.CategoryName = "Berkan2";
            //c.Description = "Berkan'ın ayakkabısı";
            //categoryService.UpdateCategory(c);


            //Product p = new Product();
            //p.ProductName = "elma";
            //p.UnitPrice = 5;
            //p.CategoryId = 8;
            //productService.CreateProduct(p);

            //Product p1 = new Product();
            //p1.ProductName = "armut";
            //p1.UnitPrice = 15;
            //p1.CategoryId = 1;
            //productService.CreateProduct(p1);

            //productService.DeleteCProduct(1);

            //Product p = new Product();
            //p.ProductID = 6;
            //p.ProductName = "kivi";
            //p.UnitPrice = 35;
            //p.CategoryId = 6;
            //productService.UpdateProduct(p);

            //Product p2 = new Product();
            //p2.ProductName = "bot";
            //p2.UnitPrice = 40;
            //productService.UpdateProduct(p2);

            //List<Product> listeee = productService.ProductsListesi();

        }
    }
}
