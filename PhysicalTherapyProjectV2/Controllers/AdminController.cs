using Microsoft.AspNetCore.Mvc;
using PhysicalTherapyProject.Application.Infrastructure;
using PhysicalTherapyProject.Application.Infrastructure.Enums;
using PhysicalTherapyProject.Application.Infrastructure.Extensions;
using PhysicalTherapyProject.Application.Infrastructure.Interfaces;
using PhysicalTherapyProject.Application.Models.ViewModels;
using PhysicalTherapyProject.Domain.Models;
using PhysicalTherapyProject.Persistance.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PhysicalTherapyProjectV2.Controllers
{
    //[Authorize(Roles = "Administrator")]
    public class AdminController : Controller
    {
        private readonly IPostRepository _postRepository;
        private readonly IUserRepository _userRepository;
        private readonly IGenericRepository<Tag> _tagRepository;
        private readonly IPostService _postService;

        public AdminController(IPostRepository postRepository, IUserRepository userRepository,
            IGenericRepository<Tag> tagRepository, IPostService postService)
        {
            _postRepository = postRepository;
            _userRepository = userRepository;
            _tagRepository = tagRepository;
            _postService = postService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _userRepository.GetAllAsync());
        }

        #region EVENT
        [HttpGet]
        public async Task<IActionResult> ListEvent()
           => View(await _postRepository.GetAllByTypeAsync((int)PostTypes.Event));

        [HttpGet]
        public IActionResult CreateEvent() => View(new PostViewModel
        {
            Post = new Post() { PostTypeId = 2 }
        });

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
        #endregion

        #region TEAMMEMBER
        public IActionResult CreateTeamMember() => View(new PostViewModel
        {
            Post = new Post() { PostTypeId = (int)PostTypes.TeamMember }
        });

        public async Task<IActionResult> ListTeamMembers() =>
            View(await _postRepository.GetAllByTypeAsync((int)PostTypes.TeamMember));

        [HttpGet]
        public async Task<IActionResult> EditTeamMembers(int id) =>
        View(nameof(CreateTeamMember), new PostViewModel()
        {
            Post = await _postRepository.GetByIdAsync(id)
        });

        [HttpPost]
        public async Task<IActionResult> DeleteTeamMembers(int id)
        {
            var article = await _postRepository.GetByIdAsync(id);
            await _postRepository.DeleteAsync(id);
            TempData["message"] = $"Informacija apie komandos narį '{article.Title}' buvo ištrinta!";
            return RedirectToAction(nameof(ListTeamMembers));
        }
        #endregion

        #region ARTICLE
        public async Task<IActionResult> ListArticle() =>
            View(await _postRepository.GetAllByTypeAsync((int)PostTypes.Article));

        public async Task<IActionResult> CreateArticle()
        {
            var tags = await _tagRepository.GetAllAsync();
            return View(new PostViewModel
            {
                Post = new Post() { PostTypeId = (int)PostTypes.Article },
                Tags = tags.ConvertToSelectListItems()
            });
        }

        [HttpGet]
        public async Task<IActionResult> EditArticle(int id)
        {
            var tags = await _tagRepository.GetAllAsync();
            return View(nameof(CreateArticle), new PostViewModel()
            {
                Post = await _postRepository.GetByIdAsync(id),
                Tags = tags.ConvertToSelectListItems()
            });
        }

        [HttpPost]
        public async Task<IActionResult> DeleteArticle(int id)
        {
            var article = await _postRepository.GetByIdAsync(id);
            await _postRepository.DeleteAsync(id);
            TempData["message"] = $"Straipsnis '{article.Title}' buvo ištrintas!";
            return RedirectToAction(nameof(ListArticle));
        }
        #endregion

        #region USER
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
        #endregion

        [HttpPost]
        public async Task<IActionResult> CreatePost(PostViewModel viewmodel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewmodel.CurrentView, viewmodel);
            }

            try
            {
                await _postService.CreatePostAsync(viewmodel);
                TempData["message"] = _postService.ServiceMessage;
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("File Error", ex.Message);
                return View(viewmodel.CurrentView, viewmodel);
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
