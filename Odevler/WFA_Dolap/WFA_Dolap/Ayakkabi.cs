using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Dolap
{
    public class Ayakkabi : Urun
    {
        public string Numara { get; set; }

        public string Renk { get; set; }
        public string Materyal { get; set; }
        public override string Kategori { get { return "Ayakkabi"; } }

        public override string ToString()
        {
            return $"{UrunAdi}, {Materyal}, {Numara}, {Renk},  {Fiyat}";
        }
       

    }
}
