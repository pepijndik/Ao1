using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tekst_Plakken
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Vnaam = txtVnaam.Text;
            string Achternaam = txtAnaam.Text;
            string Woonplaats = txtWoonplaats.Text;
            txtEind.Text = Vnaam + " " + Achternaam + " " + Woonplaats;
        }
    }
}
