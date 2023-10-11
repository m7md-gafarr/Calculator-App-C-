using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void btnPower_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDot_Click(object sender, EventArgs e)
        {  
            textResult.Text +=  ".";
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            textResult.Text += "0";
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
             if (textResult.Text =="0")
            {
               textResult.Clear();
               
            }
            textResult.Text +=  "1";
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (textResult.Text == "0")
            {
                textResult.Clear();

            }
            textResult.Text += "2";
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            if (textResult.Text == "0")
            {
                textResult.Clear();

            }
            textResult.Text += "3";
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (textResult.Text == "0")
            {
                textResult.Clear();

            }
            textResult.Text += "4";
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (textResult.Text == "0")
            {
                textResult.Clear();

            }
            textResult.Text += "5";
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (textResult.Text == "0")
            {
                textResult.Clear();

            }
            textResult.Text += "6";
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (textResult.Text == "0")
            {
                textResult.Clear();

            }
            textResult.Text += "7";
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (textResult.Text == "0")
            {
                textResult.Clear();

            }
            textResult.Text += "8";
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (textResult.Text == "0")
            {
                textResult.Clear();

            }
            textResult.Text += "9";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textResult.Clear();
            textStore.Clear();
            textResult.Text = "0";
        }


        float number;
        String  op;
        private void btnSubtract_Click(object sender, EventArgs e)
        {
            if (textResult.Text != "")
            {
                number = float.Parse(textResult.Text);
                textStore.Text =textResult.Text + " - ";
                textResult.Clear();
                textResult.Text = "0";
                op = "-";
            }
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            if (textResult.Text != "")
            {
                number = float.Parse((textResult.Text));
                textStore.Text = textResult.Text + " + ";
                textResult.Clear();
                textResult.Text = "0";
                op = "+";
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (textResult.Text != "")
            {
                number = float.Parse(textResult.Text);
                textStore.Text = textResult.Text + " x ";
                textResult.Clear();
                textResult.Text = "0";
                op = "x";
            }
        }

        private void btnPortion_Click(object sender, EventArgs e)
        {
            if (textResult.Text != "")
            {
                number = float.Parse(textResult.Text);
                textStore.Text = textResult.Text + " / ";
                textResult.Clear();
                textResult.Text = "0";
                op = "/";
            }
        }

        private void btnModules_Click(object sender, EventArgs e)
        {
            if (textResult.Text != "")
            {
                number = float.Parse(textResult.Text);
                textStore.Text = textResult.Text + " % ";
                textResult.Clear();
                textResult.Text = "0";
                op = "%";
            }
        }

        float ans = 0;
        private void btneqal_Click(object sender, EventArgs e)
        {
            if (op == "-")
            {
                ans = number- float.Parse(textResult.Text);
                textStore.Text += textResult.Text + " = ";

                textResult.Text = ans.ToString();

                

            }
            if (op == "+")
            {
                ans = number + float.Parse(textResult.Text);
                textStore.Text += textResult.Text + " = ";

                textResult.Text = ans.ToString();

            }
            if (op == "x")
            {
                ans = number * float.Parse(textResult.Text);
                textStore.Text += textResult.Text + " = ";

                textResult.Text = ans.ToString();

            }
            if (op == "/")
            {
                ans = number / float.Parse(textResult.Text);
                textStore.Text += textResult.Text + " = ";

                textResult.Text = ans.ToString();

            }
            if (op == "%")
            {
                ans = number % float.Parse(textResult.Text);
                textStore.Text += textResult.Text + " = ";

                textResult.Text = ans.ToString();

            }

        }

      
    }
}
