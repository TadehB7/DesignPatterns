using FactoryMethod.Enums;

namespace FactoryMethod.Interfaces
{
    public interface IVehicleFactory
    {
        Task<IVehicle> GetVehicle(VehicleTypes vehicleType);
    }
}
