using Microsoft.AspNetCore.Identity;
using PhysicalTherapyProject.Domain.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhysicalTherapyProject.Domain.Models
{
    public class ApplicationUser : IdentityUser<int>, IEntity
    {
        public ApplicationUser()
        {
            this.CreatedOn = DateTime.Now;
            this.UpdatedOn = DateTime.Now;
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Image Image { get; set; }
        public int OccupationId { get; set; }
        public Occupation Occupation { get; set; }
        public bool IsConfirmed { get; set; } = false;
        public ICollection<Post> UserPosts { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
    }
}
