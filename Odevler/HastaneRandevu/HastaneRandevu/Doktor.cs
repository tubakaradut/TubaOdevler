using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneRandevu
{
    public class Doktor
    {
        public string DoktorAdSoyad { get; set; }

        public Brans brans { get; set; }

        public static List<Doktor> DoktorListesi = new List<Doktor>();

        public override string ToString()
        {
            return $"{DoktorAdSoyad}";
        }
    }
}
