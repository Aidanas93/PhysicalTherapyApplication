using System.ComponentModel.DataAnnotations;

namespace PhysicalTherapyProject.Domain.Models
{
    public class Image : BaseEntity
    {
        [Required]
        public byte[] Content { get; set; }
        public int? PostId { get; set; }
        public Post Post { get; set; }
    }
}
