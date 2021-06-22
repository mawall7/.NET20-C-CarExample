using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Vehicle
    {
        public string RegNo { get; set; }

        public Vehicle()
        { }
        public Vehicle(string regNo)
        {
            this.RegNo = RegNo;
        }
        public virtual string Drive(double distance) => distance > 0 ? $"Vehicle wants to drive for {distance}" : "Error"; // expression body syntax 
        /*{
           block syntax
        }*/
    }
    
    class fuelVehicle: Vehicle
    {

    }

}

