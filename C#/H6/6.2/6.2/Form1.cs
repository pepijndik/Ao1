using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Bru = int.Parse(txtBru.Text);
            int Art = int.Parse(txtArt.Text);
            int totaal = 0; 

            if (Art <= 10)
            {
                totaal = Bru / 100 * 2 + Bru;
            }

            if((Art >=10) && (Art <=50))
            {
                totaal = Bru / 100 * 5 + Bru;
            }
                 

            if(Art >= 50)
            {
                totaal = Bru / 100 * 10 + Bru;
            }

            txtLoon.Text = totaal.ToString();


        }
    }
}
