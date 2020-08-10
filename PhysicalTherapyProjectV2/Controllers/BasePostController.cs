using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PhysicalTherapyProjectV2.Infrastructure;
using PhysicalTherapyProjectV2.Models;
using PhysicalTherapyProjectV2.Models.ViewModel;
using PhysicalTherapyProjectV2.Services.Interfaces;
using ImageParserLibrary;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PhysicalTherapyProjectV2.Controllers
{
    public abstract class BasePostController : BaseCrudController<Post>
    {
        protected IPostService postService;
        private int postType;
        
        public BasePostController(IPostService _postService, IGenericService<Post> genericService, int _postType) : base(genericService)
        {
            postService = _postService;
            postType = _postType;
        }

        [HttpGet]
        public async override Task<ActionResult> Index() => View(await postService.GetAllByTypeAsync(postType));

        [HttpGet]
        public override ActionResult Create() => View( new PostViewModel { 
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

            foreach(var image in imageList)
            {
                viewModel.Post.Images.Add(new Image { Content = image });
            }

            if (viewModel.Post.Id == 0)
            {

                var created_ent = await genericService.InsertAsync(viewModel.Post);
                TempData["message"] = $"{created_ent} buvo sukurtas!";
            }
            else
            {
                var updated_ent = await genericService.UpdateAsync(viewModel.Post);
                TempData["message"] = $"{updated_ent} buvo redaguotas!";
            }

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public override async Task<IActionResult> Edit(int id) =>
            View(nameof(Create), new PostViewModel()
            {
                Post = await genericService.GetByIdAsync(id)
            });


    }
}
