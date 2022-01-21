using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exponent_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int number = int.Parse(txtBoxNum.Text);
            int power = int.Parse(txtBoxPower.Text);

            int sum = number;

            for (int i = 0; i < (power - 1); i++)
            {
                sum = sum * number;
            }
            MessageBox.Show(sum.ToString());
        }
    }
}
