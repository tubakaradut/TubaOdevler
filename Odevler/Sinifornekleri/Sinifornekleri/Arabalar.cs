using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinifornekleri
{
    class Arabalar
    {
        public string renk;
        public decimal fiyat;


        private string _model;
        public string Model
        {
            get { return _model; }
            set
            {
                if (value == "Guiletta")
                {
                    _model = value;
                   
                }
                if (value== "Megane")
                {
                    _model = value;
                }
                if (value=="Clio")
                {
                    _model = value;
                }
                if (value == "California")
                {
                    _model = value;
                }
                if (value == "Carrera")
                {
                    _model = value;
                }
                if (value == "Model s")
                {
                    _model = value;
                }
                if (value== "Cayane")
                {
                    _model = value;
                }
                if (value== "159")
                {
                    _model = value;
                }
                if (value== "143")
                {
                    _model = value;
                }
               
            }
        }



        private string _vitesTipi;
        public string VitesTipi
        {
            get { return _vitesTipi; }
            set
            {

                if (value == "Manuel")
                {
                    _vitesTipi = value;
                }
                if (value == "Otomatik")
                {
                    _vitesTipi = value;
                }
            }
        }


        private string _yakit;
        public string Yakit
        {
            get { return _yakit; }
            set
            {
                if (value == "Dizel")
                {
                    _yakit = value;
                }
                if (value == "Benzin")
                {
                    _yakit = value;
                }
                if (value == "Elektrik")
                {
                    _yakit = value;
                }
            }
        }


        private int _yil;
        public int Yil
        {
            get { return _yil; }

            set
            {
                if (value > 2000 && value < 2022)
                {
                    _yil = value;
                }
                else 
                {
                    MessageBox.Show(" Elimizde 2000-2022 model araç bulunmaktadır. Buna dikkat ederek giris yapınız... ");
                }
            }
        }


        private string _marka;
        public string Marka
        {
            get { return _marka; }
            set
            {
                if (value == "Porsche")
                {
                    _marka = value;
                }
                if (value == "Alfa Romeo")
                {
                    _marka = value;
                }
                if (value == "Renault")
                {
                    _marka = value;
                }
                if (value == "Ferrari")
                {
                    _marka = value;
                }
                if (value == "Tesla")
                {
                    _marka = value;
                }
            }
        }








    }
}
