using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class CalculationFacade
    {
        public int DoComplexCalculation(int a, int b)
        {
            RichSubsystem complexSubsystem = new RichSubsystem();
            int result = complexSubsystem.Substraction(
                    complexSubsystem.Division(
                        complexSubsystem.Multiplikation(a, b), 
                        complexSubsystem.Addition(a, b)),
                    complexSubsystem.Addition(a,b)
                    );
            return result;
        }
    }
}
