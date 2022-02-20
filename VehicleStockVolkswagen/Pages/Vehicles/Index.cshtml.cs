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

        //Variables used to search for vehicle specifications
        public IList<Vehicle> Vehicle { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }        

        public SelectList Body { get; set;  }           
        [BindProperty(SupportsGet = true)]
        public string VehicleBody { get; set; }

        public SelectList Engine { get; set; }          
        [BindProperty(SupportsGet = true)]
        public string VehicleEngine { get; set; }

        public SelectList Gear { get; set; }            
        [BindProperty(SupportsGet = true)]
        public string VehicleGear { get; set; }

        public async Task OnGetAsync()
        {
            var vehicles = from v in _context.Vehicle                           //SQL for all vehicles
                           select v;

            IQueryable<string> bodyQuery = from v in _context.Vehicle           //SQL for specific body type
                                           orderby v.Body
                                           select v.Body;

            IQueryable<string> engineQuery = from v in _context.Vehicle         //SQL for specific engine type
                                             orderby v.Engine
                                             select v.Engine;

            IQueryable<string> gearQuery = from v in _context.Vehicle           //SQL for specific gear type
                                           orderby v.Gear
                                           select v.Gear;


            if (!string.IsNullOrEmpty(SearchString))
            {
                vehicles = vehicles.Where(s => s.Make.Contains(SearchString));  //receives searched vehicle makes
            }

            if (!string.IsNullOrEmpty(VehicleBody))
            {
                vehicles = vehicles.Where(b => b.Body == VehicleBody);          //receives all body types from database
            }

            if (!string.IsNullOrEmpty(VehicleEngine))
            {
                vehicles = vehicles.Where(e => e.Engine == VehicleEngine);      //receives all engine types from database
            }

            if (!string.IsNullOrEmpty(VehicleGear))
            {
                vehicles = vehicles.Where(g => g.Gear == VehicleGear);          //receives all gear types from database
            }

            //Searched list creation for make, body type, engine type or gear type
            Body = new SelectList(await bodyQuery.Distinct().ToListAsync());            
            Engine = new SelectList(await engineQuery.Distinct().ToListAsync());
            Gear = new SelectList(await gearQuery.Distinct().ToListAsync());
            Vehicle = await vehicles.ToListAsync();
        }
    }
}
