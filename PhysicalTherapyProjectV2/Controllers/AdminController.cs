using Microsoft.AspNetCore.Mvc;
using PhysicalTherapyProject.Domain.Models;
using PhysicalTherapyProject.Persistance.Infrastructure.Interfaces;
using PhysicalTherapyProjectV2.Infrastructure;
using PhysicalTherapyProjectV2.Models.ViewModel;
using System;
using System.Threading.Tasks;

namespace PhysicalTherapyProjectV2.Controllers
{
    //[Authorize(Roles = "Administrator")]
    public class AdminController : Controller
    {
        private readonly IPostRepository _postRepository;
        private readonly IUserRepository _userRepository;

        public AdminController(IPostRepository postRepository, IUserRepository userRepository)
        {
            _postRepository = postRepository;
            _userRepository = userRepository;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _userRepository.GetAllAsync());
        }

        [HttpGet]
        public async Task<IActionResult> ListEvent()
            => View(await _postRepository.GetAllByTypeAsync((int)PostTypes.Event));

        [HttpGet]
        public IActionResult CreateEvent() => View(new PostViewModel
        {
            Post = new Post() { PostTypeId = 2 }
        });

        [HttpPost]
        public async Task<IActionResult> CreateEvent(PostViewModel viewmodel)
        {
            if (!ModelState.IsValid)
            {
                return View(ModelState);
            }

            if (viewmodel.Files != null)
            {
                ImageParser imageParser = new ImageParser();
                var imageList = imageParser.ConvertToBytes(viewmodel.Files);

                foreach (var image in imageList)
                {
                    viewmodel.Post.Images.Add(new Image { Content = image });
                }
            }

            if (viewmodel.Post.Id == 0)
            {

                var created_ent = await _postRepository.InsertAsync(viewmodel.Post);
                TempData["message"] = $"Renginys: '{created_ent}' buvo sukurtas!";
            }
            else
            {
                var updated_ent = await _postRepository.UpdateAsync(viewmodel.Post);
                TempData["message"] = $"Renginys: '{updated_ent}' buvo redaguotas!";
            }

            return RedirectToAction(nameof(ListEvent));
        }

        [HttpGet]
        public async Task<IActionResult> EditEvent(int id) =>
            View(nameof(CreateEvent), new PostViewModel()
            {
                Post = await _postRepository.GetByIdAsync(id)
            });


        [HttpPost]
        public async Task<IActionResult> DeleteEvent(int id)
        {
            var article = await _postRepository.GetByIdAsync(id);
            await _postRepository.DeleteAsync(id);
            TempData["message"] = $"Renginys '{article.Title}' buvo ištrintas!";
            return RedirectToAction(nameof(ListEvent));
        }

        public async Task<IActionResult> ListArticle() =>
            View(await _postRepository.GetAllByTypeAsync((int)PostTypes.Article));

        public IActionResult CreateArticle() => View(new PostViewModel
        {
            Post = new Post() { PostTypeId = 1 }
        });

        [HttpPost]
        public async Task<IActionResult> CreateArticle(PostViewModel viewmodel)
        {
            if (!ModelState.IsValid)
            {
                return View(ModelState);
            }

            if (viewmodel.Files != null)
            {
                try
                {
                    ImageParser imageParser = new ImageParser();

                    var imageList = imageParser.ConvertToBytes(viewmodel.Files);
                    foreach (var image in imageList)
                    {
                        viewmodel.Post.Images.Add(new Image { Content = image });
                    }
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("File Error", ex.Message);
                    return View(ModelState);
                }

            }

            if (viewmodel.Post.Id == 0)
            {

                var created_ent = await _postRepository.InsertAsync(viewmodel.Post);
                TempData["message"] = $"Straipsnis: '{created_ent}' buvo sukurtas!";
            }
            else
            {
                var updated_ent = await _postRepository.UpdateAsync(viewmodel.Post);
                TempData["message"] = $"Straipsnis: '{updated_ent}' buvo redaguotas!";
            }

            return RedirectToAction(nameof(ListArticle));
        }

        [HttpGet]
        public async Task<IActionResult> EditArticle(int id) =>
        View(nameof(CreateArticle), new PostViewModel()
        {
            Post = await _postRepository.GetByIdAsync(id)
        });


        [HttpPost]
        public async Task<IActionResult> DeleteArticle(int id)
        {
            var article = await _postRepository.GetByIdAsync(id);
            await _postRepository.DeleteAsync(id);
            TempData["message"] = $"Straipsnis '{article.Title}' buvo ištrintas!";
            return RedirectToAction(nameof(ListArticle));
        }

        [HttpPost]
        public async Task<IActionResult> ConfirmUser(int userId)
        {
            var user = await _userRepository.GetByIdAsync(userId);
            user.IsConfirmed = true;
            await _userRepository.UpdateAsync(user);
            TempData["message"] = $"{user.Name} {user.Surname} buvo patvirtintas!";
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> DeleteUser(int userId)
        {
            var user = await _userRepository.GetByIdAsync(userId);
            await _userRepository.DeleteAsync(userId);
            TempData["message"] = $"{user.Name} {user.Surname} buvo ištrintas!";
            return RedirectToAction(nameof(Index));
        }

    }
}
