using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneRandevu
{
 public   class Brans
    {
        public static List<Brans> BransListesi = new List<Brans>();

        public string BransAd { get; set; }


        public override string ToString()
        {
            return BransAd;
        }
    }
}
