using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    interface ICalculations
    {
        int Multiply(int a, int b);
        int Add(int a, int b);
    }
}
