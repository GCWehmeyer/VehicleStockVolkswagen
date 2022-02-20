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
                //Test for data on context
                if (context == null || context.Vehicle == null)
                {
                    throw new ArgumentNullException("Null VehicleStockVolkswagenContext");
                }

                //Look for any records
                if (context.Vehicle.Any())
                {
                   return;                     //DB has been seeded
                }

                //Add data to Seed database
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
                    },
                    new Vehicle
                    {
                        Make = "Touareg",
                        Model = "Luxury",
                        Body = "SUV",
                        Engine = "Diesel",
                        Gear = "Automatic",
                        Stock = 2,
                        Price = 1279700
                    },
                    new Vehicle
                    {
                        Make = "Touareg",
                        Model = "Executive",
                        Body = "SUV",
                        Engine = "Diesel",
                        Gear = "Automatic",
                        Stock = 1,
                        Price = 1559700
                    },
                    new Vehicle
                    {
                        Make = "Amarok",
                        Model = "Double Cab Highline",
                        Body = "Bakkie",
                        Engine = "Diesel",
                        Gear = "Manual",
                        Stock = 5,
                        Price = 751400
                    },
                    new Vehicle
                    {
                        Make = "Amarok",
                        Model = "Double Cab Highline",
                        Body = "Bakkie",
                        Engine = "Diesel",
                        Gear = "Automatic",
                        Stock = 4,
                        Price = 756500
                    },
                    new Vehicle
                    {
                        Make = "Amarok",
                        Model = "Double Cab Extreme",
                        Body = "Bakkie",
                        Engine = "Diesel",
                        Gear = "Automatic",
                        Stock = 5,
                        Price = 1057500
                    },
                    new Vehicle
                    {
                        Make = "Caddy",
                        Model = "5-seater",
                        Body = "Van",
                        Engine = "Two-powered",
                        Gear = "Manual",
                        Stock = 3,
                        Price = 484200
                    },
                    new Vehicle
                    {
                        Make = "Caddy",
                        Model = "7-seater",
                        Body = "Van",
                        Engine = "Two-powered",
                        Gear = "Manual",
                        Stock = 3,
                        Price = 600400
                    },
                    new Vehicle
                    {
                        Make = "Caddy",
                        Model = "Kombi 5-seater",
                        Body = "Van",
                        Engine = "Two-powered",
                        Gear = "Manual",
                        Stock = 2,
                        Price = 502700
                    },
                    new Vehicle
                    {
                        Make = "Caddy",
                        Model = "Kombi 7-seater",
                        Body = "Van",
                        Engine = "Two-powered",
                        Gear = "Manual",
                        Stock = 4,
                        Price = 412100
                    },
                    new Vehicle
                    {
                        Make = "Caddy",
                        Model = "Cargo",
                        Body = "Van",
                        Engine = "Two-powered",
                        Gear = "Manual",
                        Stock = 5,
                        Price = 404000
                    },
                    new Vehicle
                    {
                        Make = "Kombi 6.1",
                        Model = "Treandline Plus",
                        Body = "Van",
                        Engine = "Diesel",
                        Gear = "Automatic",
                        Stock = 5,
                        Price = 962700
                    },
                    new Vehicle
                    {
                        Make = "Caravelle 6.1",
                        Model = "Highline",
                        Body = "Van",
                        Engine = "Diesel",
                        Gear = "Automatic",
                        Stock = 3,
                        Price = 1255900
                    },
                    new Vehicle
                    {
                        Make = "Crafter",
                        Model = "Panel",
                        Body = "Van",
                        Engine = "Diesel",
                        Gear = "Automatic",
                        Stock = 4,
                        Price = 697700
                    }

                );
                //Save Seed data to context
                context.SaveChanges();
            }
        }
    }
}
