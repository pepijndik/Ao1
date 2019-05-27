using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace opdracht5._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSorteer_Click(object sender, EventArgs e)
        {
            double getal1 = int.Parse(txtGetal1.Text);
            double getal2 = int.Parse(txtGetal2.Text);
            double getal3 = int.Parse(txtGetal3.Text);
           

            //kijk of getal 1 het kleinst is 
            if(getal1 < getal2 && getal1 < getal3)
            {
                txtKlein.Text = getal1.ToString();
            }
            //Kijk of getal 2 het kleinst is
           if(getal2 < getal1 && getal2 < getal3)
            {
                txtKlein.Text = getal2.ToString();
            }
            //kijk of getal drie het kleinst is
            if (getal3 < getal1 && getal3 < getal2)
            {
                txtKlein.Text = getal3.ToString();
            }
            //Kijk welk getal het grootste is

            //kijk of getal 1 het groots is 
            if (getal1 > getal2 && getal1 > getal3)
            {
                txtGroot.Text = getal1.ToString();
            }
            //Kijk of getal 2 het groots is
            if (getal2 > getal1 && getal2 > getal3)
            {
                txtGroot.Text = getal2.ToString();
            }
            //kijk of getal drie het groots is
            if (getal3 > getal1 && getal3 > getal2)
            {
                txtGroot.Text = getal3.ToString();
            }
        }
    }
}
