using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class RichSubsystem
    {
        public int Addition(int a, int b)
        {
            Console.WriteLine("RichSubsystem.Addition");
            return a + b;
        }

        public int Substraction(int a, int b)
        {
            Console.WriteLine("RichSubsystem.Subtraction");
            return a - b;
        }

        public int Multiplikation(int a, int b)
        {
            Console.WriteLine("RichSubsystem.Multiplikation");
            return a*b;
        }

        public int Division(int a, int b)
        {
            Console.WriteLine("RichSubsystem.Division");
            return a/b;
        }
    }
}
