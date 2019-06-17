using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6._3
{
    public partial class Form1 : Form
    {
       
      
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBereken_Click(object sender, EventArgs e)
        {
         
                   int aantal = int.Parse(txtAnt.Text);
 
            if(aantal <1 ||aantal > 100){
                txtCash.Text = "geen geldig getaal";
            }

            /* jeugd */
            if (aantal > 20 && rbtnJeug.Checked)
                {
                txtCash.Text = bereken(aantal,8,30).ToString();
                }


            if (aantal < 10 && rbtnJeug.Checked)
            {
                txtCash.Text = bereken(aantal, 8, 0).ToString();
            }


            if (aantal > 10 && aantal< 20 && rbtnJeug.Checked)
            {
                txtCash.Text = bereken(aantal, 8, 15).ToString();
            }

            /* senioren */
            if (aantal > 20 && rbtnSen.Checked)
            {
                txtCash.Text = bereken(aantal, 6, 30).ToString();
            }


            if (aantal < 10 && rbtnSen.Checked)
            {
                txtCash.Text = bereken(aantal, 6, 0).ToString();
            }


            if (aantal > 10 && aantal < 20 && rbtnSen.Checked)
            {
                txtCash.Text = bereken(aantal, 6, 15).ToString();
            }

            /* volwassenen */
            if (rbtnVol.Checked)
            {
                txtCash.Text = bereken(aantal, 10, 0).ToString();
            }

        }
        double bereken(int aantallen,int prijzen,int korting)
        {
            double kortingtotaal = (aantallen * prijzen) / 100 * korting;
            double totaal = (aantallen * prijzen) - kortingtotaal;
            return totaal;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
    }
