using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Entity
{
    public class Salon
    {
        public int Id { get; set; }
        public string SalonAd { get; set; }
        public int Capasity { get; set; }

        //
      
        //
        public List<Theater> Theaters { get; set; }
    }
}
