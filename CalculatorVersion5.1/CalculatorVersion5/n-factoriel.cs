using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorVersion5
{
    public partial class n_factoriel : Form
    {
        public n_factoriel()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            double n = double.Parse(txt1.Text);
            double b = 1;
            double i = 1;

            while (i < n)
            {
                i++;
                b = b * i;

            }
            if (i >= n)
            {

                lblresult.Text = b.ToString();
            }

            if (n > 170)
            {
                MessageBox.Show("your number is bigger than 170");
            }
        }
    }
}
