using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kwad = int.Parse(txtKwad.Text);



            lbKwadraaten.Items.Clear();
            for (int teller = 1; teller <= kwad; teller++)
            {

                int som = teller * teller;
                


     lbKwadraaten.Items.Add(" Het kwadraat van " + teller + " is " + som);

            }
        }
    }
}
