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
        Calculates C;
        Errors E;
        int k;

        public Form1()
        {
            InitializeComponent();
            C = new Calculates();
            displayBox.Text = "";
        }

        private bool CanPress()
        {
            if (!buttonMult.Enabled)
                return false;

            if (!buttonDiv.Enabled)
                return false;

            if (!buttonSum.Enabled)
                return false;

            if (!buttonSubtraction.Enabled)
                return false;

            if (!buttonSqrt.Enabled)
                return false;

            if (!buttonPow.Enabled)
                return false;

            if (!buttonDivOne.Enabled)
                return false;

            if (!buttonModulo.Enabled)
                return false;

            return true;
        }

        private void FreeButtons()
        {
            buttonMult.Enabled = true;
            buttonSubtraction.Enabled = true;
            buttonSum.Enabled = true;
            buttonDiv.Enabled = true;
            buttonDivOne.Enabled = true;
            buttonPow.Enabled = true;
            buttonModulo.Enabled = true;
            buttonSqrt.Enabled = true;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            displayBox.Text = "0";

            C.Clear_A();
            FreeButtons();

            k = 0;
        }

        private void buttonCifra_click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            if (displayBox.Text == "0")
                displayBox.Text = B.Text;
            else
                displayBox.Text += B.Text;

            E.CorrectNumber(displayBox);
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(displayBox.Text));

                buttonSum.Enabled = false;

                displayBox.Text = "0";
            }
        }

        private void buttonSubtraction_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(displayBox.Text));

                buttonSubtraction.Enabled = false;

                displayBox.Text = "0";
            }
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(displayBox.Text));

                buttonMult.Enabled = false;

                displayBox.Text = "0";
            }
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(displayBox.Text));

                buttonDiv.Enabled = false;

                displayBox.Text = "0";
            }
        }

        private void buttonDivOne_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(displayBox.Text));

                buttonDivOne.Enabled = false;

                displayBox.Text = "0";
            }
        }

        private void buttonModulo_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(displayBox.Text));

                buttonModulo.Enabled = false;

                displayBox.Text = "0";
            }
        }

        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(displayBox.Text));

                buttonSqrt.Enabled = false;

                displayBox.Text = "0";
            }
        }

        private void buttonPow_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(displayBox.Text));

                buttonPow.Enabled = false;

                displayBox.Text = "0";
            }
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            if (!buttonMult.Enabled)
                displayBox.Text = C.Mult(Convert.ToDouble(displayBox.Text)).ToString();

            if (!buttonDiv.Enabled)
                displayBox.Text = C.Div(Convert.ToDouble(displayBox.Text)).ToString();

            if (!buttonDivOne.Enabled)
                displayBox.Text = C.DivOne().ToString();

            if (!buttonModulo.Enabled)
                displayBox.Text = C.Mod(Convert.ToDouble(displayBox.Text)).ToString();

            if (!buttonSum.Enabled)
                displayBox.Text = C.Sum(Convert.ToDouble(displayBox.Text)).ToString();

            if (!buttonSubtraction.Enabled)
                displayBox.Text = C.Subtraction(Convert.ToDouble(displayBox.Text)).ToString();

            if (!buttonSqrt.Enabled)
                displayBox.Text = C.Sqrt().ToString();

            if (!buttonPow.Enabled)
                displayBox.Text = C.Pow(Convert.ToDouble(displayBox.Text)).ToString();

            C.Clear_A();
            FreeButtons();

            k = 0;
        }

        private void buttonMRC_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                k++;

                if (k == 1)
                    displayBox.Text = C.MemoryShow().ToString();

                if (k == 2)
                {
                    C.Memory_Clear();
                    displayBox.Text = "0";

                    k = 0;
                }
            }
        }

        private void buttonMsum_Click(object sender, EventArgs e)
        {
            C.M_Sum(Convert.ToDouble(displayBox.Text));
        }

        private void buttonMsub_Click(object sender, EventArgs e)
        {
            C.M_Subtraction(Convert.ToDouble(displayBox.Text));
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            if ((displayBox.Text.IndexOf(",") == -1) && (displayBox.Text.IndexOf("∞") == -1))
                displayBox.Text += ",";
        }
    }
}
