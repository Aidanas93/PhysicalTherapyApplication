using PhysicalTherapyProjectV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhysicalTherapyProjectV2.Services.Interfaces
{
    public interface IPostService
    {
        Task<ICollection<Post>> GetAllByTypeAsync(int id);
    }
}
