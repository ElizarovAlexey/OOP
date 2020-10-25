using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculates : InterfaceCalc
    {
        private double a = 0;
        private double memory = 0;

        public void Put_A(double a)
        {
            this.a = a;
        }

        public void Clear_A()
        {
            a = 0;
        }
        public double Sum(double b)
        {
            return a + b;
        }

        public double Subtraction(double b)
        {
            return a - b;
        }

        public double Mult(double b)
        {
            return a * b;
        }

        public double Div(double b)
        {
            return a / b;
        }

        public double Mod(double b)
        {
            return a % b;
        }

        public double DivOne()
        {
            return 1 / a;
        }

        public double Pow(double b)
        {
            return Math.Pow(a, b);
        }

        public double Sqrt()
        {
            return Math.Sqrt(a);
        }

        //показать содержимое регистра мамяти
        public double MemoryShow()
        {
            return memory;
        }

        //стереть содержимое регистра мамяти
        public void Memory_Clear()
        {
            memory = 0.0;
        }

        public void M_Sum(double b)
        {
            memory += b;
        }

        public void M_Subtraction(double b)
        {
            memory -= b;
        }
    }
}
