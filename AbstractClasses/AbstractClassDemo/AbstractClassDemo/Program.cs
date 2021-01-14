using System;

namespace AbstractClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.VIN = "25632";
            Console.ReadLine();
        }
    }

   

    public abstract class Vehicle 
    {
        public string VIN {get; set; }
        public string Manufracturer { get;set; }
        public string Model { get; set; }
        public int YearManufactured { get; set; }

    }

    public class Car : Vehicle
    {
        public int NOofWheel { get; set; } = 4;
    }
}
