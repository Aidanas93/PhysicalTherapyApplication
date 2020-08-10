using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhysicalTherapyProjectV2.Services.Interfaces
{
    public interface IUserService<T> where T : class
    {
        Task<T> GetByEmailAsync(string email);
    }
}
