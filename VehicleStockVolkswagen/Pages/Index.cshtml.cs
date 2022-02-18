using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VehicleStockVolkswagen.Data;
using VehicleStockVolkswagen.Models;

namespace VehicleStockVolkswagen.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public string Stock { get; set; } = String.Empty;

        public void OnGet()
        {
        }

        //private readonly VehicleStockVolkswagen.Data.VehicleStockVolkswagenContext _context;

        /*public IndexModel(VehicleStockVolkswagen.Data.VehicleStockVolkswagenContext context)
        {
            _context = context;
        }

        public IList<Vehicle> Vehicle { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Stock { get; set; }        //Search vehicle stock

        public async Task OnGetAsync()
        {
            var vehicles = from v in _context.Vehicle                      //receives searched vehicle makes
                           select v;

            if (!string.IsNullOrEmpty(Stock))
            {
                vehicles = vehicles.Where(s => s.Make.Contains(Stock) || s.Model.Contains(Stock));
            }

            //Vehicle = await vehicles.ToList();
        }*/
    }
}