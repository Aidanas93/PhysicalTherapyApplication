using PhysicalTherapyProject.Application.Infrastructure.Enums;
using PhysicalTherapyProject.Persistance.Infrastructure.Interfaces;

namespace PhysicalTherapyProjectV2.Controllers
{
    public class EventController : BasePostController
    {
        public EventController(IPostRepository _postRepository) : base(_postRepository, (int)PostTypes.Event)
        { }
    }
}
