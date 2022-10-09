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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (textBox1.Text == "root and square")
            {
                textBox1.Text = "";
                new frmsqr().ShowDialog();
            }
            if (textBox1.Text=="gcd and lcm")
            {
                textBox1.Text = "";
                new frmgcd().ShowDialog();
            }
            if (textBox1.Text=="time")
            {
                textBox1.Text = "";
                new frmtime().ShowDialog();
            }
            if (textBox1.Text=="random")
            {
                textBox1.Text = "";
                new Form4().ShowDialog();
            }
            if (textBox1.Text=="divisible")
            {
                textBox1.Text = "";
                new dinum().ShowDialog();
            }
            if (textBox1.Text=="prime")
            {
                textBox1.Text = "";
                new primefrm().ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("turn off the CapsLock and enter the Item name.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
           MessageBox.Show("Commands: gcd and lcm, root and square, random, time,  prime, divisible");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
           /* switch (textBox1.Text)
            {
                case "Hack_Code_Form2":
                    {
                        textBox1.Text = "";
                        break;
                    }*/
            }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
        }
    }

