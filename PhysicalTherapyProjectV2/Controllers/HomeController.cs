using Microsoft.AspNetCore.Mvc;
using PhysicalTherapyProject.Application.Infrastructure.Enums;
using PhysicalTherapyProject.Persistance.Infrastructure.Interfaces;
using System.Threading.Tasks;

namespace PhysicalTherapyProjectV2.Controllers
{
    public class HomeController : Controller
    {
        private IPostRepository _postRepository;

        public HomeController(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public async Task<IActionResult> Index() => View(await _postRepository.GetAllByTypeAsync((int)PostTypes.Article));

        public IActionResult Privacy() => View();

        public async Task<IActionResult> AboutUs() => View(await _postRepository.GetAllByTypeAsync((int)PostTypes.TeamMember));

        public IActionResult Partnership() => View();

    }
}
