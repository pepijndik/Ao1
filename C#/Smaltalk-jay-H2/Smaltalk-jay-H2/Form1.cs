using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smaltalk_jay_H2
{
    public partial class Smalltalk : Form
    {
        public Smalltalk()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mooi weertje vandaag");
        }

        private void Smalltalk_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Maar morgen wordt regen voorspeld");
        }
    }
}
