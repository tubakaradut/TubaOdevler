﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFCarpımTablosu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            for (int sayi = 1; sayi <= 10; sayi++)
            {
                for (int i = 1; i <= 10; i++)
                {
                    listBox1.Items.Add(sayi + "  x  " + i + "  =  " + sayi * i);
                }
                listBox1.Items.Add("---------------------");
            }
        }
    }
}
