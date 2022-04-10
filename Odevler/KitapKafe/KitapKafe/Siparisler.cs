using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitapKafe
{
    public partial class Siparisler : Form
    {
        public Siparisler()
        {
            InitializeComponent();
        }

        decimal ciro = 0;
        decimal ekstraMalzemeGeliri = 0;
        int satisAdet = 0;

        private void Siparisler_Load(object sender, EventArgs e)
        {

            int toplamAdet = 0;

            string format = "";
            if (Siparis.siparisListesi.Count > 0)
            {
                foreach (Siparis siparis in Siparis.siparisListesi)
                {

                    if (siparis.SeciliKitap != null)
                    {
                        if (siparis.EkitapListesi != null && siparis.EkitapListesi.Count > 0)
                        {
                            foreach (KitapEkstra ekstra in siparis.EkitapListesi)
                            {
                                format =siparis.SeciliKitap.Kitapadi+ " Kitabı"+" Fiyatı: " + siparis.SeciliKitap.Fiyati+" TL, " + ekstra.Adi +" " +ekstra.Fiyati+" TL, "+"Adet: "+siparis.Adet+", Toplam Tutar: "+ siparis.ToplamTutar+" TL";
                                ekstraMalzemeGeliri += ekstra.Fiyati*siparis.Adet;
                                ciro += siparis.ToplamTutar ;
                                lstSiparis.Items.Add(format);
                            }
                        }
                        else if (siparis.EkitapListesi != null && siparis.EkitapListesi.Count < 1)
                        {
                            format =siparis.SeciliKitap.Kitapadi+ "Kitabı " + " Fiyatı: " + siparis.SeciliKitap.Fiyati + " TL, " + " Adet: " + siparis.Adet +", Toplam Tutar: " + siparis.ToplamTutar+" TL";
                            ciro += siparis.ToplamTutar ;
                            lstSiparis.Items.Add(format);
                        }
                       
                        toplamAdet+= siparis.Adet;
                    }

                   else if (siparis.SeciliIcecek != null)
                    {
                        if (siparis.SeciliIcecek != null && siparis.EIceceklistesi.Count > 0)
                        {
                            foreach (IcecekEkstra ekstra in siparis.EIceceklistesi)
                            {
                                format ="İçecek: "+ siparis.SeciliIcecek.Adi+", Fiyatı: "+ siparis.SeciliIcecek.Fiyati+" TL, " + siparis.SeciliIcecek.boyut+" Boy, " + ekstra.Adi +" "+ ekstra.Fiyati+" TL, "+"Adet: " +siparis.Adet+", Toplam Tutar: " + siparis.ToplamTutar+" TL";
                                ekstraMalzemeGeliri += ekstra.Fiyati*siparis.Adet;
                                ciro += siparis.ToplamTutar;
                                lstSiparis.Items.Add(format);
                            }
                        }
                        else if (siparis.SeciliIcecek != null && siparis.EIceceklistesi.Count < 1)
                        {
                            format = "İçecek: " + siparis.SeciliIcecek.Adi + ", Fiyatı: " + siparis.SeciliIcecek.Fiyati + " TL, " + siparis.SeciliIcecek.boyut +" Boy, "+ "Adet: " + siparis.Adet + ", Toplam Tutar: "+ siparis.ToplamTutar+" TL";
                            ciro += siparis.ToplamTutar ;
                            lstSiparis.Items.Add(format);
                        }
                       
                        toplamAdet += siparis.Adet;
                    }
                    ekstraMalzemeGeliri *= siparis.Adet;
                    satisAdet += siparis.Adet;
                
                    lblCiro.Text = ciro.ToString("C2");
                    lblEkstraGelir.Text = ekstraMalzemeGeliri.ToString();
                    lblSatilanUrunAdet.Text = satisAdet.ToString();
                    lblToplamSiparis.Text = lstSiparis.Items.Count.ToString();

                }
            }
        }
    }
}

