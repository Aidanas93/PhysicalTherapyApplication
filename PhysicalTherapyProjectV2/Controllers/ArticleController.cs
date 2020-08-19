using Microsoft.AspNetCore.Authorization;
using PhysicalTherapyProject.Application.Infrastructure.Enums;
using PhysicalTherapyProject.Persistance.Infrastructure.Interfaces;

namespace PhysicalTherapyProjectV2.Controllers
{
    [Authorize]
    public class ArticleController : BasePostController
    {
        public ArticleController(IPostRepository _postRepository) : base(_postRepository, (int)PostTypes.Article) { }

    }
}