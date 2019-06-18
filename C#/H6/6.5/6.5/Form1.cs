using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double Kilo = double.Parse(txtKg.Text);
            double Meter = double.Parse(txtM.Text);

            double M2 = Meter * Meter;

            double BMI = Kilo / M2;
            txtBMI.Text = BMI.ToString();

            if(BMI <=18.50)
            {
                txtCat.Text = "Ondergewicht".ToString();
            }
            
            if (BMI >=18.50 && BMI <=24.99)
            {
                txtCat.Text = "Normaal gewicht".ToString();
            }
            
            if (BMI >=25.00 && BMI <= 26.99)
            {
                txtCat.Text = "licht overgewicht".ToString();
            }
            
            if (BMI >=27.00 && BMI <= 29.99)
            {
                txtCat.Text = "matig overgewicht".ToString();
            }

            if (BMI >=30.00 && BMI <= 39.99)
            {
                txtCat.Text = "ernstig overgewicht".ToString();
            }

            if(BMI >=40.00)
            {
                txtCat.Text = "ziekelijk overgewicht".ToString();
            }

         

        }
    }
}
