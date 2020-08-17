using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PhysicalTherapyProject.Persistance.Infrastructure.Interfaces
{
    public interface IGenericService<T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        Task<ICollection<T>> GetAllAsync();
        Task<T> InsertAsync(T item);
        Task<T> UpdateAsync(T item);
        Task<T> DeleteAsync(int id);
    }
}
