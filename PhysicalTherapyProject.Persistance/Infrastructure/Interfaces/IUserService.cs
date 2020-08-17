using PhysicalTherapyProject.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PhysicalTherapyProject.Persistance.Infrastructure.Interfaces
{
    public interface IUserService
    {
        Task<ApplicationUser> GetByEmailAsync(string email);
    }
}
