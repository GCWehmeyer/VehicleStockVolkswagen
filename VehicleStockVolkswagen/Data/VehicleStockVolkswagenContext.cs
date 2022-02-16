#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VehicleStockVolkswagen.Models;

namespace VehicleStockVolkswagen.Data
{
    public class VehicleStockVolkswagenContext : DbContext
    {
        public VehicleStockVolkswagenContext (DbContextOptions<VehicleStockVolkswagenContext> options)
            : base(options)
        {
        }

        public DbSet<VehicleStockVolkswagen.Models.Vehicle> Vehicle { get; set; }
    }
}
