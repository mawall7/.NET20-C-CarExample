using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ConsoleApp3
{
    public class Vehicle
    {
        public string RegNo { get; set; }

        //public Vehicle()
        //{ }
        public Vehicle(string regNo)
        {
            this.RegNo = RegNo;
        }
        public virtual string Drive(double distance) => distance > 0 ? $"Vehicle wants to drive for {distance}" : "Error"; // expression body syntax 
        /*{
           block syntax
        }*/
    }
    
    public class fuelVehicle: Vehicle
    {
        public double FuelCapacity { get; }
        
        private double fuelLevel;
        //[Range(0,1000)]
        public double FuelLevel { 
            get
            {
                return fuelLevel;
            }
            set 
            {
                double newLevel = Math.Max(0, value); // för att undvika negativa ett negativt värde! eller använd Dataannotations
                fuelLevel = Math.Min(newLevel, FuelCapacity);
            }
        }
        fuelVehicle(string regNo, double fuelCapacity):base(regNo)   
        {
            FuelCapacity = fuelCapacity;
        }

    }

}

