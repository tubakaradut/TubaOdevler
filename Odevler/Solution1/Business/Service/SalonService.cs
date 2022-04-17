using DataAcces.Context;
using DataAcces.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Service
{
   public class SalonService
    {
        ProjeContext db = new ProjeContext();

        public string CreateSalon(Salon salon)
        {
            try
            {
                db.Salons.Add(salon);
                db.SaveChanges();

                return $"eklendi";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string DeleteSalon(int Id)
        {
            try
            {
                Salon deleted = db.Salons.Find(Id);
                db.Salons.Remove(deleted);
                db.SaveChanges();

                return $"silindi";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string UpdateSalon(Salon salon)
        {
            try
            {
                //var x = db.Salons.Find(salon.Id);
                //db.Entry(x).CurrentValues.SetValues(salon);

                db.Entry(salon).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();


                return $"guncellendi";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public List<Salon> SalonsList()
        {
            return db.Salons.ToList();
        }
    }
}
