using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using PhysicalTherapyProject.Application.Infrastructure.Enums;
using PhysicalTherapyProject.Domain.Models;
using PhysicalTherapyProject.Persistance.Infrastructure.Interfaces;

namespace PhysicalTherapyProjectV2.Controllers
{
    [Authorize]
    public class ArticleController : BasePostController
    {
        public ArticleController(IPostRepository _postRepository,
            SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager)
            : base(_postRepository, (int)PostTypes.Article, signInManager, userManager) { }

    }
}