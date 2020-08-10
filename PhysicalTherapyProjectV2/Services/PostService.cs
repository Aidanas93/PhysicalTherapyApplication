using Microsoft.EntityFrameworkCore;
using PhysicalTherapyProjectV2.Data;
using PhysicalTherapyProjectV2.Models;
using PhysicalTherapyProjectV2.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhysicalTherapyProjectV2.Services
{
    public class PostService : IPostService, IGenericService<Post>
    {
        private ApplicationDbContext applicationDbContext;
        public PostService(ApplicationDbContext _applicationDbContext)
        {
            applicationDbContext = _applicationDbContext;
        }

        public async Task<Post> GetByIdAsync(int id)
            => await applicationDbContext.Posts
            .Include(post => post.PostType)
            .Include(post => post.PostUser)
            .Include(post => post.Images)
            .Where(p => p.Id == id)
            .FirstOrDefaultAsync();

        public async Task<ICollection<Post>> GetAllAsync()
             => await applicationDbContext.Posts
             .Include(x => x.PostUser)
             .Include(x => x.PostType)
             .Include(post => post.Images)
             .Where(x => x.Id > 0)
             .ToListAsync();

        public async Task<ICollection<Post>> GetAllByTypeAsync(int id)
            => await applicationDbContext.Posts
            .Include(post => post.PostType)
            .Include(post => post.PostUser)
            .Include(post => post.Images)
            .Where(type => type.PostType.Id == id)
            .ToListAsync();

        public async Task<Post> InsertAsync(Post post)
        {
            applicationDbContext.Posts.Add(post);
            await applicationDbContext.SaveChangesAsync();
            return post;
        }


        public async Task<Post> UpdateAsync(Post post)
        {
            Post dbEntry = GetPost(post.Id);
            if (dbEntry != null)
            {
                post.UpdatedOn = DateTime.Now;
                //dbEntry.Title = post.Title;
                //dbEntry.Body = post.Body;
                applicationDbContext.Entry(dbEntry).CurrentValues.SetValues(post);
            }
            await applicationDbContext.SaveChangesAsync();
            return dbEntry;
        }

        public async Task<Post> DeleteAsync(int id)
        {
            Post dbEntry = GetPost(id);
            if (dbEntry != null)
            {
                applicationDbContext.Posts.Remove(dbEntry);
                await applicationDbContext.SaveChangesAsync();
            }
            return dbEntry;
        }

        private Post GetPost(int id) => applicationDbContext.Posts.FirstOrDefault(x => x.Id == id);




    }
}
