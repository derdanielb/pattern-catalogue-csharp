using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    class RaceCarFactory : IVehicleFactory
    {
        public IChassis CreateChassis()
        {
            Console.WriteLine("Race car chassis created");
            return new RaceCarChassis();
        }

        public ITire CreateTire()
        {
            Console.WriteLine("Race car tire created");
            return new RaceCarTire();
        }
    }
}
