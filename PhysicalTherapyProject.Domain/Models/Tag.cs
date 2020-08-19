using System.Collections.Generic;

namespace PhysicalTherapyProject.Domain.Models
{
    public class Tag : BaseEntity
    {
        public string TagValue { get; set; }

        public ICollection<PostTag> PostTags { get; set; }
    }
}
