using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            CarLot myCarLot = new CarLot();
            myCarLot.VehicleInventory = new List<Car>();
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            var car1 = new Car();
            car1.LotID = 1;
            car1.Year = 2006;
            car1.Make = "Toyota";
            car1.Model = "Corolla";
            car1.EngineNoise = "rum-rum-RUM-RUM-ROOOOOM-ROOOM-RUM-Rum-rum-rum";
            car1.HonkNoise = "Beep-Beep";
            car1.IsDrivable = true;
            myCarLot.VehicleInventory.Add(car1);
            Console.WriteLine("Adding vehicle to inventory...");
            Console.WriteLine($"Vehicles in inventory: {CarLot._numberOfCars}\n");

            var car2 = new Car()
            {
                LotID = 2,
                Year = 2004,
                Make = "Chevrolet",
                Model = "Silverado",
                EngineNoise = "VVVRUM-VRUM-VRUM-VRUM-VROOOOOM-VROOOM-VRUM-VRum-vrum-vrum",
                HonkNoise = "HONK-HONK",
                IsDrivable = true
            };
            myCarLot.VehicleInventory.Add(car2);
            Console.WriteLine("Adding vehicle to inventory...");
            Console.WriteLine($"Vehicles in inventory: {CarLot._numberOfCars}\n");

            var car3 = new Car(3, 2013, "Toyota", "Prius", "", "meep-meep", true);
            myCarLot.VehicleInventory.Add(car3);
            Console.WriteLine("Adding vehicle to inventory...");
            Console.WriteLine($"Vehicles in inventory: {CarLot._numberOfCars}\n");

            for (int i = 0; i <= myCarLot.VehicleInventory.Count - 1; i++)
            {
                Console.WriteLine($"LotID: {myCarLot.VehicleInventory[i].LotID}");
                Console.WriteLine($"Year: {myCarLot.VehicleInventory[i].Year}");
                Console.WriteLine($"Make: {myCarLot.VehicleInventory[i].Make}");
                Console.WriteLine($"Mode: {myCarLot.VehicleInventory[i].Model}");
                Console.WriteLine(Environment.NewLine);
               
            }

            //Call each of the methods for each car
            Console.WriteLine($"LotID: {car1.LotID}");
            Console.WriteLine("Engine test: ");
            car1.MakeEngineNoise(car1.EngineNoise);
            Console.WriteLine("Horn test:");
            car1.MakeHornNoise(car1.HonkNoise);
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine($"LotID: {car2.LotID}");
            Console.WriteLine("Engine test:");
            car2.MakeEngineNoise(car2.EngineNoise);
            Console.WriteLine("Horn test:");
            car2.MakeHornNoise(car2.HonkNoise);
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine($"LotID: {car3.LotID}");
            Console.WriteLine("Engine test:");
            car3.MakeEngineNoise(car3.EngineNoise);
            Console.WriteLine("Horn test:");
            car3.MakeHornNoise(car3.HonkNoise);
            Console.WriteLine(Environment.NewLine);

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
