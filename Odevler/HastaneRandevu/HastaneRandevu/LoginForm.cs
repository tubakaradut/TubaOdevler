using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneRandevu
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BransForm br = new BransForm();
            br.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

           RandevuForm rdv = new RandevuForm();
            rdv.Show();
            this.Hide();
        }

    }
}
