using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] kindOfVehicle =  { "Racecar", "Truck" };
            IVehicleFactory vehicle;

            for (int i = 0; i < 2; i++)
            {
                switch (kindOfVehicle[i])
                {
                    case "Racecar":
                        vehicle = new RaceCarFactory();
                        break;
                    case "Truck":
                        vehicle = new TruckFactory();
                        break;
                    default:
                        throw new NotImplementedException();
                }

                var chassis = vehicle.CreateChassis();
                var tire = vehicle.CreateTire();
            }

            Console.ReadLine();
        }
    }
}
