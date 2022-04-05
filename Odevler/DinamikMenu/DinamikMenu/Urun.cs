using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinamikMenu
{
  public abstract  class Urun
    {

        public string Adi { get; set; }
        public decimal Fiyati { get; set; }

        public abstract string Ekle();
        public abstract string Guncelle(int indeks);
        

    }
}
