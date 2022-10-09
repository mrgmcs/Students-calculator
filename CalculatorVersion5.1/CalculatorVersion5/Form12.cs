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
    public partial class primefrm : Form
    {
        public primefrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int num1;
            int num2 = 0;
            int i;
            num1 = Convert.ToInt32(textBox1.Text);
            for (i = 1; i <= num1; i++)
            {
                if (num1 % i == 0)
                    num2 = num2 + 1;
            }
            if (num2 == 2)
                MessageBox.Show("This is a prime number");
            else
                MessageBox.Show("This is not prime number");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
