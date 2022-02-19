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

        [BindProperty]
        public Vehicle VehicleStock { get; set; }


        public async Task OnGetAsync()
        {
            var vehicles = from v in _context.Vehicle                      //receives searched vehicle makes
                           select v;

            IEnumerable<int> sellStock = from s in _context.Vehicle
                                         where s.Stock >= 0
                                         select s.Stock;

            IEnumerable<int> buyStock = from b in _context.Vehicle
                                         where b.Stock >= 0
                                         select b.Stock;

            if (!string.IsNullOrEmpty(Sales))
            {
                vehicles = vehicles.Where(s => s.Make.Contains(Sales) || s.Model.Contains(Sales));
            }

            Vehicle = await vehicles.ToListAsync();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(VehicleStock).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StockExists(VehicleStock.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool StockExists(int id)
        {
            return _context.Vehicle.Any(e => e.ID == id && e.Stock >= 0);
        }
    }
}
