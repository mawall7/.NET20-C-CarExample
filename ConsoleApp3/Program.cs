using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Class2 class2 = new Class2();
            var fuelVehicle = new fuelVehicle("ABC12A", 20);

            //var vehicles = new List<Vehicle>()
            //{
            //    new Vehicle("ABC123"),
            //    new Vehicle("ABC132"),
            //    new fuelCar("ABD124",10.2),

            //};
            List<IDrive> vehicles = new List<IDrive>()
            {
                new Vehicle("ABC123"),
                new Vehicle("ABC132"),
                new FuelCar("ABD124",10.2),
                new Bicycle("123ffsa")
            };
            foreach (var item in vehicles)
            {
                Console.WriteLine($"{item.Drive(20)}");

                if (item is FuelCar)
                {

                    FuelCar fuelCar = (FuelCar)item; // alt1. Unsafe Cast behöver if satsen ger annars error för de andra typerna som ej är en fuelCar
                    Console.WriteLine(fuelCar.Sound());
                }
                //fuelCar fuelCar2 = item as fuelCar; // alt2. returnerar null om item ej är en fuelCar;
                //if (fuelCar2 != null)
                //{
                //    Console.WriteLine(fuelCar2.Sound());
                //}

                //FuelCar fuelCar2 = item as FuelCar;
                //Console.WriteLine(fuelCar2?.Sound()); //alt3. som alt 2 men gör nullcheck med annan syntax. 

                if (item is FuelCar car) // at4. lagrar direct FuelCat i car. kortaste skrivsättet.
                {
                    Console.WriteLine(car.Sound());
                }

            }

        }
    }
}
