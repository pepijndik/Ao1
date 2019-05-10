using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tempratuur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntreken_Click(object sender, EventArgs e)
        {
            int Ctemp = int.Parse(temp.Text);
            int TFahrenheit = (9 * Ctemp / 5) + 32;
            int Tklevin = Ctemp + 273;
            fahren.Text = TFahrenheit.ToString();
            klevin.Text = Tklevin.ToString();
        }
    }
}
