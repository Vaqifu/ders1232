using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class Car
    {
        public string Brand;
        public string Model;
        public int CurrentFuel;   
        public int FuelFor1Km;
        public int Millage;



        public void Drive()
        {

            Console.WriteLine("nece km surmek istediyinizi daxil edin");
            string kmStr = Console.ReadLine();
            int km = Convert.ToInt32(kmStr);

            int Drive =(FuelFor1Km*km);
            CurrentFuel -= Drive;
            Millage += Drive;

            if (CurrentFuel >= FuelFor1Km)
            {

                Console.WriteLine($"{CurrentFuel}  {Millage}");

            }
            else
            {
                Console.WriteLine("warning");
            }


        }
    }
}
