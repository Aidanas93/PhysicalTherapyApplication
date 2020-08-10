using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhysicalTherapyProjectV2.Models.Interfaces
{
    public interface IEntity
    {
        int Id { get; set; }

        DateTime CreatedOn { get; set; }

        DateTime UpdatedOn { get; set; }

        string CreatedBy { get; set; }

        string UpdatedBy { get; set; }

    }
}
