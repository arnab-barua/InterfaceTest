namespace InterfaceAsExtensibilityAndDependencyInjection
{
    public class Ride
    {
        private readonly IVehicle _vehicle;

        public Ride(IVehicle vehicle)
        {
            _vehicle = vehicle;
        }

        public void EndRide(decimal distance)
        {
            _vehicle.CalculateFare(distance);
        }
    }
}
