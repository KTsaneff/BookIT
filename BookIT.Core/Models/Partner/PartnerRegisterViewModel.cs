using BookIT.Infrastructure.Common;
using System.ComponentModel.DataAnnotations;

namespace BookIT.Core.Models.Partner
{
    public class PartnerRegisterViewModel
    {
        [Required]
        [StringLength(ValidationConstants.UserNameMaxLength, MinimumLength = ValidationConstants.UserNameMinLength)]
        public string FirstName { get; set; } = null!;

        [Required]
        [StringLength(ValidationConstants.UserNameMaxLength, MinimumLength = ValidationConstants.UserNameMinLength)]
        public string LastName { get; set; } = null!;

        [Required]
        public string VATnumber { get; set; } = null!;

        [Required]
        [Phone]
        public string PhoneNumber { get; set; } = null!;

        [Required]
        [EmailAddress]
        [StringLength(ValidationConstants.EmailMaxLength, MinimumLength = ValidationConstants.EmailMinLength)]
        public string Email { get; set; } = null!;

        [Required]
        [StringLength(ValidationConstants.PasswordMaxLength, MinimumLength = ValidationConstants.PasswordMinLength)]
        public string Password { get; set; } = null!;

        [Required]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; } = null!;
    }
}
