using FactoryMethod.Enums;
using FactoryMethod.Interfaces;

namespace FactoryMethod.Implimentation
{
    public class Car : IVehicle
    {
        public VehicleTypes VehicleTypes { get; set; } = VehicleTypes.Car;

        public Task<string> Construct()
        {
            return Task.FromResult("Car has been constructed");
        }
    }
}
