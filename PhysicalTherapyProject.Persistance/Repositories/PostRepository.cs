using Microsoft.EntityFrameworkCore;
using PhysicalTherapyProject.Domain.Models;
using PhysicalTherapyProject.Persistance.Data;
using PhysicalTherapyProject.Persistance.Infrastructure.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhysicalTherapyProject.Persistance.Repositories
{
    public class PostRepository : GenericRepository<Post>, IPostRepository
    {
        public PostRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {

        }

        public async Task<ICollection<Post>> GetAllByTypeAsync(int id)
            => await _applicationDbContext.Posts
            .Include(post => post.PostType)
            .Include(post => post.PostUser)
            .Include(post => post.Images)
            .Where(type => type.PostType.Id == id)
            .ToListAsync();
    }
}
