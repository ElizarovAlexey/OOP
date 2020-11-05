using System;
using System.Data;
using System.Timers;
using System.Windows.Forms;

namespace EX_04._11._2020
{
    public partial class Form1 : Form
    {
        DataTable table = new DataTable();
        private bool button = false; 
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
            chart1.Series[0].Points.Clear();
            textBoxA.Text = "0";
            textBoxB.Text = "0";
            textBoxC.Text = "0";
        }

        private void Animation(object sender, EventArgs e)
        {
            if (this.Width < 400 && button == true)
            {
                while (!(this.Width == 750))
                {
                    this.Width += 2;
                    if (this.Width == 748)
                    {
                        buttonOpenClose.Text = "<-";
                        button = false;
                    }
                }
            }

            if (this.Width > 500 && button == true)
            {
                while (!(this.Width == 396))
                {
                    this.Width -= 2;
                    if (this.Width == 398)
                    {
                        buttonOpenClose.Text = "->";
                        button = false;
                    }
                }
            }
        }

        private void buttonOpenClose_Click(object sender, EventArgs e)
        {
            button = !button;
            Animation(sender, e);
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBoxA.Text);
            int b = int.Parse(textBoxB.Text);
            int c = int.Parse(textBoxC.Text);

            Ecuation ecuation = new Ecuation(a, b, c);
            if (this.Width < 420)
            {
                while (!(this.Width == 750))
                {
                    this.Width += 1;
                    if (this.Width == 749)
                    {
                        buttonOpenClose.Text = "<-";
                        button = false;
                    }
                }
            }
            ecuation.DrawGraphic(chart1);
        }

        private void clearGraphic_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
        }
    }
}
