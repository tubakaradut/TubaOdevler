using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Constructor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Sepet spt = new Sepet();

            Ekmek ekmek = new Ekmek("Uno",15,"kepekli","105gr");
            Ekmek ekmek2 = new Ekmek("Pazar Ekmeği", 15, "Normal", "200gr");

            Tekstil tekstil = new Tekstil("Etek", 75, "Şile Bezi", 36, "Terzi Ahmet");
            Tekstil tekstil2 = new Tekstil("Elbise", 75, "Kadife", 44, "Terzi Güven");

            CepTelefonu cep = new CepTelefonu("Nokia 3310",1500,"Nokia","Tuslu");
            CepTelefonu cep2 = new CepTelefonu("Poco xyz", 4500, "Poco", "5 kameralı");

            spt.ekle(cep);
            spt.ekle(tekstil);
            spt.ekle(ekmek);

            lstCeptelefonu.Items.Add(cep);
            lstEkmek.Items.Add(ekmek);
            lstTekstil.Items.Add(tekstil);
            lstCeptelefonu.Items.Add(cep2);
            lstEkmek.Items.Add(ekmek2);
            lstTekstil.Items.Add(tekstil2);



        }
    }
}
