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
        public fuelVehicle(string regNo, double fuelCapacity) : base(regNo)
        {
            FuelCapacity = fuelCapacity;
        }

        //överladdad konstruktor this går till ctor2
        //fuelVehicle(string regNo, double fuelCapacity):this(regNo)   
        //{
        //    FuelCapacity = fuelCapacity;
        //}
        ////ctor2
        //fuelVehicle(string regNo) : base(regNo)
        //{

        //}
        

    }
    class fuelCar : fuelVehicle
    {
        private const double fuelConsumption = 0.5;
        public double maxdistance => FuelLevel / fuelConsumption;
        public double Milage { get; private set; }
        public fuelCar(string regNo, double fuelCapacity) : base(regNo, fuelCapacity)
        {

        }

        public override string Drive(double distance)
        {
            var result = new StringBuilder();
            result.AppendLine(base.Drive(distance));

            if (distance < 0)
            {
                distance = 0;
                result.AppendLine("negative distance is assumed to be 0");
            }

            FuelLevel -= distance * fuelConsumption;
            result.AppendLine($"regNo{RegNo} drove{distance}km");
            return result.ToString();
        }
    }

}

