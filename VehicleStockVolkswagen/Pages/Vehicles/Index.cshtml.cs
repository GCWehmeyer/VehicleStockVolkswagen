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
    public class IndexModel : PageModel
    {
        private readonly VehicleStockVolkswagen.Data.VehicleStockVolkswagenContext _context;

        public IndexModel(VehicleStockVolkswagen.Data.VehicleStockVolkswagenContext context)
        {
            _context = context;
        }

        public IList<Vehicle> Vehicle { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }        //Search vehicle by text 

        public SelectList Body { get; set;  }           //Search per body type
        [BindProperty(SupportsGet = true)]
        public string VehicleBody { get; set; }

        public SelectList Engine { get; set; }          //Search per engine type
        [BindProperty(SupportsGet = true)]
        public string VehicleEngine { get; set; }

        public SelectList Gear { get; set; }            //Search per gear type
        [BindProperty(SupportsGet = true)]
        public string VehicleGear { get; set; }

        public async Task OnGetAsync()
        {
            var vehicles = from v in _context.Vehicle                       //receives searched vehicle makes
                           select v;

            IQueryable<string> bodyQuery = from v in _context.Vehicle       //receives all body types from database
                                           orderby v.Body
                                           select v.Body;

            IQueryable<string> engineQuery = from v in _context.Vehicle     //receives all engine types from database
                                             orderby v.Engine
                                             select v.Engine;

            IQueryable<string> gearQuery = from v in _context.Vehicle       //receives all gear types from database
                                           orderby v.Gear
                                           select v.Gear;


            if (!string.IsNullOrEmpty(SearchString))
            {
                vehicles = vehicles.Where(s => s.Make.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(VehicleBody))
            {
                vehicles = vehicles.Where(b => b.Body == VehicleBody);
            }

            if (!string.IsNullOrEmpty(VehicleEngine))
            {
                vehicles = vehicles.Where(e => e.Engine == VehicleEngine);
            }

            if (!string.IsNullOrEmpty(VehicleGear))
            {
                vehicles = vehicles.Where(g => g.Gear == VehicleGear);
            }

            Body = new SelectList(await bodyQuery.Distinct().ToListAsync());            //Searched list creation
            Engine = new SelectList(await engineQuery.Distinct().ToListAsync());
            Gear = new SelectList(await gearQuery.Distinct().ToListAsync());
            Vehicle = await vehicles.ToListAsync();
        }
    }
}
