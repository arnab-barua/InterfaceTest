using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAsExtensibilityAndDependencyInjection
{
    class Bike : IVehicle
    {
        public decimal Discount { get; set; }

        public Bike()
        {
            Discount = 20;
            Console.WriteLine("Bike Ride Started at {0}", DateTime.Now);
        }

        public void CalculateFare(decimal distance)
        {
            decimal fare = 0;
            if (distance < 2)
            {
                fare = 40;
            }
            else if(distance >= 2 && distance <= 7)
            {
                fare = 20 * distance;
            }
            else
            {
                fare = 18 * distance;
            }
            Console.WriteLine("Bike ride ended at {0}", DateTime.Now);
            Console.WriteLine($"Distance : {distance}KM => Total fare : BDT{fare - Discount}");
        }
        
    }
}
