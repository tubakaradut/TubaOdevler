using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinamikMenu
{
    public class Ekstra : Urun
    {

        public static List<Ekstra> ekstraListesi = new List<Ekstra>();


        public override string Ekle()
        {
           ekstraListesi.Add(new Ekstra()
            {
                Adi = Adi,
                Fiyati = Fiyati,
                
            });

            return $"{Adi}  ekstra malzemesi eklendi";

        }

        public override string Guncelle(int indeks)
        {
            Ekstra ekstra = ekstraListesi[indeks];

            ekstra.Adi = Adi;
            ekstra.Fiyati = Fiyati;

            return $"{Adi}  ekstra malzemesi güncellendi";
        }

        public override string ToString()
        {
            return $"{Adi} {Fiyati} TL ";     
        }
    }
}
