using FactoryMethod.Implimentation;
using FactoryMethod.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace FactoryMethod.Extensions
{
    public static class FactoryExtension
    {

        public static IServiceCollection AddIVehicleFactory(this IServiceCollection services)
        {
            return services.AddTransient<IVehicle, Car>()
                           .AddTransient<IVehicle, Motorcycle>()
                           .AddTransient<IVehicleFactory, VehicleFactory>()
                           .AddFuncFactory<IVehicle>();
        }

        private static IServiceCollection AddFuncFactory<TInterface>(this IServiceCollection services)
             where TInterface : class
        {
            services.AddSingleton<Func<IEnumerable<TInterface>>>(x => x.GetRequiredService<IEnumerable<TInterface>>);
            return services;
        }

    }
}
