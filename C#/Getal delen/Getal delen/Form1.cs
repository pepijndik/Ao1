using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Getal_delen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBereken_Click(object sender, EventArgs e)
        {
            int getal = int.Parse(txtGetal.Text);
            double delen = getal / 3;
            double vijfvoud = getal * 5;
            txtGedeeld.Text = delen.ToString();
            txtVijf.Text = vijfvoud.ToString();
        }
    }
}
