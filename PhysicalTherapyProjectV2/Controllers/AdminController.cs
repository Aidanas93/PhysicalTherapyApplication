using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PhysicalTherapyProjectV2.Infrastructure;
using PhysicalTherapyProjectV2.Models;
using PhysicalTherapyProjectV2.Models.ViewModel;
using PhysicalTherapyProjectV2.Services.Interfaces;

namespace PhysicalTherapyProjectV2.Controllers
{
    //[Authorize(Roles = "Administrator")]
    public class AdminController : Controller
    {
        private readonly IPostService _postService;
        private readonly IGenericService<Post> _genericService;
        private readonly IGenericService<ApplicationUser> _userService;

        public AdminController(IPostService postService, IGenericService<Post> genericService, IGenericService<ApplicationUser> userService)
        {
            _postService = postService;
            _genericService = genericService;
            _userService = userService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _userService.GetAllAsync());
        }

        [HttpGet]
        public async Task<IActionResult> ListEvent()
            => View(await _postService.GetAllByTypeAsync((int)PostTypes.Event));

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

                var created_ent = await _genericService.InsertAsync(viewmodel.Post);
                TempData["message"] = $"Renginys: '{created_ent}' buvo sukurtas!";
            }
            else
            {
                var updated_ent = await _genericService.UpdateAsync(viewmodel.Post);
                TempData["message"] = $"Renginys: '{updated_ent}' buvo redaguotas!";
            }

            return RedirectToAction(nameof(ListEvent));
        }

        [HttpGet]
        public async Task<IActionResult> EditEvent(int id) =>
            View(nameof(CreateEvent), new PostViewModel()
            {
                Post = await _genericService.GetByIdAsync(id)
            });


        [HttpPost]
        public async Task<IActionResult> DeleteEvent(int id)
        {
            var article = await _genericService.GetByIdAsync(id);
            await _genericService.DeleteAsync(id);
            TempData["message"] = $"Renginys '{article.Title}' buvo ištrintas!";
            return RedirectToAction(nameof(ListEvent));
        }

        public async Task<IActionResult> ListArticle() =>
            View(await _postService.GetAllByTypeAsync((int)PostTypes.Article));

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

                var created_ent = await _genericService.InsertAsync(viewmodel.Post);
                TempData["message"] = $"Straipsnis: '{created_ent}' buvo sukurtas!";
            }
            else
            {
                var updated_ent = await _genericService.UpdateAsync(viewmodel.Post);
                TempData["message"] = $"Straipsnis: '{updated_ent}' buvo redaguotas!";
            }

            return RedirectToAction(nameof(ListArticle));
        }

        [HttpGet]
        public async Task<IActionResult> EditArticle(int id) =>
        View(nameof(CreateArticle), new PostViewModel()
        {
            Post = await _genericService.GetByIdAsync(id)
        });


        [HttpPost]
        public async Task<IActionResult> DeleteArticle(int id)
        {
            var article = await _genericService.GetByIdAsync(id);
            await _genericService.DeleteAsync(id);
            TempData["message"] = $"Straipsnis '{article.Title}' buvo ištrintas!";
            return RedirectToAction(nameof(ListArticle));
        }

        [HttpPost]
        public async Task<IActionResult> ConfirmUser(int userId)
        {
            var user = await _userService.GetByIdAsync(userId);
            user.IsConfirmed = true;
            await _userService.UpdateAsync(user);
            TempData["message"] = $"{user.Name} {user.Surname} buvo patvirtintas!";
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> DeleteUser(int userId)
        {
            var user = await _userService.GetByIdAsync(userId);
            await _userService.DeleteAsync(userId);
            TempData["message"] = $"{user.Name} {user.Surname} buvo ištrintas!";
            return RedirectToAction(nameof(Index));
        }

    }
}
