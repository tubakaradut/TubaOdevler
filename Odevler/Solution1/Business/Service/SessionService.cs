using DataAcces.Context;
using DataAcces.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Service
{
    public class SessionService
    {
        ProjeContext db = new ProjeContext();

        public string CreateSession(Session session)
        {
            try
            {
                db.Sessions.Add(session);
                db.SaveChanges();

                return $"eklendi";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
        public string DeleteSession(int Id)
        {
            try
            {
                Session deleted = db.Sessions.Find(Id);
                db.Sessions.Remove(deleted);
                db.SaveChanges();

                return $"silindi";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
        public string UpdateSession(Session session)
        {
            try
            {
                //db.Entry(session).State = System.Data.Entity.EntityState.Modified;

                var x = db.Sessions.Find(session.Id);
                db.Entry(x).CurrentValues.SetValues(session);

                db.SaveChanges();
                return $"guncellendi";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
        public List<Session> SessionsList()
        {
            return db.Sessions.ToList();
        }





    }
}
