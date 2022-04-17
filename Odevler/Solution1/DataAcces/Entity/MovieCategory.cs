using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Entity
{
    public class MovieCategory
    {
        //public MovieCategory(int movieId,int categoryId)
        //{
        //    Movie.Id = movieId;
        //    Category.Id = categoryId;
        //}

        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
