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
    public partial class frmtime : Form
    {
        public frmtime()
        {
            InitializeComponent();
        }
       

        private void timer2_Tick(object sender, EventArgs e)
        {
           
        }
        private void timer1_Tick(object sender, EventArgs e)
        {//weekend   day   hour minute second
           // double num1 = double.Parse(textBox1.Text);

          /*  if (textBox1.Text=="")
            {
                textBox1.Text = "0";
            }*/
            switch (cmb.SelectedIndex)
            {
                case 0:
                    {
                       
                        double num1 = double.Parse(textBox1.Text);
                        double rs1 = num1 * 7; l1.Text = "D: " + rs1.ToString();
                        double rs2 = num1 * 7 * 24; l2.Text = "H: " + rs2.ToString();
                        double rs3 = num1 * 7 * 24 * 60; l3.Text = "M: " + rs3.ToString();
                        double rs4 = num1 * 604800; l4.Text = "S: " + rs4.ToString();
                        break;
                    }
                case 1:
                    {
                        double num1 = double.Parse(textBox1.Text);
                        double rs1 = num1 / 7; l1.Text = "W: " + rs1.ToString();
                        double rs2 = num1 * 24; l2.Text = "H: " + rs2.ToString();
                        double rs3 = num1 * 60 * 24; l3.Text = "M: " + rs3.ToString();
                        double rs4 = num1 * 3600 * 24; l4.Text = "S: " + rs4.ToString();
                        break;
                    }
                case 2:
                    {
                        double num1 = double.Parse(textBox1.Text);
                        double rs1 = num1 / 24 / 7; l1.Text = "W: " + rs1.ToString();
                        double rs2 = num1 / 24; l2.Text = "D: " + rs2.ToString();
                        double rs3 = num1 * 60; l3.Text = "M: " + rs3.ToString();
                        double rs4 = num1 * 3600; l4.Text = "S: " + rs4.ToString();   
                        break;
                    }
                case 3:
                    {
                        double num1 = double.Parse(textBox1.Text);
                          double rs1 = num1 / 60 / 24 / 7; l1.Text = "W: " + rs1.ToString();
                          double rs2 = num1 / 60 / 24; l2.Text = "D: " + rs2.ToString();
                          double rs3 = num1 / 60; l3.Text = "H: " + rs3.ToString();
                          double rs4 = num1 * 60; l4.Text = "S: " + rs4.ToString();     
             
                        break;
                    }
                case 4:
                    {
                        double num1 = double.Parse(textBox1.Text);
                       double rs1 = num1 /60/60 / 24 / 7; l1.Text = "W: " + rs1.ToString();
                        double rs2 = num1 / 3600 / 24; l2.Text = "D: " + rs2.ToString();
                        double rs3 = num1 / 3600; l3.Text = "H: " + rs3.ToString();
                        double rs4 = num1 / 60; l4.Text = "M: " + rs4.ToString();
                        break;
                    }
            }
        }
   

      

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmb.Text = "";
            l1.Text = "0";
            l2.Text = "0";
            l3.Text = "0";
            l4.Text = "0";
            textBox1.Text = "";
            timer1.Stop();
          
        }

        private void frmtime_Load(object sender, EventArgs e)
        {

        }

        /* private void Button_Click(object sender, EventArgs e)
         {      hazf
             Button b = sender as Button; string bt = b.Text; string tx = textBox1.Text;
             textBox1.Text = textBox1.Text + b.Text; //Close(frmtime());
             timer1.Start();
         }*/

        private void button1_Click_1(object sender, EventArgs e)
        {

            l1.Text = l2.Text = l3.Text = l4.Text = "0";
            textBox1.Text="";
            cmb.Text="";
            timer1.Stop();
        }

        private void textbox_textchange(object sender, EventArgs e)
        {
            timer1.Start();

        }

       
    }
}
