using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFKuzeyYeli.Entity;

namespace WFKuzeyYeli
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        ProjeContext.ProjeContext db = new ProjeContext.ProjeContext();
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (User user in db.Users)
            {
                if (user.Username==textBox1.Text && user.Password==textBox2.Text)
                {
                    Form1 f= new Form1();
                    f.Show();
                    this.Hide();
                }
            }
        }
    }
}
