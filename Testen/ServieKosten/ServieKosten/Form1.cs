using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServieKosten
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            reken();
        }

        public void reken()
        {
            double HarwareKosten = int.Parse(txtHKosten.Text);
            int punten = int.Parse(txtPunten.Text);
            double totalepijs = 0;
            if (rdbParticulier.Checked)
            {
                if (punten == 1)
                {
                    totalepijs = punten * 5;
                }
                else if (punten > 1 && punten <= 5)
                {
                    totalepijs = punten * 3;

                }
                else totalepijs = punten * 2.75;

            }
            totalepijs += HarwareKosten;
            totaal.Text = totalepijs.ToString();
        }
    }
}
