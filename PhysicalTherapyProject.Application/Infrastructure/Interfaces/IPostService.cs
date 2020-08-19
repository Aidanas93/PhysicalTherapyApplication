using PhysicalTherapyProject.Application.Models.ViewModels;

namespace PhysicalTherapyProject.Application.Infrastructure.Interfaces
{
    public interface IPostService
    {
        void CreatePost(PostViewModel viewmodel);
    }
}