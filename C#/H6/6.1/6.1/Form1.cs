using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int score = int.Parse(txtScore.Text);

            if (score <= 5)
            {
                txtRes.Text = "niet geslaagd".ToString();
               

            }

            else
            {


                switch (score)
                {
                    case 5:
                        txtRes.Text = "geslaagd".ToString(); 
                        break;

                    case 6:
                        txtRes.Text = "voldoende".ToString();
                        break;


                    case 7:
                        txtRes.Text = "onderscheiding".ToString();
                        break;

                    case 8:
                        txtRes.Text = "grotte onderscheiding".ToString();
                        break;


                    case 9:
                        txtRes.Text = "grootste onderscheiding".ToString();
                        break;



                    case 10:
                        txtRes.Text = "Cum Laude".ToString();
                        break;
                        

                }

                if(score >= 11){
                    txtRes.Text = "ongeldig cijfer".ToString();

                }


            }

           

        }
    }
}
