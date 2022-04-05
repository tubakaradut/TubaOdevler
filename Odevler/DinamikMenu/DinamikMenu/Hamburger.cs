using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinamikMenu
{
    public class Hamburger : Urun
    {
        public Boyut Boyut { get; set; }

        public static List<Hamburger> hamburgerListesi = new List<Hamburger>();

        public override string Ekle()
        {
            hamburgerListesi.Add(new Hamburger()
            { 
               Adi=Adi,
               Fiyati=Fiyati,
            
            });

            return $"{Adi} menu eklendi";
        }

        public override string Guncelle(int index)
        {
          
            {
                Hamburger hamburger =hamburgerListesi[index];
                hamburger.Adi = Adi;
                hamburger.Fiyati = Fiyati;
                

            };

            return $"{Adi} menu guncelledi";
        }


        public override string ToString()
        {
            return $"{Adi } {Fiyati} TL";
        }
    }
}
