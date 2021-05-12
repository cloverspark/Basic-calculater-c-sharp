using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calc_Click(object sender, EventArgs e)
        {
            if(isValid(TxtbOperand1.Text, TxtbOperand2.Text) &&
            IsOperator(TxtbSymbol.Text))
            {
                decimal result = calculate(TxtbOperand1.Text, TxtbOperand2.Text);
                TxtbResult.Text = result.ToString("n4");
            }
 
        
           
        }
        private bool IsNaN(string input)
        {
            try
            {
                Convert.ToDecimal(input);
                return true;
            }
            catch
            {
                return false;
            }
        }
        private bool IsOperator(string input)
        {
            if (TxtbSymbol.Text == "/" || TxtbSymbol.Text == "*"
                || TxtbSymbol.Text == "+" || TxtbSymbol.Text == "-")
            {
                return true;
            }
            else
            {
                MessageBox.Show("Operator must be a +, -, *, or a / ",
            "valid");
                return false;
            }
              
        }

        private bool isValid(string input, string input2)
        {
            decimal num1 = Convert.ToDecimal(TxtbOperand1.Text);
            decimal num2 = Convert.ToDecimal(TxtbOperand2.Text);
            if (!IsNaN(TxtbOperand1.Text) )
            {
                MessageBox.Show("Operand1  must be a number",
            "valid");
                return false;
                
            }
            if (!IsNaN(TxtbOperand2.Text))
            {
                MessageBox.Show("Operand2  must be a number",
            "valid");
                return false;

            }
            if (num1 > 1000000)
            {
                MessageBox.Show("Operand1  must be smaller than 1000000",
            "valid");
                return false;

            }
            if (num1 < 0)
            {
                MessageBox.Show("Operand1  must be bigger than 0",
            "valid");
                return false;

            }
            if (num2 < 0)
            {
                MessageBox.Show("Operand2  must be bigger than 0",
            "valid");
                return false;

            }
            if (num2 > 1000000)
            {
                MessageBox.Show("Operand2  must be smaller than 1000000",
            "valid");
                return false;

            }
            if (TxtbOperand2.Text == "0")
            {
                MessageBox.Show("Operand2 must not be a 0",
            "valid");
                return false;
            }
            
            return true;
        }
        public decimal calculate(string n1, string n2)
        {
            decimal num1 = Convert.ToDecimal(TxtbOperand1.Text);
            decimal num2 = Convert.ToDecimal(TxtbOperand2.Text);
            
            if(TxtbSymbol.Text == "/") 
            {
                return num1 / num2;
            }
            if (TxtbSymbol.Text == "*")
            {
                return num1 * num2;
            }
            if (TxtbSymbol.Text == "+")
            {
                return num1 + num2;
            }
            if (TxtbSymbol.Text == "-")
            {
                return num1 - num2;
            }
            return 0;
            

        }
        private void exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void TxtbOperand1_MouseClick(object sender, MouseEventArgs e)
        {
            TxtbOperand1.Text = "";
        }

        private void TxtbOperand2_MouseClick(object sender, MouseEventArgs e)
        {
            TxtbOperand2.Text = "";
        }

        private void TxtbSymbol_MouseClick(object sender, MouseEventArgs e)
        {
            TxtbSymbol.Text = "";
        }
    }
}
