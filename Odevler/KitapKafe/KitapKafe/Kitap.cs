using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapKafe
{
  public  class Kitap:BaseClass
    {
        public string Kitapadi { get; set; }
        public string Yazari { get; set; }
        public override string ToString()
        {
            return $"{Kitapadi} {Yazari} {Fiyati}";
        }

    }
}
