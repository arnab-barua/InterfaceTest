namespace InterfaceAsExtensibilityAndDependencyInjection
{
    public interface IVehicle
    {
        decimal Discount { get; set; }

        void CalculateFare(decimal distance);        
    }
}
