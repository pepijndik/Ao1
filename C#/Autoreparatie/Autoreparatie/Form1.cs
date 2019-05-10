using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autoreparatie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBereken_Click(object sender, EventArgs e)
        {
            int uur = int.Parse(txtUur.Text);
            int gewerkt = int.Parse(txtGewerkt.Text);
            double onderdelen = int.Parse(txtOnderdelen.Text);

            double totaal = (uur * gewerkt) + onderdelen;
            txtBetalen.Text = totaal.ToString();
        }
    }
}
