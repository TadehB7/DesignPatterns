using FactoryMethod.Enums;

namespace FactoryMethod.Interfaces
{
    public interface IVehicle
    {
        VehicleTypes VehicleTypes { get; set; }

        Task<string> Construct();

    }
}
