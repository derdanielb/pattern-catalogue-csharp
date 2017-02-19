using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    sealed class Singleton
    {
        private static readonly Singleton instance = new Singleton();


        static Singleton()
        {
            Console.WriteLine("static constructor executed");
        }

        private Singleton()
        {
            Console.WriteLine("private constructor executed");
        }

        public static Singleton Instance
        {
            get
            {
                return instance;
            } 
        }
    }
}
