using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    interface IVehicleFactory
    {
        IChassis CreateChassis();
        ITire CreateTire();
    }
}
