

using System.ComponentModel.DataAnnotations.Schema;

namespace TechStore.Models
{
    [Table("Advertisements")]
    public class Advertisements
    {
        public int AdvertisementsId { get; set; }
        public string? ImageUrl { get; set; }

    }
}