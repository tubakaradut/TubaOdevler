using Business.Service;
using DataAcces.Context;
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
    public partial class FilmlerForm : Form
    {
        public FilmlerForm()
        {
            InitializeComponent();
        }
        MovieService movieService = new MovieService();
        CategoryService categoryService = new CategoryService();
        MovieCategoryService movieCategoryService = new MovieCategoryService();
        public void GetMovieList()
        {
            listView1.Items.Clear();
            List<Movie> moviesListe = movieService.MoviesList();
            foreach (Movie movie in moviesListe)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = movie.Id.ToString();
                lvi.SubItems.Add(movie.MovieName);
                lvi.SubItems.Add(movie.Description);
                lvi.SubItems.Add(movie.Duration.ToString());

                string category = "";
                foreach (var categoryItem in movie.MoviesCategories)
                {
                    //category += $" {categoryItem.CategoryName}";
                }
                lvi.SubItems.Add(category);
                lvi.Tag = movie;
                listView1.Items.Add(lvi);
            }
        }
        private void FilmlerForm_Load(object sender, EventArgs e)
        {
            List<Category> categoriesListe = categoryService.CategoriesList();

            foreach (Category category in categoriesListe)
            {
                checkedListBox1.Items.Add(category.CategoryName);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Movie movie = new Movie();
            Category category1 = new Category();
            MovieCategory movieCategory = new MovieCategory();

           
            movie.MovieName = txtMovieName.Text;
            movie.Description = txtDescription.Text;
            movie.Duration = (int)nmDuration.Value;


            foreach (var checkedItem in checkedListBox1.CheckedItems)
            {
                string selectedCategoryName = checkedItem.ToString();

                category1 = categoryService.SelectedCategory(selectedCategoryName);
                movieCategory.CategoryId = category1.Id;
                movieCategory.MovieId = movie.Id;
                movieCategoryService.CreatedMovieCategory(movieCategory);
                movie.MoviesCategories.Add(movieCategory);
            }

            GetMovieList();

            //List<int> categoryIdList = new List<int>();
            //foreach (var checkedItem in checkedListBox1.CheckedItems)
            //{
            //    string categoryName = checkedItem.ToString();

            //    int categoryId = categoryService.SelectedCategoryId(categoryName);
            //    if (categoryId > 0)
            //    {
            //        categoryIdList.Add(categoryId);
            //    }
            //}

            //Movie returnMovie = movieService.CreatedMovie(movie);

            //foreach (var categoryId in categoryIdList)
            //{

            //}


        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            GetMovieList();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Movie movie = (Movie)listView1.SelectedItems[0].Tag;
            movieService.DeleteMovie(movie.Id);
            GetMovieList();
        }
        Movie guncellencek=new Movie();
        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            guncellencek.MovieName = txtMovieName.Text;
            guncellencek.Description = txtDescription.Text;
            guncellencek.Duration = (int)nmDuration.Value;

            //foreach (var checkedItem in checkedListBox1.CheckedItems)
            //{
            //    string categoryName = checkedItem.ToString();

            //    Category category = categoryService.SelectedCategory(categoryName);

            //    guncellencek.Categories.Add(category);
            //}
            movieService.UpdateMovie(guncellencek);
            GetMovieList();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            guncellencek = (Movie)listView1.SelectedItems[0].Tag;
            txtMovieName.Text = guncellencek.MovieName;
            txtDescription.Text = guncellencek.Description;
            nmDuration.Value = guncellencek.Duration;

            //foreach (var checkedItem in checkedListBox1.CheckedItems)
            //{
            //    string categoryName = checkedItem.ToString();

            //    Category category = categoryService.SelectedCategory(categoryName);

            //    guncellencek.Categories.Add(category);
            //}
        }
    }
}
