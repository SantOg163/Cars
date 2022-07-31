using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLibrary
{
    public class Passenger_Car : Car
    {
        //вспомогательные переменные (в случаи изменения веса)
        public double LastPassengers = 0;
        public double FirstFuelСonsumption { get; }
        public int Passengers { get; private set; }
        public Passenger_Car(double max_Fuel, double fuel_Сonsumption, double speed, int passengers) : base(max_Fuel, fuel_Сonsumption, speed)
        {
            FirstFuelСonsumption = fuel_Сonsumption;
            Type = "Passenger Car";
            CheckErrors(passengers);
            Passengers = passengers;
        }
        //лучше использовать событие и внешнее изменение?
        public void ChangePassengers(int passengers)
        {
            CheckErrors(passengers);
            Passengers = passengers;
            GetFuelСonsumption();
        }
        //проверка при создании и изменении
        private static void CheckErrors(int passengers)
        {
            StringBuilder errors = new StringBuilder();
            if (passengers > 4)
                errors.AppendLine("The number of passengers cannot be more than 4");
            if (passengers < 0)
                errors.AppendLine("The number of passengers cannot be less than 0");
            if (errors.Length > 0)
                throw new ArgumentException(errors.ToString());
        }
        public override double GetFuelСonsumption()
        {
            if (Passengers != LastPassengers)
            {
                LastPassengers = Passengers;
                //изменяем для последующих расчетов
                Fuel_Сonsumption = FirstFuelСonsumption + FirstFuelСonsumption / 100 * 6 * Passengers; ;
            }
            return Fuel_Сonsumption;
        }
    }
}
