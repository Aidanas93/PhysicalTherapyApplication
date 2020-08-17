using Microsoft.EntityFrameworkCore;
using PhysicalTherapyProject.Domain.Models;
using PhysicalTherapyProject.Persistance.Data;
using PhysicalTherapyProject.Persistance.Infrastructure.Interfaces;
using System.Linq;
using System.Threading.Tasks;

namespace PhysicalTherapyProject.Persistance.Repositories
{
    public class UserRepository : GenericRepository<ApplicationUser>, IUserRepository
    {
        public UserRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {

        }

        public async Task<ApplicationUser> GetByEmailAsync(string email)
           => await _applicationDbContext.Users
           .Include(post => post.UserPosts)
           .Include(occ => occ.Occupation)
           .Where(p => p.Email == email)
           .FirstOrDefaultAsync();
    }
}
