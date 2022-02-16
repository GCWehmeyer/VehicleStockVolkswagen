using System.ComponentModel.DataAnnotations;

namespace VehicleStockVolkswagen.Models
{
    public class Vehicle
    {
        public int ID { get; set; }
        public string Make { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;
        public string Engine { get; set; } = string.Empty;
        public string Gear { get; set; } = string.Empty;
        public int Stock { get; set; }
        public decimal Price { get; set; }
    }
}