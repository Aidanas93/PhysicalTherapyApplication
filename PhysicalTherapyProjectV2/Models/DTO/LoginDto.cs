using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PhysicalTherapyProjectV2.Models
{
    public class LoginDto
    {
        [Required(ErrorMessage = "Neįvestas El. Paštas")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Neįvestas Slaptažodis")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
