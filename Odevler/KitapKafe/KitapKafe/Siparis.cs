using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapKafe
{
    public class Siparis
    {
        public Kitap SeciliKitap { get; set; }
        public Icecek SeciliIcecek { get; set; }

        public int Adet { get; set; }
      
        public decimal ToplamTutar { get; set; }

        public List<KitapEkstra> EkitapListesi { get; set; }
        public List<IcecekEkstra> EIceceklistesi { get; set; }

        public decimal IcecekHesapla()
        {
            ToplamTutar = 0;

            ToplamTutar += SeciliIcecek.Fiyati;

            switch (SeciliIcecek.boyut)
            {
                case Boyut.Küçük:
                    ToplamTutar += 0;

                    break;
                case Boyut.Orta:
                    ToplamTutar += 3;

                    break;
                case Boyut.Büyük:
                    ToplamTutar += 5;

                    break;
            }


            foreach (IcecekEkstra ekstra in EIceceklistesi)
            {
                ToplamTutar += ekstra.Fiyati;
            }

            return ToplamTutar *= Adet;
        }
        public decimal KitapHesapla()
        {
            ToplamTutar = 0;

            ToplamTutar += SeciliKitap.Fiyati;


            foreach (KitapEkstra ekstra in EkitapListesi)
            {
                ToplamTutar += ekstra.Fiyati;
            }

            return ToplamTutar *= Adet;
        }

        public string Icecekyaz()
        {
            if (EIceceklistesi.Count < 1)
            {
                return $"{SeciliIcecek} Menu, {Adet} Adet, {SeciliIcecek.boyut.ToString()} Toplam: {ToplamTutar.ToString("C2")}";
            }
            else
            {
                string ekstraBilgi = "";
                foreach (IcecekEkstra ekstra in EIceceklistesi)
                {
                    ekstraBilgi += ekstra.Adi + " ";
                }
                ekstraBilgi = ekstraBilgi.Trim();

                return $"{SeciliIcecek} TL , {Adet} Adet, {SeciliIcecek.boyut.ToString()} Boy , Ekstra: ({ekstraBilgi}), Toplam: {ToplamTutar.ToString("C2")}";
            }

        }
        public string Kitapyaz()
        {
            if (EkitapListesi.Count < 1)
            {
                return $"{SeciliKitap} TL, {Adet} Adet, Toplam: {ToplamTutar.ToString("C2")}";
            }
            else
            {
                string ekstraBilgi = "";
                foreach (KitapEkstra ekstra in EkitapListesi)
                {
                    ekstraBilgi += ekstra.Adi + " ";
                }
                ekstraBilgi = ekstraBilgi.Trim();

                return $"{SeciliKitap} TL , {Adet} Adet,  Ekstra: ({ekstraBilgi}), Toplam: {ToplamTutar.ToString("C2")}";
            }
        }
        public static List<Siparis> siparisListesi = new List<Siparis>();
        
        public void Ekle(object obj)
            {
                Siparis siparis = (Siparis)obj;

                siparisListesi.Add(siparis);
            }
            public void Sil()
            {
                siparisListesi.Clear();
            }
        }
    }