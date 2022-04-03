using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsanKaynaklari
{
   public class Personel
    {

        public Personel()
        {
            IseGiris = DateTime.Now;
            PersonelSayisi++;
        }

        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TCKN { get; set; }
        public DateTime IseGiris { get; set; }
        public Departman Departman { get; set; }

        public static int PersonelSayisi { get; set; }

        public static List<Personel> PersonelListesi = new List<Personel>();

        public override string ToString()
        {
            return $"{Ad},{Soyad},{TCKN},{Departman},{IseGiris}";
        }

    }
}
