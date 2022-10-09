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
    public partial class frmsqr : Form
    {
        public frmsqr()
        {
            InitializeComponent();
        }

        private void btnsq_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txt1.Text);
            double result = num1 * num1;
            lblresult.Text = "Square = " + result.ToString();

        }

        private void btnroot_Click(object sender, EventArgs e)
        {
            flsradiobtn();
            double num1 = double.Parse(txt1.Text);

          /*  switch (txt1.Text)
             {
                 case "" :
                     {
                         num1 = 0; txt1.Text = "0";
                         break;
                     }
                case  :
                     {
                         break;
                     }
             }*/
           // double num1 = double.Parse(txt1.Text);
            double result = Math.Sqrt(num1);
            lblresult.Text = "Root = " + result.ToString();
        }

        private void flsradiobtn()
        {

            if (txt1.Text=="")
            {
                radioButton2.Enabled = false;
                radioButton1.Enabled = false;

            }
            else if (txt1.Text!="")
            {
                radioButton2.Enabled = true;
                radioButton1.Enabled = true;
  
            }


        }
        private void btnresult_Click(object sender, EventArgs e)
        {
            flsradiobtn();
            double num1 = double.Parse(textBox1.Text);
            double num2 = double.Parse(textBox2.Text);
            double rt1 = Math.Sqrt(num1);
            double rt2 = Math.Sqrt(num2);
            if (cmb.SelectedIndex==0)//+ - * / min max x^y       144=12
            {
                double result = rt1 + rt2; lblrst.Text = result.ToString(); double rs2 = result * result; lblrs.Text ="√"+ rs2.ToString();
            }
            if (cmb.SelectedIndex==1)
            { double result = rt1 - rt1; lblrst.Text = result.ToString(); double rs2 = result * result;
            lblrs.Text = "√" + rs2.ToString();
            }
            if (cmb.SelectedIndex==2)
            {
                double result = rt1 * rt2; lblrst.Text = result.ToString(); double rs2 = result * result;
                lblrs.Text = "√" + rs2.ToString();
            }
            if (cmb.SelectedIndex==3)
            {
                double result = rt1 / rt2; lblrst.Text = result.ToString(); double rs2 = result * result;
                lblrs.Text = "√" + rs2.ToString();
            }
            if (cmb.SelectedIndex == 4)
            {
                double result = Math.Min(rt1, rt2); lblrst.Text = result.ToString(); double rs2 = result * result;
                lblrs.Text = "√" + rs2.ToString();
            }
            if (cmb.SelectedIndex==5)
            {
                double result = Math.Max(rt1, rt2); lblrst.Text = result.ToString(); double rs2 = result * result;
                lblrs.Text = "√" + rs2.ToString();
            }
            if (cmb.SelectedIndex == 6)
            {
                double result = Math.Pow(rt1, rt2); lblrst.Text = result.ToString(); double rs2 = result * result;
                lblrs.Text = "√" + rs2.ToString();
            }

            
                       
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmsqr_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            cmb.Text = "";
            lblresult.Text = "0";
            lblrs.Text = "00";
            lblrst.Text = "00";
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txt1_click(object sender, EventArgs e)
        {

            radioButton1.Checked = false; radioButton2.Checked = false;
        }

      

        
    }
}
