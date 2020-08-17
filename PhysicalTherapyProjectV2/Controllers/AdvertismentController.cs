using PhysicalTherapyProject.Domain.Models;
using PhysicalTherapyProject.Persistance.Infrastructure.Interfaces;
using PhysicalTherapyProjectV2.Infrastructure;

namespace PhysicalTherapyProjectV2.Controllers
{
    public class AdvertismentController : BasePostController
    {
        public AdvertismentController(IPostRepository _postRepository) : base(_postRepository, (int)PostTypes.Advertisment) { }


    }
}