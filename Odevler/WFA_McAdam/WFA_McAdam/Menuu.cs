using System.Collections.Generic;

namespace WFA_McAdam
{
    public class Menuu : BaseClass, ICrudRepository
    {

        public string MenuAdi { get; set; }
        public Boyut Boyut { get; set; }
        public static List<Menuu> MenuListesi = new List<Menuu>();
        public void Ekle(object obj)
        {
            Menuu menu = (Menuu)obj;
            MenuListesi.Add(menu);
        }

        public override string ToString()
        {
            return MenuAdi;
        }
       
    }
}
