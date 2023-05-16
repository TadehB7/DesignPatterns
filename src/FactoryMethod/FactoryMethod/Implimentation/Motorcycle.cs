using FactoryMethod.Enums;
using FactoryMethod.Interfaces;

namespace FactoryMethod.Implimentation
{
    public class Motorcycle : IVehicle
    {
        public VehicleTypes VehicleTypes { get; set; } = VehicleTypes.Motorcycle;

        public Task<string> Construct()
        {
            return Task.FromResult("Motorcycle has been constructed");
        }
    }
}
