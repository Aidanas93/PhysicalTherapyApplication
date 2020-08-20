using Microsoft.AspNetCore.Identity;
using PhysicalTherapyProject.Application.Infrastructure.Enums;
using PhysicalTherapyProject.Domain.Models;
using PhysicalTherapyProject.Persistance.Infrastructure.Interfaces;

namespace PhysicalTherapyProjectV2.Controllers
{
    public class AdvertismentController : BasePostController
    {
        public AdvertismentController(IPostRepository _postRepository,
             SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager)
            : base(_postRepository, (int)PostTypes.Advertisment, signInManager, userManager) { }


    }
}