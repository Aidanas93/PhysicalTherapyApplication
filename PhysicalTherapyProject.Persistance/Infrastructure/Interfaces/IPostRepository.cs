using PhysicalTherapyProject.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PhysicalTherapyProject.Persistance.Infrastructure.Interfaces
{
    public interface IPostRepository : IGenericRepository<Post>
    {
        Task<ICollection<Post>> GetAllByTypeAsync(int id);
    }
}
