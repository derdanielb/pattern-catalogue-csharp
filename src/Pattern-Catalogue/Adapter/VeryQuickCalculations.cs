using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class VeryQuickCalculations
    {
        public double Multiply(double a, double b)
        {
            Console.WriteLine("VeryQuickCalculation: Performing very quick multiplication");
            return a*b;
        }

        public double Add(double a, double b)
        {
            Console.WriteLine("VeryQuickCalculation: Performing very quick addition");
            return a + b;
        }
    }
}
