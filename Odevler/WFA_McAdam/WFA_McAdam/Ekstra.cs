using System.Collections.Generic;

namespace WFA_McAdam
{
    public class Ekstra : BaseClass,ICrudRepository
    {
        public string EkstraAdi { get; set; }
        public static List<Ekstra> EkstraListesi = new List<Ekstra>();

        public void Ekle(object obj)
        {
            Ekstra ekstra = (Ekstra)obj;
            EkstraListesi.Add(ekstra);
        }

        public override string ToString()
        {
            return EkstraAdi;
        }
    }
}
