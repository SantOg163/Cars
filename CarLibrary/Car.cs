using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLibrary
{
    public abstract class Car
    {
        public Car(double max_Fuel,double fuel_Сonsumption, double speed)
        {
            StringBuilder errors = new StringBuilder();
            //if(Current_Fuel > Max_Fuel)
            //    errors.AppendLine("The current amount of fuel cannot exceed max. fuel");
            //if (Current_Fuel < 0)
            //    errors.AppendLine("The current amount of fuel cannot be less than 0");
            if(speed < 0)
                errors.AppendLine("The speed cannot be less than 0.");
            if (max_Fuel < 0)
                errors.AppendLine("The max. amount of fuel cannot be less than 0.");
            if (fuel_Сonsumption < 0)
                errors.AppendLine("Fuel consumption cannot be less than 0.");
            if(errors.Length > 0)
                throw new ArgumentException(errors.ToString());
            Max_Fuel = max_Fuel;
            Fuel_Сonsumption = fuel_Сonsumption;
            Speed = speed;
        }

        public string Type { get; protected set; }
        public double Max_Fuel { get; }
        public double Current_Fuel { get; set; }
        // расход на 100 км.
        public double Fuel_Сonsumption { get; protected set; }
        public double Speed { get; set; }
        public double GetMaxDistance() => Max_Fuel / Fuel_Сonsumption * 100;
        public double GetCurrentDistance() => Current_Fuel * Fuel_Сonsumption/100;
        public virtual double GetFuelСonsumption() => Fuel_Сonsumption;
        //Метод, который на основе параметров количества топлива и заданного расстояния вычисляет за сколько автомобиль его преодолеет.
        public double GetSpentFuel(double distance) 
        {
            Fuel_Сonsumption = GetFuelСonsumption();
            return Fuel_Сonsumption / 100 * distance; 
        }
    }
}
