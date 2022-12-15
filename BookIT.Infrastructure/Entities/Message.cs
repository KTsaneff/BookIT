using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookIT.Infrastructure.Entities
{
    public class Message
    {
        [Key]
        public int Id { get; set; }

        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        [MaxLength(500)]
        public string Text { get; set; } = null!;

        [Required]
        public bool IsRead { get; set; } = false;

        public string SenderId { get; set; } = null!;

        [ForeignKey(nameof(SenderId))]
        public ApplicationUser Sender { get; set; } = null!;
    }
}
