using System;
using CarLotSimulator;


namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var toyota = new Car();
            toyota.Year = 2013;
            toyota.Make = "Toyota";
            toyota.Model = "rav";
            toyota.EngineNoise = "Noisy";
            toyota.HonkNoise = "Honk Honk";
            toyota.IsDrivable = true;

            Car Honda = new Car() { Make = "Honda", Model = "civic" };

            Car Tesla = new Car() { Make = "Tesla", Model = "T-22" };


            Console.WriteLine(toyota.MakeEngineNoise());
            Console.WriteLine(toyota.Make);
            Console.WriteLine(toyota.Year);
            Console.WriteLine(Honda.Model);

            Console.WriteLine(Tesla.Make);





















            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

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
