using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MyFirstApi.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]

        public string Description { get; set; } = string.Empty;
        [Required]
        public string Sku { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; } = false;

        public int CategoryId { get; set; }

        [JsonIgnore]
        public virtual Category? Category { get; set; }
    }
}