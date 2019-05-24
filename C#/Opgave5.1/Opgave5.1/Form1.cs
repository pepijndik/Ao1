using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opgave5._1
{
    public partial class Form1 : Form
    {
        public const double PI = 3.141;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            omtrek();
            oppervlakte();

        }

        public void omtrek()
        {
            int Straal = int.Parse(textStraal.Text);
            double Omtrek = 2 * PI * Straal;
            textOmtrek.Text = Omtrek.ToString();
        }
        public void oppervlakte()
        {
            int Straal = int.Parse(textStraal.Text);
            double OpperVlakte = PI * Straal * Straal;
            textOppervlakte.Text = OpperVlakte.ToString();
        }
    }
}
