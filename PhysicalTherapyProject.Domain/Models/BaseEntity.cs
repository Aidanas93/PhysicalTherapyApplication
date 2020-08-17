using PhysicalTherapyProject.Domain.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhysicalTherapyProject.Domain.Models
{
    public abstract class BaseEntity : IEntity
    {
        public BaseEntity()
        {
            this.CreatedOn = DateTime.Now;
            this.UpdatedOn = DateTime.Now;
        }
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
    }
}
