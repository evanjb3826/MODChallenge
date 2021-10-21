using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MODChallenge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double x = 0;
        double y = 0;
        double z = 0;
        double sub = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                x += Math.Pow(i, 2);
                y += i;
            }
            z = Math.Pow(y, 2);
            sub = z - x;
            double cube = Math.Round(Math.Pow(sub, (1.0 / 3.0)));
            if(cube%2 == 0)  {MessageBox.Show("Even");}
            else {MessageBox.Show("Odd"); }
        }
    }
}
