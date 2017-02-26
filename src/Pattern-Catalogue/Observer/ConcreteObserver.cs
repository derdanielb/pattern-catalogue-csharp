using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class ConcreteObserver : IObserver
    {
        public void Notify()
        {
            Console.WriteLine("Observer: Observer received notification");
        }
    }
}
