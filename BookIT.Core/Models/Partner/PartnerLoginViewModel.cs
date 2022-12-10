using System.ComponentModel.DataAnnotations;

namespace BookIT.Core.Models.Partner
{
    public class PartnerLoginViewModel
    {
        [Required]
        public string VATnumber { get; set; } = null!;

        [Required]
        public string Email { get; set; } = null!;

        [Required]
        public string Password { get; set; } = null!;
    }
}
