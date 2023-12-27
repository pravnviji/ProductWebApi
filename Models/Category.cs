using System.Text.Json.Serialization;

namespace MyFirstApi.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        [JsonIgnore]
        public virtual List<Product> Product { get; set; }
    }
}