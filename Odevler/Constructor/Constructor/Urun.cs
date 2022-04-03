using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Urun
    {
        public string UrunAdi { get; set; }

        public decimal Fiyati { get; set; }


       



        public virtual decimal KdvDahilTutar
        {
            get
            {
                return Fiyati * 1m;
            }

        }

        public Urun()
        {

        }
        public Urun(string adi,decimal fiyati)
        {
            UrunAdi = adi;
            Fiyati = fiyati;
        }


    }
}
