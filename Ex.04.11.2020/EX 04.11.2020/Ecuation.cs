﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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

        private string Solutions()
        {
            if (Delta() > 0 && isValidEcuation())
                return "2";
            else if (Delta() == 0)
                return "1";
            else
                return "0";
        }

        private int Delta()
        {
            if (isValidEcuation())
                return (int)(Math.Pow(B, 2) - 4 * A * C);
            else
                return 0;
        }

        private double radicalOne()
        {
            if (isValidEcuation() && Delta() > 0)
                return (double)Math.Round((-B - Math.Sqrt(Delta())) / (2 * A), 2);
            else
                return 0;
        }

        private double radicalTwo()
        {
            if (isValidEcuation() && Delta() > 0)
                return (double)Math.Round((-B + Math.Sqrt(Delta())) / (2 * A), 2);
            else
                return 0;
        }

        public void Results(DataGridView dataGrid, DataTable table)
        {
            List<String> valueList = new List<String>();

            valueList.Add(" " + A.ToString() + "\t");
            valueList.Add(B.ToString() + "\t");
            valueList.Add(C.ToString() + "\t");
            valueList.Add(radicalOne().ToString() + "\t");
            valueList.Add(radicalTwo().ToString() + "\t");
            valueList.Add(Solutions() + " ");

            string[] line = new string[6];
            for (int i = 0; i < valueList.Count; i++)
            {
                line[i] += valueList[i];
            }
            table.Rows.Add(line);

        }

        public void DrawGraphic(Chart chart)
        {
            double[] x = new double[] {-10, -9, -8, -7, -6, -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            double[] y = new double[x.Length - 1];

            for (int i = 0; i < y.Length; i++)
            {
                y[i] = A * Math.Pow(x[i], 2) + B * x[i] + C;
            }

            chart.Series[0].ChartType = SeriesChartType.Spline;
            for (int i = 0; i < y.Length; i++)
                chart.Series[0].Points.AddXY(x[i], y[i]);

        }

    }
}
