using CarLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTest
{
    internal class Freight_Car_Test
    {
        public static Freight_Car car = new Freight_Car(500, 25, 90, 1500);
        public static Freight_Car SetMoreCargo() => new Freight_Car(1, 1, 1, 3000);
        public static Freight_Car SetNegativeCargo() => new Freight_Car(1, 1, 1, -1);
        public static void GetFuelСonsumption() => Console.WriteLine(car.GetFuelСonsumption());
        public static void GetMaxDistance() => Console.WriteLine(car.GetMaxDistance());
        public static void GetCurrentDistance() => Console.WriteLine(car.GetCurrentDistance());
        public static void GetSpentFuel(double distance) => Console.WriteLine(car.GetSpentFuel(distance));

    }
}