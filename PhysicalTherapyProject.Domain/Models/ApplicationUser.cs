using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhysicalTherapyProject.Domain.Models
{
    public class ApplicationUser : IdentityUser<int>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Image Image { get; set; }
        public int OccupationId { get; set; }
        public Occupation Occupation { get; set; }
        public bool IsConfirmed { get; set; } = false;
        public ICollection<Post> UserPosts { get; set; }
    }
}
