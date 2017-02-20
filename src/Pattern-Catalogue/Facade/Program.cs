using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instead of using the subsystem which is rich on functions
            // the client uses the facade which simplifies the usage
            CalculationFacade easyToUseInterface = new CalculationFacade();
            int a = 4;
            int b = 2;
            int result = easyToUseInterface.DoComplexCalculation(a, b);

            Console.ReadLine();
        }
    }
}
