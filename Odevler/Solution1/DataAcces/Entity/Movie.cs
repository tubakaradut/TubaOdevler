using System.Collections.Generic;

namespace DataAcces.Entity
{
    public partial class Movie
    {
        public int Id { get; set; }
        public string MovieName { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }

      
        //Bir filmin birden çok tiyatrosu olur...
        public List<Theater> Theaters { get; set; }


        //Bir filmin birden çok kategorisi olur...       
        public List<MovieCategory> MoviesCategories { get; set; }
    }
}
