using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KimAnlatır
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Konu> konuListesi = new List<Konu>()
        {
           Konu.DEĞİŞKENLER ,
           Konu.OPERATÖRLER,
           Konu.DÖNÜŞÜMLER,
           Konu.HATAYONETİMİ,
           Konu.IF_ELSE,
           Konu.SWİTCH_CASE,
           Konu.DONGULER_WHİLE,
           Konu.DONGULER_FOR,
           Konu.ARRAY,
           Konu.DONGUKACISELEMANLARI,
           Konu.METOTLAR,
           Konu.RUNTİME,
           Konu.RANDOM,
           Konu.ENCAPSULATİON,
           Konu.INHERİTANCE,
           Konu.POLYMORPHİSM,
           Konu.ABSTRUCTİON,
           Konu.CONSTRUCTOR,
           Konu.ENUM,
           Konu.INTERFACE

        };

        Random rnd = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Sinif sinif in Sinif.SinifListesi)
            {
                SınıfListesi.Items.Add(sinif.ToString());
            }

            foreach (Konu konu in konuListesi)
            {
                Konular.Items.Add(konu);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int rastgeleKisi = rnd.Next(0, SınıfListesi.Items.Count);
            int rastgeleKonu = rnd.Next(0, Konular.Items.Count);

            ListViewItem lv = new ListViewItem();

            if (SınıfListesi.Items.Count > 0)
            { string secilenKisi = SınıfListesi.Items[rastgeleKisi].ToString();

                foreach (Sinif sinif in Sinif.SinifListesi)
                {
                    if (secilenKisi == sinif.ToString())
                    {
                        lv.Text = secilenKisi;
                        SınıfListesi.Items.RemoveAt(rastgeleKisi);
                    }
                }
            }
            if (Konular.Items.Count>0)
            {
                string secilenKonu=Konular.Items[rastgeleKonu].ToString();

                foreach (Konu konu in konuListesi)
                {
                    if (secilenKonu==konu.ToString())
                    {
                        lv.SubItems.Add(secilenKonu);
                        listView1.Items.Add(lv);
                        Konular.Items.RemoveAt(rastgeleKonu);
                    }
                }
            }

        }

    }
}