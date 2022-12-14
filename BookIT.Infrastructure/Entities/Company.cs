using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookIT.Infrastructure.Entities
{
    public class Company
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = null!;

        [Required]
        public string Address { get; set; } = null!;

        [Required]
        [MaxLength(15)]
        public string VATnumber { get; set; } = null!;

        [Required]
        [MaxLength(80)]
        public string AccountablePersonFullName { get; set; } = null!;

        [Required]
        public string HostId { get; set; } = null!;

        [ForeignKey(nameof(HostId))]
        public ApplicationUser Host { get; set; } = null!;
    }
}
