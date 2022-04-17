using DataAcces.Context;
using DataAcces.Entity;
using System;

namespace Business.Service
{
    public class MovieCategoryService
    {
        ProjeContext db = new ProjeContext();

        public string CreatedMovieCategory(MovieCategory movieCategory)
        {
            try
            {
                db.MoviesCategories.Add(movieCategory);
                db.SaveChanges();
                return $"eklendi";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }

        }
    }
}
