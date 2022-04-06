using System;
using System.Windows.Forms;

namespace WFA_McAdam
{
    public partial class EkstraOlustur : Form
    {
        public EkstraOlustur()
        {
            InitializeComponent();
        }

        private void btnEkstraEkle_Click(object sender, EventArgs e)
        {
            Ekstra ekstra = new Ekstra();
            ekstra.EkstraAdi = txtEkstra.Text;
            ekstra.Fiyati = nudEkstraFiyat.Value;

            ekstra.Ekle(ekstra);

            txtEkstra.Text = "";
            nudEkstraFiyat.Value = 0;
        }
    }
}
