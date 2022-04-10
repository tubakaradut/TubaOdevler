using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapKafe
{
   public class Icecek:BaseClass
    {
        public Boyut boyut { get; set; }
        public override string ToString()
        {
            return Adi + "  "+ Fiyati;
        }

    }
}
