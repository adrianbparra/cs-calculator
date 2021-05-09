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
        
        private void CalculateOperation(string oper)
        {   
            

            bool answerBool = labelAnswer.Text.Length > 0;
            bool calcBool = labelCalculation.Text.Length > 0;

            // if no answer and number
            // operator should not do anything

            // if both
            // do calculation of answer and number result replace answer plus operator

            string[] calculation = labelCalculation.Text.Split(" ");
            string lastNumber = labelAnswer.Text;

            if (answerBool && calcBool)
            {
                System.Diagnostics.Debug.WriteLine("Both");
                decimal firstNumber = Decimal.Parse(calculation[0]);
                string calcOper = calculation[1];
                decimal newNumber = Decimal.Parse(lastNumber);

                decimal total = 0;
                switch (calcOper)
                {
                    case "+":
                        total = firstNumber + newNumber;
                        
                        break;
                    case "-":
                        total = firstNumber - newNumber;
                        
                        break;
                    case "/":
                        total = firstNumber / newNumber;
                        
                        break;
                    case "x":
                        total = firstNumber * newNumber;

                        break;
                }

                // add total plus oper
                labelCalculation.Text = Convert.ToString(total) + " " + oper;
                labelAnswer.Text = "";

                return;
            }
                
            // if calc
            if (calcBool)
            {
                System.Diagnostics.Debug.WriteLine("calculation");

                // replace the operator
                calculation[calculation.Length - 1] = oper;

                labelCalculation.Text = String.Join(" ",calculation);
                labelAnswer.Text = "";

                return;
            }

            // if answer
            if (answerBool)
            {
                System.Diagnostics.Debug.WriteLine("answer");
                // place number in answer plus the operator pressed
                labelCalculation.Text = labelAnswer.Text + " " + oper;
                labelAnswer.Text = "";

                return;
            }

        }
        private void buttonDivision_Click(object sender, EventArgs e)
        {

            CalculateOperation("/");
            
        }

        private void buttonMultiplication_Click(object sender, EventArgs e)
        {

            CalculateOperation("x");

        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {

            CalculateOperation("-");

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            CalculateOperation("+");

        }
    }
}
