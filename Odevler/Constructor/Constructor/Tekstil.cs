using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Tekstil:Urun
    {
        public string KumasTuru { get; set; }
        public string UreticiFirma { get; set; }
        public short Beden { get; set; }

       

        public Tekstil(string ad,decimal fiyat,string kumasturu,short beden,string ureticiFirma)
        {
            UrunAdi = ad;
            Fiyati = fiyat;
            KumasTuru = kumasturu;
            Beden=beden;
            UreticiFirma = ureticiFirma;

        }

        public override decimal KdvDahilTutar => Fiyati*1.25m;

        public override string ToString()
        {
            return $"Adi: {UrunAdi},Fiyatı: {Fiyati},Kumas Türü: {KumasTuru},Beden: {Beden},Uretici Firma: {UreticiFirma}";
        }




    }
}
