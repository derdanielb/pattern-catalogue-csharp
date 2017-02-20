using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Proofe Singleton does not get instantiated instantly.");
            Singleton v1 = Singleton.Instance;
            Singleton v2 = Singleton.Instance;
            
            v1 = null;
            v2 = null;
            
            Singleton v3 = Singleton.Instance;

            Console.ReadLine();
        }
    }
}
