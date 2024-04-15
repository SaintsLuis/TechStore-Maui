

using System.ComponentModel.DataAnnotations;

namespace TechStore.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string? Name { get; set; }
        public string? ImageUrl { get; set; }

        public virtual ICollection<Product>? Products { get; set; }
    }
}