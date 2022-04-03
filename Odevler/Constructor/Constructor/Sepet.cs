using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Sepet
    {
        private List<Urun> sepetim = new List<Urun>();

        public decimal ToplamTutar()
        {
            decimal toplamTutar = 0;
            foreach (Urun deger in sepetim)
            {
                toplamTutar += deger.KdvDahilTutar;
            }
            return toplamTutar;
        }
        public void ekle(Urun yeniUrun)
        {
            sepetim.Add(yeniUrun);
        }
    }
}
