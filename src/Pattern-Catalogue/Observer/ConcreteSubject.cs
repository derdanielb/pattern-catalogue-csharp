using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class ConcreteSubject : ISubject
    {
        private int state = 0;
        public override void Notify()
        {
            foreach (IObserver observer in obsList)
            {
                Console.WriteLine("Subject: Notifying an observer");
                observer.Notify();
            }
        }

        public void ChangeState(int state)
        {
            Console.WriteLine("Subject: State changed");
            this.state = state;
            Notify();
        }
    }
}
