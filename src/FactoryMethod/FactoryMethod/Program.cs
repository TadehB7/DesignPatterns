
using FactoryMethod.Enums;
using FactoryMethod.Extensions;
using FactoryMethod.Interfaces;
using Microsoft.Extensions.DependencyInjection;

var serviceProvider = new ServiceCollection()
                                         .AddIVehicleFactory()
                                         .BuildServiceProvider(); 

using IServiceScope serviceScope = serviceProvider.CreateScope();
IServiceProvider provider = serviceScope.ServiceProvider;

IVehicleFactory factory = provider.GetRequiredService<IVehicleFactory>();
IVehicle carService = await factory.GetVehicle(VehicleTypes.Car);
IVehicle motorcycleService = await factory.GetVehicle(VehicleTypes.Motorcycle);

Console.WriteLine( await carService.Construct());
Console.WriteLine(await motorcycleService.Construct());
