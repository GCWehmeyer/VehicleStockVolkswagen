using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
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

        public IList<Vehicle> Vehicle { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Stock { get; set; }        //Search vehicle stock

        public void OnGet()
        {

        }
    }
}