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
            .Where(post => post.PostType.Id == id)
            .OrderByDescending(post => post.CreatedOn)
            .ToListAsync();

        public override async Task<Post> UpdateAsync(Post entry)
        {
            Post dbEntry = await GetByIdAsync(entry.Id);
            if (dbEntry != null)
            {
                UpdatePostImages(entry);
                UpdatePostTags(entry);
                _applicationDbContext.Entry(dbEntry).CurrentValues.SetValues(entry);
                await _applicationDbContext.SaveChangesAsync();
            }
            return entry;
        }

        private void UpdatePostImages(Post entry)
        {
            if (entry.Images.Count > 0)
            {
                var oldImages = _applicationDbContext.Images.Where(img => img.PostId == entry.Id).ToList();
                _applicationDbContext.Images.RemoveRange(oldImages);
                foreach (var image in entry.Images)
                {
                    image.PostId = entry.Id;
                    _applicationDbContext.Images.Add(image);
                }
            }
        }
        private void UpdatePostTags(Post entry)
        {
            if (entry.PostTags.Count > 0)
            {
                var oldPostTags = _applicationDbContext.PostTags.Where(pt => pt.PostId == entry.Id).ToList();
                _applicationDbContext.PostTags.RemoveRange(oldPostTags);
                foreach (var postTag in entry.PostTags)
                {
                    _applicationDbContext.PostTags.Add(postTag);
                }
            }
        }
    }
}
