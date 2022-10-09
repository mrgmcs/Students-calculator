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
    public partial class frmclc : Form
    {
        bool f2 = false;
        bool resultneshan = false;

        public frmclc()
        {
            InitializeComponent();
        //    bool f2 = false;

        }

        private void textbox2_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;

        }


        //amaliat:
        private void btnjame_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                textBox1.Text = "0";
            cmb.SelectedIndex = 0;
            textBox1.Enabled = false;
            label1.Text = "+";
            if (f2==true)
            {
                if (resultneshan == true)
                {
                    textBox1.Text = lblresult.Text;

                } cmb.SelectedIndex = 0;
                textBox1.Enabled = false;
                label1.Text = "+";
                textBox2.Text = "";
                lblresult.Text = "";
            }



        }

        private void btnzarb_Click(object sender, EventArgs e)
        {//+ - * / min max x^y
            if (textBox1.Text == "")
                textBox1.Text = "0";
            cmb.SelectedIndex = 2;
            textBox1.Enabled = false;
            label1.Text = "×";
            if (f2 == true)
            {
                if (resultneshan == true)
                    textBox1.Text = lblresult.Text;
                else ;

                cmb.SelectedIndex = 2;
                textBox1.Enabled = false;
                label1.Text = "×";
                textBox2.Text = "";
                lblresult.Text = "";
            }
        }

        private void btnmenha_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                textBox1.Text = "0";
            cmb.SelectedIndex = 1;
            textBox1.Enabled = false;
            label1.Text = "-";
            if (f2 == true)
            {
                if (resultneshan == true)
                
                    textBox1.Text = lblresult.Text;
                else ;
                cmb.SelectedIndex = 1;
                textBox1.Enabled = false;
                label1.Text = "-";
                textBox2.Text = "";
                lblresult.Text = "";
            }
        }

        private void btntaghsim_Click(object sender, EventArgs e)
        {
       
            if (textBox1.Text == "")
                textBox1.Text = "0";
            cmb.SelectedIndex = 3;
            textBox1.Enabled = false;
            label1.Text = "÷";
            if (f2 == true)
            {
                if (resultneshan==true)
                {
                  textBox1.Text = lblresult.Text;

                }
                else ;
                cmb.SelectedIndex = 3;
                textBox1.Enabled = false;
                label1.Text = "÷";
                textBox2.Text = "";
                lblresult.Text = "";
            }
        }

        private void btnpow_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                textBox1.Text = "0";
            cmb.SelectedIndex = 6;
            textBox1.Enabled = false;
            label1.Text = "^";
            if (f2 == true)
            {
                if (resultneshan == true)
                {
                    textBox1.Text = lblresult.Text;

                }
                else ;
                cmb.SelectedIndex = 6;
                textBox1.Enabled = false;
                label1.Text = "^";
                textBox2.Text = "";
                lblresult.Text = "";
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnmax_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                textBox1.Text = "0";
            cmb.SelectedIndex = 5;
            textBox1.Enabled = false;
            label1.Text = "<";
            if (f2 == true)
            {
                textBox1.Text = lblresult.Text;
                cmb.SelectedIndex = 5;
                textBox1.Enabled = false;
                label1.Text = "<";
                textBox2.Text = "";
                lblresult.Text = "";
            }
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                textBox1.Text = "0";
            cmb.SelectedIndex = 4;
            textBox1.Enabled = false;
            label1.Text = ">";
            if (f2 == true)
            {
                textBox1.Text = lblresult.Text;
                cmb.SelectedIndex = 4;
                textBox1.Enabled = false;
                label1.Text = ">";
                textBox2.Text = "";
                lblresult.Text = "";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            lblresult.Text = "0";
            textBox1.Enabled = true;
            label1.Text = "";

        }

        private void button_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if (textBox1.Enabled)
                textBox1.Text = textBox1.Text + b.Text;
            else if (textBox1.Enabled == false)
                textBox2.Text = textBox2.Text + b.Text;
           if (lblresult.Text=="0"&&b.Text=="0")
                     textBox1.Text = "";   
          
        }
    
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (textBox1.Enabled)
            {
                textBox2.Enabled = false;
            }
            if (textBox1.Enabled == false)
            {
                textBox2.Enabled = true;

            }


        }

        private void txt1_textch(object sender, EventArgs e)
        {
            //  bb.Enabled = true;
        }

        private void numberpadColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
          changnumpad_color();

        }

        private void changnumpad_color()
       { 
            b0.BackColor = colorDialog1.Color;
            b1.BackColor = colorDialog1.Color;
            b2.BackColor = colorDialog1.Color;
            b3.BackColor = colorDialog1.Color;
            b4.BackColor = colorDialog1.Color;
            b5.BackColor = colorDialog1.Color;
            b6.BackColor = colorDialog1.Color;
            b7.BackColor = colorDialog1.Color;
            b8.BackColor = colorDialog1.Color;
            b9.BackColor = colorDialog1.Color;
            if (colorDialog1.Color == Color.Black)
            {
                b1.ForeColor = Color.White;
                b2.ForeColor = Color.White;
                b3.ForeColor = Color.White;
                b4.ForeColor = Color.White;
                b5.ForeColor = Color.White;
                b6.ForeColor = Color.White;
                b7.ForeColor = Color.White;
                b8.ForeColor = Color.White;
                b9.ForeColor = Color.White;
                b0.ForeColor = Color.White;

            }
            else
            {
                b1.ForeColor = Color.Black;
                b2.ForeColor = Color.Black;
                b3.ForeColor = Color.Black;
                b4.ForeColor = Color.Black;
                b5.ForeColor = Color.Black;
                b6.ForeColor = Color.Black;
                b7.ForeColor = Color.Black;
                b8.ForeColor = Color.Black;
                b9.ForeColor = Color.Black;
                b0.ForeColor = Color.Black;
            }
       
       }
        private void btnrs_Click(object sender, EventArgs e)
        {

            resultneshan = true;
            if (textBox2.Text == "")
            {
                textBox2.Text = "0";
            }
             double n1 = double.Parse(textBox1.Text);
            double n2 = double.Parse(textBox2.Text);
            switch (cmb.SelectedIndex)
            {
                case 0:
                    {
                        double rs = n1 + n2; lblresult.Text = rs.ToString();
                        break;
                    }
                case 1:
                    {
                        double rs = n1 - n2; lblresult.Text = rs.ToString(); 
                        break;
                    }
                case 2:
                    {
                        double rs = n1 * n2; lblresult.Text = rs.ToString();
                        break;
                    }
                case 3:
                    {
                        double rs = n1 / n2; lblresult.Text = rs.ToString();
                        break;
                    }
                case 4:
                    {
                        double rs = Math.Min(n1, n2); lblresult.Text = rs.ToString();
                        break;
                    }
                case 5:
                    {
                        double rs = Math.Max(n1, n2); lblresult.Text = rs.ToString();
                        break;
                    }
                case 6:
                    {
                        double rs = Math.Pow(n1, n2); lblresult.Text = rs.ToString();
                        break;
                    }
                    
            }

            if (lblresult.Text!="")
            {
                f2 = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            btnrs.BackColor = Color.Red;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
          //  btnrs.BackColor = Color.Lime;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //
            //new frmsqr().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //
            //new frmgcd().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form4().ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new frmsqr().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void whatCanYouDoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form7().ShowDialog();
        }

        private void reportbugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Applicationmcs@gmail.com");
        }

        private void commandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form8().ShowDialog();
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
          //
            //new Form4().ShowDialog();
        }

        private void buttontime_Click(object sender, EventArgs e)
        {
            //
            //new frmtime().ShowDialog();

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            resultneshan = false;
            textBox1.Enabled = true;
            textBox2.Enabled = false;
            textBox1.Text = "";
            textBox2.Text = "";
           lblresult.Text = "0";
            label1.Text = "";
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void qRBarcodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void qRBarcodeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void reportbugToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }

        private void xyzXydecimalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new dinum().ShowDialog();
        }

        private void cnrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog2.ShowDialog();
            changecolorbg();
        
        }

        private void changecolorbg()
        {
            label1.BackColor = colorDialog2.Color;
            BackColor = colorDialog2.Color;
            menuStrip1.BackColor = colorDialog2.Color;
            lblresult.BackColor = colorDialog2.Color;
           // label1.BackColor = colorDialog1.Color;

            if (colorDialog2.Color==Color.Black)
            {
                lblresult.ForeColor = Color.White;
                menuStrip1.ForeColor = Color.White;
              //  label1.ForeColor = Color.White;

            }
            else if (colorDialog2.Color!=Color.Black)
            {
              lblresult.ForeColor = Color.Black;
                menuStrip1.ForeColor = Color.Black;
            //    label1.ForeColor = Color.Black;
            }
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void frmclc_Load(object sender, EventArgs e)
        {

        }

        private void primeNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new primefrm().ShowDialog();
            //////////////////
        }

        private void numberpadColorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            changnumpad_color();
        }

        private void gCDAndLCMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmgcd().ShowDialog();
        }

        private void findRandomNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form4().ShowDialog();
        }

        private void rootAndSquareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmsqr().ShowDialog();
        }

        private void convertTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmtime().ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new Form9().ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Applicationmcs@gmail.com");
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
         //   label1.BackColor = frmclc.DefaultBackColor;
        }

        private void button6_Click(object sender, EventArgs e)
        {
          //  MessageBox.Show("");
        }

        private void nToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new n_factoriel().ShowDialog();
        }

        private void numcounterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new num_counter().ShowDialog();
        }









    } 
    }

