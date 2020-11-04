using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX_04._11._2020
{
    class Ecuation
    {
        public Ecuation(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;
        }

        public int A
        {
            get;
            set;
        }

        public int B
        {
            get;
            set;
        }

        public int C
        {
            get;
            set;
        }

        public bool isValidEcuation()
        {
            if (A > 0)
                return true;
            else
                return false;
        }

        private string Stare()
        {
            if (Delta() > 0 && isValidEcuation())
                return "2";
            else if (Delta() > 0 && isValidEcuation() == false)
                return "1";
            else return "0";
        }

        private int Delta()
        {
            if (isValidEcuation())
                return (int)(Math.Pow(B, 2) - 4 * A * C);
            else
                return 0;
        }

        private int radicalOne()
        {
            if (isValidEcuation() && Delta() > 0)
                return (int)Math.Round((-B - Math.Sqrt(Delta())) / 2 * A, 2);
            else
                return 0;
        }

        private int radicalTwo()
        {
            if (isValidEcuation() && Delta() > 0)
                return (int)Math.Round((-B + Math.Sqrt(Delta())) / 2 * A, 2);
            else
                return 0;
        }

        public void Results(RichTextBox textBox)
        {
            List<String> valueList = new List<String>();

            valueList.Add(" " + A.ToString() + "\t");
            valueList.Add(B.ToString() + "\t");
            valueList.Add(C.ToString() + "\t");
            valueList.Add(radicalOne().ToString() + "\t");
            valueList.Add(radicalTwo().ToString() + "\t");
            valueList.Add(Stare() + " ");
            valueList.Add("\n");
            //textBox.Clear();
            
            foreach (var i in valueList)
            {
                textBox.Text += i + " ";
            }
            
        }

    }
}
