

using System.ComponentModel.DataAnnotations;

namespace TechStore.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string? Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public string? ImageUrl { get; set; }

        public int CategoryId { get; set; }
        public virtual Category? Category { get; set; }

    }
}