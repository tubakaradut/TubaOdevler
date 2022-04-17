using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Entity
{
  public  class Week
    {
        public int Id { get; set; }
        public string WeekAd { get; set; }
        public DateTime FirstDay { get; set; }
        public DateTime LastDay { get; set; }

       
        public List<Theater> Theaters { get; set; }

    }
}
