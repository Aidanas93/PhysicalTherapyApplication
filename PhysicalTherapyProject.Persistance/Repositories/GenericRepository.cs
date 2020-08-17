using Microsoft.EntityFrameworkCore;
using PhysicalTherapyProject.Domain.Infrastructure.Interfaces;
using PhysicalTherapyProject.Persistance.Data;
using PhysicalTherapyProject.Persistance.Infrastructure.Interfaces;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace PhysicalTherapyProject.Persistance.Repositories
{
    public class GenericRepository<TEntity> : IGenericService<TEntity> where TEntity : class, IEntity
    {
        private readonly ApplicationDbContext _applicationDbContext;
        private DbSet<TEntity> entities;

        public GenericRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
            entities = _applicationDbContext.Set<TEntity>();
        }

        private IQueryable<TEntity> Query()
        {
            var query = entities.AsQueryable();
            foreach (var property in _applicationDbContext.Model.FindEntityType(typeof(TEntity)).GetNavigations())
            {
                query = query.Include(property.Name);
            }
            return query;
        }

        public async Task<TEntity> GetByIdAsync(int id) =>
            await Query().Where(p => p.Id == id)
            .FirstOrDefaultAsync();

        public async Task<ICollection<TEntity>> GetAllAsync() =>
            await Query().ToListAsync();

        public async Task<TEntity> InsertAsync(TEntity entry)
        {
            entities.Add(entry);
            await _applicationDbContext.SaveChangesAsync();
            return entry;
        }

        public async Task<TEntity> UpdateAsync(TEntity entry)
        {
            TEntity dbEntry = await GetByIdAsync(entry.Id);
            if (dbEntry != null)
            {
                _applicationDbContext.Entry(dbEntry).CurrentValues.SetValues(entry);
                await _applicationDbContext.SaveChangesAsync();
            }
            return entry;
        }
        public async Task<TEntity> DeleteAsync(int id)
        {
            TEntity dbEntry = await GetByIdAsync(id);
            if (dbEntry != null)
            {
                entities.Remove(dbEntry);
                await _applicationDbContext.SaveChangesAsync();
            }
            return dbEntry;
        }

    }
}
