using FactoryMethod.Enums;
using FactoryMethod.Extensions;
using FactoryMethod.Implimentation;
using FactoryMethod.Interfaces;

var serviceProvider = new ServiceCollection()
                                         .AddIVehicleFactory()
                                         .AddAbstractFactoryExtension<ICar, Car>()
                                         .AddAbstractFactoryExtension<IMotorcycle, Motorcycle>()
                                         .BuildServiceProvider();

using IServiceScope serviceScope = serviceProvider.CreateScope();
IServiceProvider provider = serviceScope.ServiceProvider;

IVehicleFactory factory = provider.GetRequiredService<IVehicleFactory>();
IVehicle carService = await factory.GetVehicle(VehicleTypes.Car);
IVehicle motorcycleService = await factory.GetVehicle(VehicleTypes.Motorcycle);

IAbstractFactory<ICar> abstractCarservice = provider.GetRequiredService<IAbstractFactory<ICar>>()!;
IAbstractFactory<IMotorcycle> abstractMotorcycleService = provider.GetRequiredService<IAbstractFactory<IMotorcycle>>()!;

Console.WriteLine(await abstractCarservice.Create().Construct());
Console.WriteLine(await abstractMotorcycleService.Create().Construct());
Console.WriteLine(await carService.Construct());
Console.WriteLine(await motorcycleService.Construct());
