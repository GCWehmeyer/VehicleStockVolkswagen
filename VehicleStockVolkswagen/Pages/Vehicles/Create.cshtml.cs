#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using VehicleStockVolkswagen.Data;
using VehicleStockVolkswagen.Models;

namespace VehicleStockVolkswagen.Pages.Vehicles
{
    public class CreateModel : PageModel
    {
        private readonly VehicleStockVolkswagen.Data.VehicleStockVolkswagenContext _context;

        public CreateModel(VehicleStockVolkswagen.Data.VehicleStockVolkswagenContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()        //Return create page
        {
            return Page();
        }

        [BindProperty]
        public Vehicle Vehicle { get; set; }

        public async Task<IActionResult> OnPostAsync()  //Creates new vehicle entry into database
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Vehicle.Add(Vehicle);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
