using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    class Calculates
    {
        private double firstNumber;
        private double secondNumber;

        public void PutFirstNumber(double firstNumber)
        {
            this.firstNumber = firstNumber;
        }

        public void PutSecondNumber(double secondNumber)
        {
            this.secondNumber = secondNumber;
        }

        public void ClearFirstNumber()
        {
            firstNumber = 0;
        }

        public double Sum(double secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public double Sub(double secondNumber)
        {
            return firstNumber - secondNumber;
        }
        public double Mult(double secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public double Div(double secondNumber)
        {
            if (secondNumber == 0)
            {
                MessageBox.Show("Ошибка, нельзя делить на 0!");
                return 0;
            }
            else
                return firstNumber / secondNumber;
        }

        public double Sqrt()
        {
            return Math.Sqrt(firstNumber);
        }

        public double Pow(double secondNumber)
        {
            return Math.Pow(firstNumber, secondNumber);
        }

        public double Modulo(double secondNumber)
        {
            return firstNumber % secondNumber;
        }

        public double DivOne()
        {
            return 1 / firstNumber;
        }

    }
}
