using System;

namespace InterfaceAsExtensibilityAndDependencyInjection
{
    class Program
    { 
        static void Main(string[] args)
        {
            //Initially this ride sharing app has only bike ride
            Ride ride = new Ride(new Bike());
            ride.EndRide(4);


            //A few days later car ride added
            //to extend this app create a new class Car implementing 
            //IVehicle interface
            //Then Create a new Ride Object by passing a Car object as parameter
            ride = new Ride(new Car());
            ride.EndRide(5);
            Console.ReadKey();
        }
    }
}
