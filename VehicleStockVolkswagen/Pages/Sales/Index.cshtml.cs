#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VehicleStockVolkswagen.Data;
using VehicleStockVolkswagen.Models;

namespace VehicleStockVolkswagen.Pages.Sales
{
    public class IndexModel : PageModel
    {
        private readonly VehicleStockVolkswagen.Data.VehicleStockVolkswagenContext _context;

        public IndexModel(VehicleStockVolkswagen.Data.VehicleStockVolkswagenContext context)
        {
            _context = context;
        }       

        public IList<Vehicle> Vehicle { get;set; }
        [BindProperty(SupportsGet = true)]
        public string Sales { get; set; } = String.Empty;

        //Search for vehicles in database
        public async Task OnGetAsync()
        {
            var vehicles = from v in _context.Vehicle                      
                           select v;

            if (!string.IsNullOrEmpty(Sales))
            {
                vehicles = vehicles.Where(s => s.Make.Contains(Sales) || s.Model.Contains(Sales));  //Receives searched vehicle ny make or model
            }

            Vehicle = await vehicles.ToListAsync();
        }
      

    }
}
