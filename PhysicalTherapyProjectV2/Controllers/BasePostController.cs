using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PhysicalTherapyProject.Application.Infrastructure;
using PhysicalTherapyProject.Application.Models.ViewModels;
using PhysicalTherapyProject.Domain.Models;
using PhysicalTherapyProject.Persistance.Infrastructure.Interfaces;
using System.Linq;
using System.Threading.Tasks;

namespace PhysicalTherapyProjectV2.Controllers
{

    public abstract class BasePostController : Controller
    {
        protected IPostRepository _postRepository;
        private int postType;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public BasePostController(IPostRepository postRepository, int _postType,
            SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager)
        {
            _postRepository = postRepository;
            postType = _postType;
            _signInManager = signInManager;
            _userManager = userManager;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult> Get(int id)
        {
            Post post = await _postRepository.GetByIdAsync(id);

            bool x = HttpContext.User.Identity.IsAuthenticated;
            if (x || post.isForAuthenticatedUser == false)
            {
                return View(post);
            }
            return Unauthorized();
        }


        [HttpGet]
        public async Task<ActionResult> Index()
        {
            var posts = await _postRepository.GetAllByTypeAsync(postType);
            posts = posts.OrderByDescending(x => x.CreatedOn).ToList();
            return View(posts);
        }

        [HttpGet]
        public ActionResult Create() => View(new PostViewModel
        {
            Post = new Post()
        });

        [HttpPost]
        [ActionName("CreateViewModel")]
        public async Task<ActionResult> Create(PostViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            ImageParser imageParser = new ImageParser();
            var imageList = imageParser.ConvertToBytes(viewModel.Files);

            foreach (var image in imageList)
            {
                viewModel.Post.Images.Add(new Image { Content = image });
            }

            if (viewModel.Post.Id == 0)
            {

                var created_ent = await _postRepository.AddAsync(viewModel.Post);
                TempData["message"] = $"{created_ent} buvo sukurtas!";
            }
            else
            {
                var updated_ent = await _postRepository.UpdateAsync(viewModel.Post);
                TempData["message"] = $"{updated_ent} buvo redaguotas!";
            }

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id) =>
            View(nameof(Create), new PostViewModel()
            {
                Post = await _postRepository.GetByIdAsync(id)
            });



        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var entity = await _postRepository.DeleteAsync(id);

            if (entity != null)
            {
                TempData["message"] = $"{entity} buvo ištrintas!";
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
