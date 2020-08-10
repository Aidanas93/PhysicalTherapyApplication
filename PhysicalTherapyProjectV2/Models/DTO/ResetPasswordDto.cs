using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PhysicalTherapyProjectV2.Models.DTO
{
    public class ResetPasswordDto
    {
        public string Email { get; set; }
        public string Token { get; set; }
        [Required(ErrorMessage = "Neįvestas Slaptažodis")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Slaptažodis turi būti mažiausiai 6 simbolių")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Neįvestas Slaptažodis")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Slaptažodžiai Nesutampa")]
        public string ConfirmPassword { get; set; }
    }
}
