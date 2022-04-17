using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Entity
{
    public class Session
    {
        public int Id { get; set; }
        public string Duration { get; set; }

        //
      
        //
        public List<Theater> Theaters { get; set; }
    }
}
