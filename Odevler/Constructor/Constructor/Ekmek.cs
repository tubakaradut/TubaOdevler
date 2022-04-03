using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Ekmek:Urun
    {
        public string EkmekTuru { get; set; }
        public string Gramaji { get; set; }



        public Ekmek(string ad,decimal fiyat ,string ekmekTuru,string gramaj)
        {
            UrunAdi = ad;
            Fiyati = fiyat;
            EkmekTuru = ekmekTuru;
            Gramaji = gramaj;
        }

        public override decimal KdvDahilTutar => Fiyati*1.02m;
        public override string ToString()
        {
            return $"Adı: {UrunAdi},Fiyatı: {Fiyati},Ekmek Türü: {EkmekTuru},Gramajı: {Gramaji}";     
        }
    }
}
