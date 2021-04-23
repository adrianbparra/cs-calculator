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

        }

        private bool ValidateCalculation()
        {
            bool output = true;

            /// TODO - get values from labelCalculation and connect it with labelAnswer

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
        private void buttonClear_Click(object sender, EventArgs e)
        {
            labelAnswer.Text = "";
            labelCalculation.Text = "";
        }
    }
}
