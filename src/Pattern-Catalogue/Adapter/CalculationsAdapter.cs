using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class CalculationsAdapter : ICalculations
    {
        // All casts are implicit and totally redundant. 
        // They are just added to emphasize that conversions may happen.
        private VeryQuickCalculations veryQuickCalculations = new VeryQuickCalculations();
        public int Multiply(int a, int b)
        {
            Console.WriteLine("Adapter: Converting arguments for multiplication");
            double double_a = (double) a;
            double double_b = (double) b;
            double result = veryQuickCalculations.Multiply(double_a, double_b);
            int convertedResult = (int) result;
            Console.WriteLine("Adapter: Re-converting results and sending back to client");
            return convertedResult;
        }

        public int Add(int a, int b)
        {
            Console.WriteLine("Adapter: Converting arguments for addition");
            double double_a = (double)a;
            double double_b = (double)b;
            double result = veryQuickCalculations.Add(double_a, double_b);
            int convertedResult = (int)result;
            Console.WriteLine("Adapter: Re-converting results and sending back to client");
            return convertedResult;
        }
    }
}
