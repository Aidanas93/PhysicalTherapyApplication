using PhysicalTherapyProject.Domain.Models;
using PhysicalTherapyProject.Persistance.Data;
using PhysicalTherapyProjectV2.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PhysicalTherapyProjectV2.Services
{
    public class ImageService : IGenericService<Image>
    {
        private readonly ApplicationDbContext context;

        public ImageService(ApplicationDbContext _context)
        {
            context = _context;
        }

        public Task<ICollection<Image>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Image> GetByIdAsync(int id) => await context.Images.FindAsync(id);


        public Task<Image> InsertAsync(Image item)
        {
            throw new NotImplementedException();
        }

        public Task<Image> UpdateAsync(Image item)
        {
            throw new NotImplementedException();
        }

        public Task<Image> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }




    }
}
