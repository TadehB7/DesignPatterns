using FactoryMethod.Enums;
using FactoryMethod.Interfaces;

namespace FactoryMethod.Implimentation
{
    public class VehicleFactory : IVehicleFactory
    {
        private readonly Func<IEnumerable<IVehicle>> _factory;

        public VehicleFactory(Func<IEnumerable<IVehicle>> factory)
        {
            _factory = factory;
        }
        public Task<IVehicle> GetVehicle(VehicleTypes vehicleType)
        {
            var set = _factory();
            IVehicle vehicle = set.First(x => x.VehicleTypes == vehicleType);
            return Task.FromResult(vehicle);
        }
    }
}
