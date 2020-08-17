using PhysicalTherapyProject.Persistance.Infrastructure.Interfaces;
using PhysicalTherapyProjectV2.Infrastructure;

namespace PhysicalTherapyProjectV2.Controllers
{
    public class EventController : BasePostController
    {
        public EventController(IPostRepository _postRepository) : base(_postRepository, (int)PostTypes.Event)
        { }
    }
}
