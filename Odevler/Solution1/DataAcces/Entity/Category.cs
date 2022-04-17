using System.Collections.Generic;

namespace DataAcces.Entity
{
    public partial class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }

     
        //Bir filmin birden çok kategorisi olur...       
        public List<MovieCategory> MoviesCategories { get; set; }
       
    }
}
