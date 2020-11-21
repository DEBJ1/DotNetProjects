using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public class Cookie
    {
        public string Name { get; set; }
        public bool HasNuts { get; set; }
        public double GramsOfFlour { get; set; }


        public Cookie()
        {

        }

        public Cookie( string name, bool hasNuts, double gramsOfFlour)
        {
            Name = name;
            HasNuts = hasNuts; 
            GramsOfFlour = gramsOfFlour;
        }
    }


    public enum VehicleType {Car, Truck, Van, Motorcyle, spaceship, plane, boat}

    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int MyProperty { get; set; }
        public VehicleType TypeOFVehicle { get; set; }
    }

    public class Order
    {
        public string CustomerName { get; set; }

        public Cookie OrderedProduct { get; set; }
        public decimal TotalCost { get; set; }
    }
}
