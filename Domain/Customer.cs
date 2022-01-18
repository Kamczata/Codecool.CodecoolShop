using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(40)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(40)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(60)]
        public string Email { get; set; }
        [Required]
        [MaxLength(150)]
        public string Address { get; set; }
        [Required]
        [MaxLength(20)]
        public string Country { get; set; }
        [Required]
        [MaxLength(20)]
        public string City { get; set; }
        [Required]
        [MaxLength(10)]
        public string Zip { get; set; }
        [Required]
        [MaxLength(40)]
        public string CardHolder { get; set; }
        [Required]
        [MaxLength(40)]
        public string CardNumber { get; set; }
        [Required]
        [MaxLength(20)]
        public string CardExpiry { get; set; }
        [Required]
        [MaxLength(10)]
        public int SecurityCode { get; set; }

    }
}
