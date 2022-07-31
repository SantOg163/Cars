using CarTest;

//Car_Test.SetNegativeValues();
Car_Test.GetMaxDistance();
Car_Test.GetCurrentDistance();
Car_Test.GetFuelСonsumption();
Car_Test.GetSpentFuel(100);
Console.WriteLine();

//Freight_Car_Test.SetMoreCargo();
//Freight_Car_Test.SetNegativeCargo();
Freight_Car_Test.GetMaxDistance();
Freight_Car_Test.GetCurrentDistance();
Freight_Car_Test.GetFuelСonsumption();
Freight_Car_Test.car.ChangeCargo(1000);
Freight_Car_Test.GetFuelСonsumption();
Freight_Car_Test.GetSpentFuel(100);
Freight_Car_Test.car.ChangeCargo(1500);
Freight_Car_Test.GetSpentFuel(100);
Console.WriteLine();

//Passenger_Car_Test.SetMorePassengers();
//Passenger_Car_Test.SetNegativePassengers();
Passenger_Car_Test.GetMaxDistance();
Passenger_Car_Test.GetCurrentDistance();
Passenger_Car_Test.GetFuelСonsumption();
Passenger_Car_Test.GetSpentFuel(100);
Passenger_Car_Test.car.ChangePassengers(3);
Passenger_Car_Test.GetFuelСonsumption();
Passenger_Car_Test.GetSpentFuel(100);
Passenger_Car_Test.car.ChangePassengers(4);
Passenger_Car_Test.GetSpentFuel(100);
