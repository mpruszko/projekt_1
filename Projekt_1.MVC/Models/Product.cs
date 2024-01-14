using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Projekt_1.MVC.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please provide name")]
        [StringLength(20)]
        public string Name { get; set; } = default!;
        
        public string? Description { get; set; }

    }
}
