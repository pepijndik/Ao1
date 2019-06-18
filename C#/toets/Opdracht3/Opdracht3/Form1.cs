using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }

        private void nmr_ValueChanged(object sender, EventArgs e)
        {
         
            // Set the Minimum, Maximum, and initial Value.
            nmr.Maximum = 2500;
            nmr.Minimum = 1;
          
          }
        //Set Calculation 
        private void btnStart_Click(object sender, EventArgs e)
        {
            
            lbx1.Items.Clear();
            if (txtInVoer.Text == "")
            {
                lbx1.Items.Add("Geen invoer! Pepijn dik");
            }
            else
            {
                int aantal = int.Parse(txtInVoer.Text);
                for (int i = 0; i < aantal; i++)
                {
                    int x = i;
                    lbx1.Items.Add(i + " " + bereken(aantal, x));
                }
                double bereken(double aantallen, double y)
                {
                    
                    double totaal = Math.Pow(aantallen,y);
                    return totaal;
                }

            }
        }
    }

      
 }

