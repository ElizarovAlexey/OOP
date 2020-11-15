using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Memory
    {
        private double memory;

        public double MemoryShow()
        {
            return memory;
        }

        public void MemoryClear()
        {
            memory = 0.0;
        }

        public void M_Sum(double b)
        {
            memory += b;
        }

        public void M_Sub(double b)
        {
            memory -= b;
        }
    }
}
