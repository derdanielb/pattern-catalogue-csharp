using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    abstract class ISubject
    {
        protected List<IObserver> obsList = new List<IObserver>();
        public void AddObserver(IObserver obs)
        {
            Console.WriteLine("Subject: Observer added to subscriber list");
            obsList.Add(obs);
        }

        public void RemoveObserver(IObserver obs)
        {
            Console.WriteLine("Subject: Observer removed from subscriber list");
            obsList.Remove(obs);
        }

        public abstract void Notify();
        

    }
}
