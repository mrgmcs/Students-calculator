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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
       
        private void Form4_Load(object sender, EventArgs e)
        {

        }
        bool txtfals = true;
        private void txtbox2_Click(object sender, EventArgs e)
        {
           
            //textBox1.Enabled = false;
            txtfals = false;
        }

        private void Button_click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if (txtfals==true)
                textBox1.Text = textBox1.Text + b.Text;  
               else if (txtfals==false)
                textBox2.Text = textBox2.Text + b.Text;  

        }
        private void d_click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            if (num1>=num2)
            {
                MessageBox.Show("Min number is bigger to Max number");
            }
            else if(num1<=num2)
            {
                generaterandom();
            }

        }

        private void generaterandom()
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            Random ramdom = new Random();
            int resutl = ramdom.Next(num1, num2);
            lblresult.Text = resutl.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = ""; textBox1.Enabled = true;
            textBox2.Text = ""; lblresult.Text = "0";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblresult_Click(object sender, EventArgs e)
        {

        }

      

      

    }
}
