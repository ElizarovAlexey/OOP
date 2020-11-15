using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private string operation;
        private bool isClickEqual = false;
        Calculates calc = new Calculates();
        Memory mem = new Memory();

        public Form1()
        {
            InitializeComponent();
        }

        private void numbers_click(object sender, EventArgs e)
        {
            if (isClickEqual)
            {
                isClickEqual = false;
                displayBox.Clear();
                historyLabel.Text = "";
            }

            Button B = (Button)sender;
            if (displayBox.Text == "0")
            {
                displayBox.Text = B.Text;
            }
            else
            {
                displayBox.Text += B.Text;
            }
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            if (!displayBox.Text.Contains(","))
            {
                displayBox.Text += ",";
            }
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            operation = B.Text;

            // работа с HISTORY
            if (isClickEqual)
                historyLabel.Text = displayBox.Text + operation;
            else
                historyLabel.Text += displayBox.Text + operation;

            calc.PutFirstNumber(double.Parse(displayBox.Text));
            displayBox.Clear();

            if (operation == "√x")
                displayBox.Text = calc.Sqrt().ToString();
            else if (operation == "1/x")
                displayBox.Text = calc.DivOne().ToString();
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            displayBox.Clear();
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            isClickEqual = true;
            historyLabel.Text += displayBox.Text + "=";

            switch (operation)
            {
                case "+":
                    displayBox.Text = calc.Sum(double.Parse(displayBox.Text)).ToString();
                    break;
                case "-":
                    displayBox.Text = calc.Sub(double.Parse(displayBox.Text)).ToString();
                    break;
                case "x":
                    displayBox.Text = calc.Mult(double.Parse(displayBox.Text)).ToString();
                    break;
                case "/":
                    displayBox.Text = calc.Div(double.Parse(displayBox.Text)).ToString();
                    break;
                case "x^y":
                    displayBox.Text = calc.Pow(double.Parse(displayBox.Text)).ToString();
                    break;
                case "%":
                    displayBox.Text = calc.Modulo(double.Parse(displayBox.Text)).ToString();
                    break;
            }
        }

        private void buttonPlusMin_Click(object sender, EventArgs e)
        {
            double number = double.Parse(displayBox.Text);
            displayBox.Text = (-number).ToString();
        }

        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            if (displayBox.Text == "")
                return;
            displayBox.Text = displayBox.Text.Substring(0, displayBox.Text.Length - 1);
            
        }

        private void buttonMC_Click(object sender, EventArgs e)
        {
            mem.MemoryClear();
        }

        private void buttonMR_Click(object sender, EventArgs e)
        {
            displayBox.Text = mem.MemoryShow().ToString();
        }

        private void buttonMplus_Click(object sender, EventArgs e)
        {
            mem.M_Sum(double.Parse(displayBox.Text));
        }

        private void buttonMmin_Click(object sender, EventArgs e)
        {
            mem.M_Sub(double.Parse(displayBox.Text));
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            displayBox.Clear();
            historyLabel.Text = "";
        }
    }
}
