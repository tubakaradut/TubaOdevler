using DataAcces.Context;
using DataAcces.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Service
{
   public class WeekService
    {
        ProjeContext db = new ProjeContext();
        public string CrutedWeek(Week week )
        {
            try
            {
                db.Weeks.Add(week);
                db.SaveChanges();
                return $"eklendi";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
        public string DeleteWeek(int Id)
        {
            try
            {
                Week deleted = db.Weeks.Find(Id);
                db.Weeks.Remove(deleted);
                db.SaveChanges();

                return $"silindi";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        } 
        public string UpdateWeek(Week week)
        {
            try
            {
                //var x = db.Weeks.Find(week.Id);
                //db.Entry(x).CurrentValues.SetValues(week);

                db.Entry(week).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                return $"güncellendi";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public List<Week> WeeksList()
        {
            return db.Weeks.ToList();
        }
    }
}
