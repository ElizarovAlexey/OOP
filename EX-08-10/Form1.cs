using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX_08_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number;

            number = Convert.ToInt32(textBox1.Text);

            bool resultFib = IsFib(number);
            bool resultPrime = IsPrime(number);

            if (resultFib)
            {
                textBox2.Text = "Да";
            }
            else
            {
                textBox2.Text = "Нет";
            }

            if (resultPrime)
            {
                textBox3.Text = "Да";
            }
            else
            {
                textBox3.Text = "Нет";
            }
        }

        static bool IsFib(int n)
        {
            return IsSquare(5 * n * n + 4) || IsSquare(5 * n * n - 4);
        }
        static bool IsSquare(int x)
        {
            int m = (int)Math.Sqrt(x);
            return m * m == x;
        }

        bool IsPrime(int n)
        {
            if (n > 1)
            {
                for (int i = 2; i < n; i++)
                    if (n % i == 0)
                        return false;

                return true;
            }
            else
                return false;
        }
    }
}
