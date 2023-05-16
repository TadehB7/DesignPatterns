using FactoryMethod.Implimentation;
using FactoryMethod.Interfaces;

namespace FactoryMethod.Extensions
{
    public static class AbstractFactoryExtension
    {
        public static IServiceCollection AddAbstractFactoryExtension<TInterface, TImplimentation>(this IServiceCollection services)
            where TInterface : class
            where TImplimentation : class, TInterface
        {
            return services.AddTransient<TInterface, TImplimentation>()
                    .AddTransient<Func<TInterface>>(x => () => x.GetRequiredService<TInterface>()!)
                    .AddSingleton<IAbstractFactory<TInterface>, AbstractFactory<TInterface>>();

        }
    }
}
