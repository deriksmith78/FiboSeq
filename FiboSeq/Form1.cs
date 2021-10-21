using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiboSeq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 3 variables (1st, 2nd, 3rd num)
            int x = 1; int y = 2; int z; int sum=3;
            string div7 = "";
            
            // loop this
            for(int i = 0; i < 18; i++)
            {
                z = x + y;
                if (z % 7 == 0) { div7 += z + "\n"; }
                sum += z;
                lblSequence.Text += z.ToString() + "\n";
                x = y;
                y = z;
            }
            lblSequence.Text += "Sum: " + sum.ToString() + "\n";
            lblSequence.Text += "Divisible by 7: " + div7.ToString() + "\n";

        }
    }
}
