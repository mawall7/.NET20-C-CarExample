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

            var vehicles = new List<Vehicle>()
            {
                new Vehicle("ABC123"),
                new Vehicle("ABC132"),
                new fuelCar("ABD124",10.2)
            };
            foreach(var item in vehicles)
            {
                Console.WriteLine($"{item.Drive(20)}");
            }
            
        }
    }
}
