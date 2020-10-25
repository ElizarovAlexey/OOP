using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public interface InterfaceCalc
    {
        void Put_A(double a); //сохранить а

        void Clear_A();

        double Mult(double b);

        double Div(double b);

        double DivOne();

        double Mod(double b);

        double Sum(double b);

        double Subtraction(double b); //вычитание

        double Sqrt();

        double Pow(double b);

        double MemoryShow(); //показать содержимое регистра памяти

        void Memory_Clear(); //стереть содержимое регистра памяти

        void M_Sum(double b);

        void M_Subtraction(double b); //вычитание
    }
}
