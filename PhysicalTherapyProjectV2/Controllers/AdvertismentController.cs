using PhysicalTherapyProject.Application.Infrastructure.Enums;
using PhysicalTherapyProject.Persistance.Infrastructure.Interfaces;

namespace PhysicalTherapyProjectV2.Controllers
{
    public class AdvertismentController : BasePostController
    {
        public AdvertismentController(IPostRepository _postRepository) : base(_postRepository, (int)PostTypes.Advertisment) { }


    }
}