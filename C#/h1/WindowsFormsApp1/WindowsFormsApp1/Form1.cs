using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public const double PI = 3.141;
        public Form1()
        {
            InitializeComponent();
        }

        private void bereken_Click(object sender, EventArgs e)
        {
            int Straal = int.Parse(straal.Text);

            double OpperVlakte = PI * Straal * Straal;
            double Omtrek = 2* PI * Straal;
            opervlakte.Text = OpperVlakte.ToString();
            omtrek.Text = Omtrek.ToString();
        }
    }
}
