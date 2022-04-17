using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Entity
{
    public class Theater
    {
        public int Id { get; set; }

        public int MovieId { get; set; }
        public int SessionId { get; set; }
        public int SalonId { get; set; }
        public int WeekId { get; set; }

        public Movie Movie { get; set; }
        public Salon Salon { get; set; }
        public Session Session { get; set; }
        public Week Week { get; set; }
    }
}
