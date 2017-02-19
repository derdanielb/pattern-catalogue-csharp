using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Client needs calculations for these two values
            int a = 2;
            int b = 4;

            // Usually client would use some calculator that implements the interface and accept integers as parameters
            // Now we found a very quick calculation service that we want to use instead
            // Unfortunately this service only accepts double values and client cant change that
            // So our adapter will take care of the conversion and also the delegation to the new service

            ICalculations calculator = new CalculationsAdapter();
            int multiplyResult = calculator.Multiply(a, b);
            Console.WriteLine("\n");
            int addResult = calculator.Add(a, b);

            Console.ReadLine();
        }
    }
}
