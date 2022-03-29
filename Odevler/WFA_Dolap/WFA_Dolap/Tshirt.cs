using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Dolap
{
    public class Tshirt : Urun
    {
        public string Beden { get; set; }

        public string Renk { get; set; }
        public string Kalip { get; set; }
        public override string Kategori { get { return "Tshirt"; } }
        public override string ToString()
        {
            return $"{UrunAdi}, {Beden}, {Renk}, {Kalip}, {Fiyat}";

        }

    }
}
