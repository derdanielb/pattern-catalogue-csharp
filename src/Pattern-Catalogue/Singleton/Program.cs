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
            Console.WriteLine("Attempting to get Singlton instance one");
            Singleton v1 = Singleton.Instance;
            Console.WriteLine("Attempting to get Singlton instance two");
            Singleton v2 = Singleton.Instance;
            Console.WriteLine("\n*** As it can be seen, the instance gets created (= constructor executes) lazily only when Singleton class is accessed the first time. \n*** Both static and private constructor are executed once. As we access main Singleton class we cause execution of the private constructor. Singleton class holds a instance of itself so static constructor gets call the second time.");

            Console.WriteLine("Compare both instances: "+v1.Equals(v2));

            Console.WriteLine("\nSet both instances to null");
            v1 = null;
            v2 = null;
            Console.WriteLine("Attempting to get Singlton instance three");
            Singleton v3 = Singleton.Instance;
            Console.WriteLine("\n*** No constructor execution happens.\n*** The static instance does not get deleted even when we remove both the objects referring to it");
            Console.ReadLine();
        }
    }
}
