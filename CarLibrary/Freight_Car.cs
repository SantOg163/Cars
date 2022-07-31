using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLibrary
{
    public class Freight_Car : Car
    {
        //вспомогательные переменные (в случаи изменения веса)
        public double LastCargo = 0;
        public double FirstFuelСonsumption { get; }
        public double Cargo { get; private set; }
        public Freight_Car(double max_Fuel, double fuel_Сonsumption, double speed, double cargo) : base(max_Fuel, fuel_Сonsumption, speed)
        {
            Type = "Freight Car";
            CheckErrors(cargo);
            FirstFuelСonsumption = fuel_Сonsumption;
            Cargo = cargo;
        }
        //лучше использовать событие и внешнее изменение?
        public void ChangeCargo(double cargo)
        {
            CheckErrors(cargo);
            Cargo = cargo;
            GetFuelСonsumption();
        }
        //проверка при создании и изменении
        private static void CheckErrors(double cargo)
        {
            StringBuilder errors = new StringBuilder();
            if (cargo > 2000)
                errors.AppendLine("The cargo cannot be more than 2 tons");
            if (cargo < 0)
                errors.AppendLine("The cargo cannot be less than 0");
            if (errors.Length > 0)
                throw new ArgumentException(errors.ToString());
        }
        public override double GetFuelСonsumption()
        {
            if (Cargo != LastCargo)
            {
                CheckErrors(Cargo);
                LastCargo = Cargo;
                //изменяем для последующих расчетов
                Fuel_Сonsumption = FirstFuelСonsumption + FirstFuelСonsumption / 25 * Cargo / 200;
            }
            return Fuel_Сonsumption;
        }
        
    }
}
