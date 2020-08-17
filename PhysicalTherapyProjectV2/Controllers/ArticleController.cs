using Microsoft.AspNetCore.Authorization;
using PhysicalTherapyProject.Persistance.Infrastructure.Interfaces;
using PhysicalTherapyProjectV2.Infrastructure;

namespace PhysicalTherapyProjectV2.Controllers
{
    [Authorize]
    public class ArticleController : BasePostController
    {
        public ArticleController(IPostRepository _postRepository) : base(_postRepository, (int)PostTypes.Article) { }

    }
}