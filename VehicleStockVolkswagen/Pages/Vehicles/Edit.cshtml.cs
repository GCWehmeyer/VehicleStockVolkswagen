#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VehicleStockVolkswagen.Data;
using VehicleStockVolkswagen.Models;

namespace VehicleStockVolkswagen.Pages.Vehicles
{
    public class EditModel : PageModel
    {
        private readonly VehicleStockVolkswagen.Data.VehicleStockVolkswagenContext _context;

        public EditModel(VehicleStockVolkswagen.Data.VehicleStockVolkswagenContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Vehicle Vehicle { get; set; }

        //Test if record has data and return selected record's data if found
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

        //Saves the changes made to the selected record
        public async Task<IActionResult> OnPostAsync()                 
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Vehicle).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VehicleExists(Vehicle.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            //Return to stock list
            return RedirectToPage("./Index");                           
        }

        //Function to check if record exists
        private bool VehicleExists(int id)                              
        {
            return _context.Vehicle.Any(e => e.ID == id);
        }
    }
}
