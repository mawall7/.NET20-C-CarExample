﻿using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Class2 class2 = new Class2();
            var fuelVehicle = new fuelVehicle("ABC12A", 20);

            var list = new List<Vehicle>()
            {
                new Vehicle("ABC123"),
                new Vehicle("ABC132"),
                new fuelVehicle("ABD124",10.2)
            };
            
        }
    }
}
