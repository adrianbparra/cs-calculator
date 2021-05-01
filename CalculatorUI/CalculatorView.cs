using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorUI
{
    public partial class CalculatorView : Form
    {
        public CalculatorView()
        {
            InitializeComponent();
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {

            // if labelCalculation.Text > 0 || labelCalculation != ""
                // split text
                // turn first string to decimal
                // turn labelAnswer to decimal
                // first #  calculate to labelAnswer #

                // save labelCalculation += lableAnswer to db.caclulation
                // save caclulation to db.answer
            if (labelCalculation.Text.Length > 0)
            {
                
            }

            // else
                // do nothing

        }

        private bool ValidateCalculation()
        {
            bool output = true;

            /// TODO - get values from labelCalculation and connect it with labelAnswer

            string[] calculation = labelCalculation.Text.Split(" ");
            string[] operators = { "+", "-", "*", "/" };

            if (Array.IndexOf(operators, calculation[calculation.Length - 1]) >= 0)
            {
                output = false;
            }

            return output;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelAnswer.Text += "1";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            labelAnswer.Text += "2";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            labelAnswer.Text += "3";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            labelAnswer.Text += "4";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            labelAnswer.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            labelAnswer.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            labelAnswer.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            labelAnswer.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            labelAnswer.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            labelAnswer.Text += "0";
        }
        private void buttonPeriod_Click(object sender, EventArgs e)
        {
            labelAnswer.Text += ".";
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            labelAnswer.Text = "";
            labelCalculation.Text = "";
        }

        // each time a calc button is pressed if labelCalculation has number
        // add cacl operation
        
        private bool ValidNumbers()
        {   
            
            bool output = true;

            string[] calculation = labelCalculation.Text.Split(" ");


            // check if there is no labelAnswer
            if (labelAnswer.Text.Length < 1)
            {
                
                System.Diagnostics.Debug.WriteLine("ValidNumbers");
                output = false;

            }

            // check if theres is already a operation


            return output;
        }
        private void buttonDivision_Click(object sender, EventArgs e)
        {

            if (ValidNumbers())
            {
                // get value from lableAnswer
                // add it to lableCalculation with the operation
                labelCalculation.Text += " / ";
                // clear out the lableAnswer
            }
           
        }

        private void buttonMultiplication_Click(object sender, EventArgs e)
        {

            if (ValidNumbers())
            {
                labelCalculation.Text += " x ";
            }

        }
    }
}
