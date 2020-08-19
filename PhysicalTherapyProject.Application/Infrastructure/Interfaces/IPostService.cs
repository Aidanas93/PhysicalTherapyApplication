using PhysicalTherapyProject.Application.Models.ViewModels;
using System.Threading.Tasks;

namespace PhysicalTherapyProject.Application.Infrastructure.Interfaces
{
    public interface IPostService
    {
        string ServiceMessage { get; }
        Task CreatePostAsync(PostViewModel viewmodel);
    }
}