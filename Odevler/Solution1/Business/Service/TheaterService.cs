using DataAcces.Context;
using DataAcces.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Service
{
    public class TheaterService
    {
        ProjeContext db = new ProjeContext();

        public string CreatedTheater(Theater theater)
        {
            try
            {
                db.Theaters.Add(theater);
                db.SaveChanges();
                return $"eklendi.";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public string DeleteTheater(int id)
        {
            try
            {
                Theater deleted = db.Theaters.Find(id);
                db.Theaters.Remove(deleted);
                db.SaveChanges();
                return "Theater silindi!";
            }
            catch (Exception ex)
            {
                return ex.Message; ;
            }
        }

        public string UpdateTheather(Theater theater)
        {
            try
            {
                db.Entry(theater).State = System.Data.Entity.EntityState.Modified;

                db.SaveChanges();
                return "Theather Updated..!";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }


        public List<Theater> TheatersList()
        {
            return db.Theaters.ToList();
        }
    }
}
