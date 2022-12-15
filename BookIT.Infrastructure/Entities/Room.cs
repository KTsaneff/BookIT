using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookIT.Infrastructure.Entities
{
    public class Room
    {
        [Key]
        public int Id { get; set; }

        public int CountForSale { get; set; } = 0;

        [Required]
        [Column(TypeName = "money")]
        [Precision(18,2)]
        public decimal PricePerNight { get; set; }

        [Required]        
        public int MainBedsCount { get; set; }

        public int? ExtraBedsCount { get; set; }

        [Required]
        [StringLength(250)]
        public string ImageUrl { get; set; } = null!;

        public bool IsActive { get; set; }

        [Required]
        public int HotelId { get; set; }

        [ForeignKey(nameof(HotelId))]
        public Hotel Hotel { get; set; } = null!;
    }
}
