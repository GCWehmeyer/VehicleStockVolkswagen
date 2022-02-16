using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using VehicleStockVolkswagen.Data;
using System;
using System.Linq;

namespace VehicleStockVolkswagen.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new VehicleStockVolkswagenContext(
                serviceProvider.GetRequiredService<DbContextOptions<VehicleStockVolkswagenContext>>()))
            {
                if (context == null || context.Vehicle == null)
                {
                    throw new ArgumentNullException("Null VehicleStockVolkswagenContext");
                }

                //Look for any vehicles
                if (context.Vehicle.Any())
                {
                   return;                     //DB has been seeded
                }

                //Created seed data from https://www.vw.co.za/en/models-andconfigurator.html
                context.Vehicle.AddRange(
                    new Vehicle
                    {
                        Make = "Golf",
                        Model = "2021",
                        Body = "Hatch",
                        Engine = "Petrol",
                        Gear = "Automatic",
                        Stock = 6,
                        Price = 682700
                    },
                    new Vehicle
                    {
                        Make = "Polo",
                        Model = "2021",
                        Body = "Hatch",
                        Engine = "Petrol",
                        Gear = "Manual",
                        Stock = 6,
                        Price = 489400
                    },
                    new Vehicle
                    {
                        Make = "Polo",
                        Model = "2021",
                        Body = "Sedan",
                        Engine = "Petrol",
                        Gear = "Automatic",
                        Stock = 2,
                        Price = 326700
                    },
                    new Vehicle
                    {
                        Make = "Polo",
                        Model = "GTI",
                        Body = "Hatch",
                        Engine = "Petrol",
                        Gear = "Automatic",
                        Stock = 5,
                        Price = 489400
                    },
                    new Vehicle
                    {
                        Make = "Golf",
                        Model = "GTI",
                        Body = "Hatch",
                        Engine = "Petrol",
                        Gear = "Automatic",
                        Stock = 8,
                        Price = 682700
                    },
                    new Vehicle
                    {
                        Make = "T-Cross",
                        Model = "2021",
                        Body = "SUV",
                        Engine = "Petrol",
                        Gear = "Manual",
                        Stock = 4,
                        Price = 407300
                    },
                    new Vehicle
                    {
                        Make = "Polo",
                        Model = "Trendline",
                        Body = "Sedan",
                        Engine = "Petrol",
                        Gear = "Manual",
                        Stock = 3,
                        Price = 262700
                    },
                    new Vehicle
                    {
                        Make = "Polo",
                        Model = "Comfortline",
                        Body = "Sedan",
                        Engine = "Petrol",
                        Gear = "Manual",
                        Stock = 3,
                        Price = 286900
                    },
                    new Vehicle
                    {
                        Make = "Polo",
                        Model = "2021",
                        Body = "Hatch",
                        Engine = "Petrol",
                        Gear = "Manual",
                        Stock = 5,
                        Price = 311800
                    },
                    new Vehicle
                    {
                        Make = "Polo",
                        Model = "Life",
                        Body = "Hatch",
                        Engine = "Petrol",
                        Gear = "Manual",
                        Stock = 2,
                        Price = 350000
                    },
                    new Vehicle
                    {
                        Make = "T-Cross",
                        Model = "Comfortline",
                        Body = "SUV",
                        Engine = "Petrol",
                        Gear = "Manual",
                        Stock = 5,
                        Price = 365100
                    },
                    new Vehicle
                    {
                        Make = "Polo",
                        Model = "Comfortline",
                        Body = "Sedan",
                        Engine = "Petrol",
                        Gear = "Automatic",
                        Stock = 4,
                        Price = 286900
                    },
                    new Vehicle
                    {                   
                        Make = "T-Cross",
                        Model = "Highline",
                        Body = "Hatch",
                        Engine = "Petrol",
                        Gear = "Automatic",
                        Stock = 4,
                        Price = 443800
                    },
                    new Vehicle
                    {
                        Make = "T-Cross",
                        Model = "R-line",
                        Body = "Hatch",
                        Engine = "Petrol",
                        Gear = "Automatic",
                        Stock = 3,
                        Price = 481700
                    },
                    new Vehicle
                    {
                        Make = "T-Roc",
                        Model = "R-line",
                        Body = "SUV",
                        Engine = "Petrol",
                        Gear = "Automatic",
                        Stock = 2,
                        Price = 628900
                    },
                    new Vehicle
                    {
                        Make = "Polo",
                        Model = "Life",
                        Body = "Hatch",
                        Engine = "Petrol",
                        Gear = "Automatic",
                        Stock = 2,
                        Price = 350000
                    },
                    new Vehicle
                    {
                        Make = "Tiguan",
                        Model = "2021",
                        Body = "SUV",
                        Engine = "Petrol",
                        Gear = "Automatic",
                        Stock = 5,
                        Price = 541800
                    },
                    new Vehicle
                    {
                        Make = "Tiguan Allspace",
                        Model = "Trendline",
                        Body = "SUV",
                        Engine = "Petrol",
                        Gear = "Automatic",
                        Stock = 3,
                        Price = 572800
                    },
                    new Vehicle
                    {
                        Make = "Tiguan Allspace",
                        Model = "Comfortline",
                        Body = "SUV",
                        Engine = "Petrol",
                        Gear = "Automatic",
                        Stock = 2,
                        Price = 656800
                    },
                    new Vehicle
                    {
                        Make = "Tiguan Allspace",
                        Model = "Highline",
                        Body = "SUV",
                        Engine = "Petrol",
                        Gear = "Automatic",
                        Stock = 2,
                        Price = 768900
                    },
                    new Vehicle
                    {
                        Make = "Polo",
                        Model = "R-Line",
                        Body = "Hatch",
                        Engine = "Petrol",
                        Gear = "Automatic",
                        Stock = 2,
                        Price = 350000
                    },
                    new Vehicle
                    {
                        Make = "Polo",
                        Model = "Vivo",
                        Body = "Hatch",
                        Engine = "Diesel",
                        Gear = "Manual",
                        Stock = 2,
                        Price = 232500
                    }


                );
                context.SaveChanges();
            }
        }
    }
}
