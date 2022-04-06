using System.Collections.Generic;

namespace WFA_McAdam
{
    public class Siparis : ICrudRepository
    {
       
        public decimal BoyutFiyat { get; set; }
        public int AdetSayisi { get; set; }
        public Menuu Menuu { get; set; }
        public List<Ekstra> Ekstralar { get; set; }

        public static List<Siparis> SiparisListesi = new List<Siparis>();

        public void Ekle(object obj)
        {
            Siparis siparis = (Siparis)obj;

            SiparisListesi.Add(siparis);
        }

        public void Sil()
        {
            SiparisListesi.Clear();
        }
    }
}
