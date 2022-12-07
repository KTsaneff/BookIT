using System.ComponentModel.DataAnnotations;

namespace BookIT.Infrastructure.Entities
{
    public class Country
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(60)]
        public string Name { get; set; } = null!;

        [MaxLength(1000)]
        public string? Description { get; set; }

        public List<Hotel> Hotels { get; set; } = new List<Hotel>();

        public List<Region> Regions { get; set; } = new List<Region>();
    }
}
