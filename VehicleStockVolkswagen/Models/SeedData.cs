using Microsoft.EntityFrameworkCore;
using VehicleStockVolkswagen.Data;

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
                    return;                 //DB has been seeded
                }
                //Create seed data
                context.Vehicle.AddRange(  
                    new Vehicle
                    {
                        Make = "Polo",
                        Model = "Trendline",
                        Body = "Sedan",
                        Engine = "Petrol",
                        Gear = "Manual",
                        Stock = 4,
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
                        Model = "Polo",
                        Body = "Hatch",
                        Engine = "Petrol",
                        Gear = "Manual",
                        Stock = 8,
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
                        Body = "Sedan",
                        Engine = "Petrol",
                        Gear = "Manual",
                        Stock = 6,
                        Price = 365100
                    }

                    );
                context.SaveChanges();
            }
        }
    }
}
