using CarLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTest
{
    internal class Passenger_Car_Test
    {
        public static Passenger_Car car = new Passenger_Car(87, 12, 387, 4);
        public static Passenger_Car SetMorePassengers() => new Passenger_Car(1, 1, 1, 5);
        public static Passenger_Car SetNegativePassengers() => new Passenger_Car(1, 1, 1, -1);
        public static void GetFuelСonsumption() => Console.WriteLine(car.GetFuelСonsumption());
        public static void GetMaxDistance() => Console.WriteLine(car.GetMaxDistance());
        public static void GetCurrentDistance() => Console.WriteLine(car.GetCurrentDistance());
        public static void GetSpentFuel(double distance) => Console.WriteLine(car.GetSpentFuel(distance));

    }
}