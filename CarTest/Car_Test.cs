using CarLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTest
{
    internal class Car_Test
    {
        public static Sports_Car car = new Sports_Car(87, 12, 387);
        public static Sports_Car SetNegativeValues() => new Sports_Car(-1, -1, -1);
        public static void GetFuelСonsumption() => Console.WriteLine(car.GetFuelСonsumption());
        public static void GetMaxDistance() => Console.WriteLine(car.GetMaxDistance());
        public static void GetCurrentDistance() => Console.WriteLine(car.GetCurrentDistance());
        public static void GetSpentFuel(double distance) => Console.WriteLine(car.GetSpentFuel(distance));

    }
}