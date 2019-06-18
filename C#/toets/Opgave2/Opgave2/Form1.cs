using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opgave2
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
            
        }
       //Button Plus 
        private void btnPlus_Click(object sender, EventArgs e)
        {
            //haal Getallen op uit het veld
            int getal1 = int.Parse(txtGetal1.Text);
            int getal2 = int.Parse(txtGetal2.Text);
            //Reken Totaal uit
            int totaal = getal1 + getal2;
            txtTotaal.Text = totaal.ToString();
        }
        //Button Min 
        private void btnMin_Click(object sender, EventArgs e)
        {
            //haal Getallen op uit het veld
            int getal1 = int.Parse(txtGetal1.Text);
            int getal2 = int.Parse(txtGetal2.Text);
            //Reken totaal uit
            int totaal = getal1 - getal2;
            txtTotaal.Text = totaal.ToString();
        }
        //Button Keer 
        private void btnKeer_Click(object sender, EventArgs e)
        {
            //haal Getallen op uit het veld
            int getal1 = int.Parse(txtGetal1.Text);
            int getal2 = int.Parse(txtGetal2.Text);
            //Reken totaal uit
            int totaal = getal1 * getal2;
            txtTotaal.Text = totaal.ToString();
        }
        //Button Delen 
        private void btnDelen_Click(object sender, EventArgs e)
        {
            //haal Getallen op uit het veld
            int getal1 = int.Parse(txtGetal1.Text);
            int getal2 = int.Parse(txtGetal2.Text);
            //Reken totaal uit
            int totaal = getal1 / getal2;
            txtTotaal.Text = totaal.ToString();
        }

     
    }
}
