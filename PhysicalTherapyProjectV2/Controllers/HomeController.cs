using Microsoft.AspNetCore.Mvc;
using PhysicalTherapyProject.Persistance.Infrastructure.Interfaces;
using PhysicalTherapyProjectV2.Infrastructure;
using System.Threading.Tasks;

namespace PhysicalTherapyProjectV2.Controllers
{
    public class HomeController : Controller
    {
        private IPostRepository _postRepository;

        public HomeController(IPostRepository postRepository)
        {
            this._postRepository = postRepository;
        }

        public async Task<IActionResult> Index() => View(await _postRepository.GetAllByTypeAsync((int)PostTypes.Article));

        public IActionResult Privacy() => View();

        public IActionResult AboutUs() => View();

        public IActionResult Partnership() => View();

    }
}
