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
    public partial class num_counter : Form
    {
        public num_counter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n = double.Parse(textBox1.Text);
            double m = double.Parse(textBox1.Text);
           // m = n;
            double s = 0;
            double a = 0;
            double counter = 0;

            while (n>0)
            {
               s = n % 10;
               a = a + s   ;
               n = (n - s) / 10;

            }
            lblresult1.Text =  a.ToString();
            while (m>=1)
            {
                m = m / 10;
                counter++;

            }
            lblresult2.Text = counter.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

       
    
            
         
    }    
           
         
        }



      
    
