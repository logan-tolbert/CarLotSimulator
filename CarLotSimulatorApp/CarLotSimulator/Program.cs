using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var myCarLot = new List<CarLot>();

            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            var car1 = new Car();
            var car2 = new Car();
            var car3 = new Car();

            //Set the properties for each of the cars
            car1.lotID = 1;
            car1.Year = 2006;
            car1.Make = "Toyota";
            car1.Model = "Corolla";
            car1.EngineNoise = "rum-rum-RUM-RUM-ROOOOOM-ROOOM-RUM-Rum-rum-rum";
            car1.HonkNoise = "Beep-Beep";
            car1.IsDrivable = true;

            
            car2.lotID = 2;
            car2.Year = 2004;
            car2.Make = "Chevrolet";
            car2.Model = "Silverado";
            car2.EngineNoise = "VVVRUM-VRUM-VRUM-VRUM-VROOOOOM-VROOOM-VRUM-VRum-vrum-vrum";
            car2.HonkNoise = "HONK-HONK";
            car2.IsDrivable = true;

            car3.lotID = 3;
            car3.Year = 2013;
            car3.Make = "Toyota";
            car3.Model = "Prius";
            car3.EngineNoise = "";
            car3.HonkNoise = "meep-meep";
            car3.IsDrivable = true;


            //Call each of the methods for each car
            Console.WriteLine("Engine test: ");
            car1.MakeEngineNoise(car1.EngineNoise);
            Console.WriteLine("Horn test:");
            car1.MakeHornNoise(car1.HonkNoise);
            Console.WriteLine(Environment.NewLine);


            Console.WriteLine("Engine test: ");
            car2.MakeEngineNoise(car2.EngineNoise);
            Console.WriteLine("Horn test:");
            car2.MakeHornNoise(car2.HonkNoise);
            Console.WriteLine(Environment.NewLine);


            Console.WriteLine("Engine test: ");
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
