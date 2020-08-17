using System.ComponentModel.DataAnnotations;

namespace PhysicalTherapyProject.Domain.Models
{
    public class Image : BaseEntity
    {
        [Required]
        public byte[] Content { get; set; }

    }
}
