using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhysicalTherapyProjectV2.Models
{
    public class Post : BaseEntity
    {
        public Post()
        {
            Images = new HashSet<Image>();
        }
        public string Title { get; set; }
        public string Body { get; set; }
        public bool isForAuthenticatedUser { get; set; }
        public string VideoLink { get; set; }
        public ICollection<Image> Images { get; set; }
        public ApplicationUser PostUser { get; set; }
        public int? PostTypeId { get; set; }
        public PostType PostType { get; set; }
        public override string ToString() => Title;
    }
}
