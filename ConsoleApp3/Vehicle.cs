using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Vehicle
    {
        public string RegNo { get; set; }
        public Vehicle()
        {
            this.RegNo = RegNo;
        }
        public string Drive(double distance) => distance > 0 ? $"Vehicle wants to drive for {distance}" // expression body syntax 
        /*{
           block syntax
        }*/
    }
}
