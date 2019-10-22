using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace lab1.Models
{
    public class Car
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Make { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public int VIN { get; set; }
        private string Color { get; set; }
        [Display(Name = "Dealership ID")]
        public int DealershipID { get; set; }
    }
}
