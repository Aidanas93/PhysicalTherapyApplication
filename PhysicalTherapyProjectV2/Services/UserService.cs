using Microsoft.EntityFrameworkCore;
using PhysicalTherapyProject.Domain.Models;
using PhysicalTherapyProject.Persistance.Data;
using PhysicalTherapyProjectV2.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhysicalTherapyProjectV2.Services
{
    public class UserService : IGenericService<ApplicationUser>, IUserService<ApplicationUser>
    {
        private ApplicationDbContext applicationDbContext;
        public UserService(ApplicationDbContext _applicationDbContext)
        {
            applicationDbContext = _applicationDbContext;
        }

        public async Task<ICollection<ApplicationUser>> GetAllAsync()
            => await applicationDbContext.Users
            .Include(post => post.UserPosts)
            .Include(occ => occ.Occupation)
            .Where(x => x.Id > 0)
            .ToListAsync();


        public async Task<ApplicationUser> GetByEmailAsync(string email)
            => await applicationDbContext.Users
            .Include(post => post.UserPosts)
            .Include(occ => occ.Occupation)
            .Where(p => p.Email == email)
            .FirstOrDefaultAsync();

        public async Task<ApplicationUser> InsertAsync(ApplicationUser user)
        {
            applicationDbContext.Users.Add(user);
            await applicationDbContext.SaveChangesAsync();
            return user;
        }

        public async Task<ApplicationUser> UpdateAsync(ApplicationUser user)
        {
            ApplicationUser dbEntry = await GetUser(user.Id);
            if (dbEntry != null)
            {
                applicationDbContext.Entry(dbEntry).CurrentValues.SetValues(user);
                await applicationDbContext.SaveChangesAsync();
            }
            return user;
        }
        public async Task<ApplicationUser> DeleteAsync(int id)
        {
            ApplicationUser dbEntry = await GetUser(id);
            if (dbEntry != null)
            {
                applicationDbContext.Users.Remove(dbEntry);
                await applicationDbContext.SaveChangesAsync();
            }
            return dbEntry;
        }

        private async Task<ApplicationUser> GetUser(int id) => await applicationDbContext.Users.FindAsync(id);

        public async Task<ApplicationUser> GetByIdAsync(int id)
            => await applicationDbContext.Users
            .Include(post => post.UserPosts)
            .Where(p => p.Id == id)
            .FirstOrDefaultAsync();
    }
}
