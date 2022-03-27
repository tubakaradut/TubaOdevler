using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFTopSektirme1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int dikeyHiz = 10;
        int yatayHiz = 10;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.D:

                    timerSağ.Start();

                    break;

                case Keys.T:
                    timerYukari.Start();

                    break;

                case Keys.S:

                    timerSağ.Stop();
                    timerYukari.Stop();

                    break;

                default:
                    MessageBox.Show("Hatalı Tuşlama Yaptınız.");

                    break;
            }


        }

        private void timerSağ_Tick(object sender, EventArgs e)
        {
            pbTop.Left += yatayHiz;

            if (pbTop.Right>this.Width)
            {
                yatayHiz = -yatayHiz;
            }

            if (pbTop.Left < 0 )
            {
                yatayHiz = -yatayHiz;
            }
        }

        private void timerYukari_Tick(object sender, EventArgs e)
        {
            pbTop.Top -= dikeyHiz;
            if (pbTop.Bottom>this.Height)
            {
                dikeyHiz = -dikeyHiz;
            }
            if (pbTop.Top<0)
            {
                dikeyHiz = -dikeyHiz;
            }
        }
    }


}