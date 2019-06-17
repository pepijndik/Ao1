using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int tafel = int.Parse(txtTafel.Text);



            Lbox.Items.Clear();
            for (int teller = 1; teller <=10; teller++)
            {
                int som = tafel * teller;
                int uit = som * tafel;


                Lbox.Items.Add(tafel+("X")+(teller)+("=")+(uit));
            }
        }
    }
}
