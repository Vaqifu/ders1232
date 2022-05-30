using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Car car1 = new Car();
            car1.Brand = "Mercedes";
            car1.Model = "C class";
            car1.CurrentFuel = 50;
            car1.FuelFor1Km = 1;
            car1.Millage = 120000;



            car1.Drive();



        }
    }
}
