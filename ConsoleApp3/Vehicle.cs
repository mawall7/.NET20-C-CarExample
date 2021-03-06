using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ConsoleApp3
{
    public interface IDrive
    {
        public string Drive(double distance);
    }
    abstract class AbstractVehicle: IDrive
    {
        public virtual string Drive(double distance) => distance > 0 ? $"Vehicle wants to drive for {distance}" : "Error"; // expression body syntax  
        public abstract string Turn(); // can have both undefined and defined memebers, must be defined on implementation
    }   
    class Vehicle: AbstractVehicle
    {
        public string RegNo { get; set; }

        //public Vehicle()
        //{ }
        public Vehicle(string regNo)
        {
            this.RegNo = RegNo;
        }

        public override string Turn()
        {
            return "Vehicle turns";
        }
        //public virtual string Drive(double distance) => distance > 0 ? $"Vehicle wants to drive for {distance}" : "Error"; // expression body syntax 
        /*{
           block syntax
        }*/
    }
    
     class Bicycle:AbstractVehicle // måste implementra den abstrakta klassens metoder
    {
        public string Framenumber { get; set; }
        public Bicycle(string framenumber)
        {
            Framenumber = this.Framenumber;
        }

        public override string Turn() => "Bicycle turns";

        public override string Drive(double distance)
        {
            return "Bicyle starts pedaling";
        }

    }
     class fuelVehicle: Vehicle
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
        public string Sound() => "Tut tut";

    }
    class FuelCar : fuelVehicle
    {
        private const double fuelConsumption = 0.5;
        public double maxdistance => FuelLevel / fuelConsumption;
        public double Milage { get; private set; }
        public FuelCar(string regNo, double fuelCapacity) : base(regNo, fuelCapacity)
        {

        }

        public override string Drive(double distance)
        {
            var result = new StringBuilder();
            result.AppendLine(base.Drive(distance)); //kommer börja bygga strängen från basklassens Drive metod dvs. Vehicle wants to drive for distance

            if (distance < 0)
            {
                distance = 0;
                result.AppendLine("negative distance is assumed to be 0");
            }

            FuelLevel -= distance * fuelConsumption;
            result.AppendLine($"regNo{RegNo} drove{distance}km");//+ ny implementation
            return result.ToString();
        }
    }

}

