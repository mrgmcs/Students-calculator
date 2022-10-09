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
    public partial class frmgcd : Form
    {
        private int GCD(int x, int y)
        {
            if (y == 0) return x;
            else return GCD(y, x % y);
        }
        public frmgcd()
        {
            InitializeComponent();
        }
        private void txt2_click(object sender, EventArgs e)
        {
            //textBox1.Enabled = false;
        }
        private void Button_Click(object sender, EventArgs e)
        {/*  hazf
            Button s=sender as Button;
            if (textBox1.Enabled)
            { textBox1.Text = textBox1.Text + s.Text; }
            else if (textBox1.Enabled==false)
            { textBox2.Text = textBox2.Text + s.Text; }
            double n1 = double.Parse(textBox1.Text);
            if (n1 >= 1)
            {
                textBox2.Enabled = true;
            }
            else if (n1.ToString()=="")
            {
                textBox2.Enabled = false;
                textBox1.Enabled = true;
            }
            */
        }

        private void btngcd_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(textBox1.Text);
            int y = Convert.ToInt16(textBox2.Text);
            lblresult.Text = "GCD = " + GCD(x, y).ToString();
        }

        private void btnlcm_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(textBox1.Text);
            int y = Convert.ToInt16(textBox2.Text);
            lblresult.Text = "LCM = " + (x * y / GCD(x, y)).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
          //  textBox1.Enabled =true;
            textBox2.Text = ""; //textBox2.Enabled = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {/*  hazf
            Int64 n1=Int64.Parse(textBox1.Text);
            if (n1>=0)
            {
                textBox2.Enabled = true;
            }
          * */
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
