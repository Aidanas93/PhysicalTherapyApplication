using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PhysicalTherapyProjectV2.Models
{
    public class Image : BaseEntity
    {
        [Required]
        public byte[] Content { get; set; }

    }
}
