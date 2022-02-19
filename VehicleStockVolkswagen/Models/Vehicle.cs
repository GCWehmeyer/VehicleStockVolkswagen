using System.ComponentModel.DataAnnotations;

namespace VehicleStockVolkswagen.Models
{
    public class Vehicle            //Vehicle class with it's attributes
    {
        public int ID { get; set; }

        [Required]
        public string Make { get; set; } = string.Empty;

        public string Model { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Body Type")]
        public string Body { get; set; } = string.Empty;
        [Required]
        public string Engine { get; set; } = string.Empty;
        [Required]
        public string Gear { get; set; } = string.Empty;

        public int Stock { get; set; }

        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
    }
}