using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteSubject sub = new ConcreteSubject();
            ConcreteObserver obs = new ConcreteObserver();

            sub.AddObserver(obs);
            sub.ChangeState(1);

            sub.RemoveObserver(obs);

            Console.ReadLine();

        }
    }
}
