using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int Box1 = int.Parse(listBox1.Text);
            int Box2 = int.Parse(listBox2.Text);
            string Schakel = (listBox3.Text);




          
            if (Box1 == 0 && Box2 ==0 && Schakel=="EN")
            {
                txtUit.Text = 0.ToString();
            }

            if (Box1 == 1 && Box2 == 0 && Schakel == "EN")
            {
                txtUit.Text = 0.ToString();
            }


            if (Box1 == 0 && Box2 == 1 && Schakel == "EN")
            {
                txtUit.Text = 0.ToString();
            }

            if (Box1 == 1 && Box2 == 1 && Schakel == "EN")
            {
                txtUit.Text = 1.ToString();
            }




            if (Box1 == 0 && Box2 == 0 && Schakel == "OF")
            {
                txtUit.Text = 0.ToString();
            }

            if (Box1 == 1 && Box2 == 0 && Schakel == "OF")
            {
                txtUit.Text = 1.ToString();
            }


            if (Box1 == 0 && Box2 == 1 && Schakel == "OF")
            {
                txtUit.Text = 1.ToString();
            }

            if (Box1 == 1 && Box2 == 1 && Schakel == "OF")
            {
                txtUit.Text = 1.ToString();
            }





            if (Box1 == 0 && Box2 == 0 && Schakel == "XOF")
            {
                txtUit.Text = 0.ToString();
            }

            if (Box1 == 1 && Box2 == 0 && Schakel == "XOF")
            {
                txtUit.Text = 1.ToString();
            }


            if (Box1 == 0 && Box2 == 1 && Schakel == "XOF")
            {
                txtUit.Text = 1.ToString();
            }

            if (Box1 == 1 && Box2 == 1 && Schakel == "XOF")
            {
                txtUit.Text = 0.ToString();
            }

        }
    }
}
