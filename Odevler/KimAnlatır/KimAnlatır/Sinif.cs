using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimAnlatır
{
    public class Sinif
    {
        public string Adi { get; set; }
        public string SoyAdi { get; set; }

        public Sinif() { }
        public Sinif(string ad,string soyad)
        {
            Adi = ad;
            SoyAdi = soyad;
           
        }
        public static List<Sinif> SinifListesi = new List<Sinif>() {
            new Sinif("TUBA", "KARADUT BUĞDAY "),
            new Sinif("SEVİL","AYDIN"),
            new Sinif("AZAD", "MAJIDLI"),
            new Sinif("SILA", "ŞİRİN"),
            new Sinif("UMUT", "YILBAŞ"),
            new Sinif("SARUHAN MERT", "DEMİRAY"),
            new Sinif("ONUR", "DOĞRU"),
            new Sinif("EMRE", "BEKTASOĞLU"),
            new Sinif("ENES", "SERENLİ"),
            new Sinif("FURKAN SEMİH", "GÜNEŞ"),
            new Sinif("KAAN", "ÜNAL"),
            new Sinif("BAHADIR", "ARDA"),
            new Sinif("BURAK", "UYSAL"),
            new Sinif("AHMET CANER", "TATLI"),
            new Sinif("MAHMURE", "OKAN"),
            new Sinif("ARYA", "KAPIKIRAN"),
            new Sinif("BERK", "BASAT"),
            new Sinif("EDEBALİ MERT","ATALAY"),
            new Sinif("MERT","ÇINAR"),
            new Sinif("ALİ","ÇUKUR") };

        public override string ToString()
        {
            return Adi+" "+ SoyAdi;
        }

    }
}
