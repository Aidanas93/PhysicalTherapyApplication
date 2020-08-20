using Microsoft.AspNetCore.Identity;
using PhysicalTherapyProject.Application.Infrastructure.Enums;
using PhysicalTherapyProject.Domain.Models;
using PhysicalTherapyProject.Persistance.Infrastructure.Interfaces;

namespace PhysicalTherapyProjectV2.Controllers
{
    public class EventController : BasePostController
    {
        public EventController(IPostRepository _postRepository,
            SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager)
            : base(_postRepository, (int)PostTypes.Event, signInManager, userManager)
        { }
    }
}
