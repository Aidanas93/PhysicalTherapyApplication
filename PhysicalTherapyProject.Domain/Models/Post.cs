using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PhysicalTherapyProject.Domain.Models
{
    public class Post : BaseEntity
    {
        public Post()
        {
            Images = new HashSet<Image>();
            PostTags = new HashSet<PostTag>();
        }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Body { get; set; }
        public bool isForAuthenticatedUser { get; set; }
        public ICollection<Image> Images { get; set; }
        public DateTime Date { get; set; }
        public ApplicationUser PostUser { get; set; }
        public int? PostTypeId { get; set; }
        public PostType PostType { get; set; }
        public ICollection<PostTag> PostTags { get; set; }
        public override string ToString() => Title;
    }
}
