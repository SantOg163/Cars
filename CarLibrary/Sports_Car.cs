using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLibrary
{
    public class Sports_Car : Car
    {
        public Sports_Car(double max_Fuel, double fuel_Сonsumption, double speed) : base(max_Fuel, fuel_Сonsumption, speed)
        {
            Type = "Sports Car";
        }
    }
}
