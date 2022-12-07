using System.ComponentModel.DataAnnotations;

namespace BookIT.Infrastructure.Entities
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; } = null!;

        public List<Hotel> Hotels { get; set; } = new List<Hotel>();
    }
}
