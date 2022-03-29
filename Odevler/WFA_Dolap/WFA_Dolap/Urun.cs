using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Dolap
{
    public class Urun
    {
        public string UrunAdi { get; set; }
        public decimal Fiyat { get; set; }

        public virtual string Kategori { get; set; }

        public decimal KDVDahilFiyat
        {

            get
            {
                return Fiyat * 1.08m;
            }


        }
    }
}