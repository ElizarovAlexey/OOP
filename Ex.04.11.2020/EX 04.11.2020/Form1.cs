using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX_04._11._2020
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxA.Text = "0";
            textBoxB.Text = "0";
            textBoxC.Text = "0";
        }

        private void buttonRandom_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int a = rnd.Next(10);
            int b = rnd.Next(10);
            int c = rnd.Next(10);

            textBoxA.Text = a.ToString();
            textBoxB.Text = b.ToString();
            textBoxC.Text = c.ToString();

            Ecuation ecuation = new Ecuation(a, b, c);
            ecuation.Results(richTextBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBoxA.Text);
            int b = int.Parse(textBoxB.Text);
            int c = int.Parse(textBoxC.Text);
            Ecuation ecuation = new Ecuation(a, b, c);
            ecuation.Results(richTextBox1);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            textBoxA.Text = "0";
            textBoxB.Text = "0";
            textBoxC.Text = "0";
        }
    }
}
