using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    class TruckFactory : IVehicleFactory
    {
        public IChassis CreateChassis()
        {
            Console.WriteLine("Truck chassis created");
            return new TruckChassis();
        }

        public ITire CreateTire()
        {
            Console.WriteLine("Truck tire created");
            return new TruckTire();
        }
    }
}
