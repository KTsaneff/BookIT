using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookIT.Infrastructure.Entities
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Adults { get; set; }

        [Required]
        public int Children { get; set; }

        [Required]
        public DateTime CheckInDate { get; set; }

        [Required]
        public DateTime CheckOutDate { get; set; }

        public bool IsCancelled { get; set; } = false;

        [Required]
        [Column(TypeName = "money")]
        [Precision(18, 2)]
        public decimal PricePerNight { get; set; }

        [Required]
        [Column(TypeName = "money")]
        [Precision(18, 2)]
        public decimal TotalPrice { get; set; }

        [Required]
        public string GuestId { get; set; } = null!;

        [ForeignKey(nameof(GuestId))]
        public IdentityUser Guest { get; set; } = null!;

        [Required]
        public int HotelId { get; set; }

        [ForeignKey(nameof(HotelId))]
        public Hotel Hotel { get; set; } = null!;
    }
}
