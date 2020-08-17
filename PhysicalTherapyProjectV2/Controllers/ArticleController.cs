using Microsoft.AspNetCore.Authorization;
using PhysicalTherapyProject.Domain.Models;
using PhysicalTherapyProjectV2.Infrastructure;
using PhysicalTherapyProjectV2.Services.Interfaces;

namespace PhysicalTherapyProjectV2.Controllers
{
    [Authorize]
    public class ArticleController : BasePostController
    {
        public ArticleController(IPostService _postService, IGenericService<Post> postGeneric) : base(_postService, postGeneric, (int)PostTypes.Article) { }

    }
}