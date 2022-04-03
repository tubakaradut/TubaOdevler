using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class CepTelefonu:Urun

    {

        public string Marka { get; set; }
        public string Ozellikler { get; set; }


        public CepTelefonu(string adi,decimal fiyat,string marka,string ozellikler)
        {
            UrunAdi = adi;
            Fiyati = fiyat;
            Marka = marka;
            Ozellikler = ozellikler;

        }


        public override decimal KdvDahilTutar => Fiyati*1.16m;
        public override string ToString()
        {
            return $"Adı: {UrunAdi},Fiyatı:{Fiyati},Markası: {Marka},Ozellikleri: {Ozellikler}"; 
        }
    }
}
