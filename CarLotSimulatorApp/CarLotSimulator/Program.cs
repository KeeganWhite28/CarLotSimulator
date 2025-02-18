﻿using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
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

            Car bmw = new Car();
            bmw.Year = 2016;
            bmw.Make = "BMW";
            bmw.Model = "328i";
            bmw.EngineNoise = "Vroom Vroom";
            bmw.HonkNoise = "Beep Beep";
            bmw.IsDriveable = true;

            var stevesCar = new Car()
            {
                Year = 2019,
                Make = "Tesla",
                Model = "Cyber Truck",
                EngineNoise = "...",
                HonkNoise = "boop boop",
                IsDriveable = false
            };

            var brettsCar = new Car(2013, "Honda", "Civic", "skrrt", "wub wub", true);

            bmw.MakeEngineNoise(bmw.EngineNoise);
            stevesCar.MakeEngineNoise(stevesCar.EngineNoise);
            brettsCar.MakeEngineNoise(brettsCar.EngineNoise);
            bmw.MakeHonkNoise(bmw.HonkNoise);
            stevesCar.MakeHonkNoise(stevesCar.HonkNoise);
            brettsCar.MakeHonkNoise(brettsCar.HonkNoise);


            Console.WriteLine($"The number of cars in the lot is: {CarLot.numberOfCars}");

        }
    }
}
