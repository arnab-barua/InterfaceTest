using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAsExtensibilityAndDependencyInjection
{
    class Car : IVehicle
    {
        public decimal Discount { get; set; }

        public Car()
        {
            Discount = 35;
            Console.WriteLine("Car Ride Started at {0}", DateTime.Now);
        }

        public void CalculateFare(decimal distance)
        {
            decimal fare = 0;
            if (distance < 3)
            {
                fare = 70;
            }
            else
            {
                fare = 22 * distance;
            }

            Console.WriteLine("Ride ended at {0}", DateTime.Now);
            Console.WriteLine($"Distance : {distance}KM => Total Fare : BDT{fare - Discount}");

        }
    }
}
