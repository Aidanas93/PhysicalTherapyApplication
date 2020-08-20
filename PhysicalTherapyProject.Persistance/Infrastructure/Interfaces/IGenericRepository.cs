using System.Collections.Generic;
using System.Threading.Tasks;

namespace PhysicalTherapyProject.Persistance.Infrastructure.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        Task<ICollection<T>> GetAllAsync();
        Task<T> AddAsync(T item);
        Task<T> UpdateAsync(T item);
        Task<T> DeleteAsync(int id);
    }
}
