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

namespace VehicleStockVolkswagen.Pages.Vehicles
{
    public class DeleteModel : PageModel
    {
        private readonly VehicleStockVolkswagen.Data.VehicleStockVolkswagenContext _context;

        public DeleteModel(VehicleStockVolkswagen.Data.VehicleStockVolkswagenContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Vehicle Vehicle { get; set; }

        //Test for record's data and return the data if found
        public async Task<IActionResult> OnGetAsync(int? id)        
        {
            if (id == null)
            {
                return NotFound();
            }

            Vehicle = await _context.Vehicle.FirstOrDefaultAsync(m => m.ID == id);

            if (Vehicle == null)
            {
                return NotFound();
            }
            return Page();
        }

        //Removes the selected record from database
        public async Task<IActionResult> OnPostAsync(int? id)       
        {
            if (id == null)
            {
                return NotFound();
            }

            Vehicle = await _context.Vehicle.FindAsync(id);

            if (Vehicle != null)
            {
                _context.Vehicle.Remove(Vehicle);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
