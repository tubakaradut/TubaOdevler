using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneRandevu
{
    public class Randevu
    {
        public string HastaAd { get; set; }
        public string HastaSoyad { get; set; }

        public string AdSoyad
        {
            get
            {
                return HastaAd+" "+ HastaSoyad;
            }
        }
        public static List<Randevu> RandevuListesi = new List<Randevu>();

        public string Tckn { get; set; }
        public Doktor Doktor { get; set; }

        public Brans Brans { get; set; }

       
        public static string Bilgi { get; set; }

        public DateTime RandevuTarihi { get; set; }

        public string RandevuSaati { get; set; }


        public override string ToString()
        {
            return $" {Tckn},{HastaAd},{HastaSoyad},{RandevuTarihi},{RandevuSaati}";
        }

    }
}
