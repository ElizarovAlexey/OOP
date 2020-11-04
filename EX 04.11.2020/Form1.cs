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
        DataTable table = new DataTable();
        public Form1()
        {
            InitializeComponent();
            table.Columns.Add("A", typeof(double));
            table.Columns.Add("B", typeof(double));
            table.Columns.Add("C", typeof(double));
            table.Columns.Add("x1", typeof(double));
            table.Columns.Add("x2", typeof(double));
            table.Columns.Add("S", typeof(double));

            dataGridView1.DataSource = table;

            for (int i = 0; i < table.Columns.Count; i++)
                dataGridView1.Columns[i].Width = 50;
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
            ecuation.Results(dataGridView1, table);
        }
        private void buttonCustom_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBoxA.Text);
            int b = int.Parse(textBoxB.Text);
            int c = int.Parse(textBoxC.Text);
            Ecuation ecuation = new Ecuation(a, b, c);
            ecuation.Results(dataGridView1, table);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            table.Clear();
            textBoxA.Text = "0";
            textBoxB.Text = "0";
            textBoxC.Text = "0";
        }
    }
}
