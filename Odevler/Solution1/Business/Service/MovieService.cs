using DataAcces.Context;
using DataAcces.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Service
{
    public class MovieService
    {
        ProjeContext db = new ProjeContext();
        public string CreatedMovie(Movie movie)
        {
            try
            {
                db.Movies.Add(movie);
                db.SaveChanges();
              
                return $"eklendi";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string DeleteMovie(int Id)
        {
            try
            {
                Movie deleted = db.Movies.Find(Id);
                db.Movies.Remove(deleted);
                db.SaveChanges();

                return $"silindi";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string UpdateMovie(Movie movie)
        {
            try
            {
                //var x = db.Movies.Find(movie.Id);
                //db.Entry(x).CurrentValues.SetValues(movie);
                db.Entry(movie).State = System.Data.Entity.EntityState.Modified;

                db.SaveChanges();

                return $"guncellendi";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Movie> MoviesList()
        {
            return db.Movies.ToList();
        }
    }
}
