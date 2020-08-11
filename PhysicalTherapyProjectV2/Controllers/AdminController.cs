using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PhysicalTherapyProjectV2.Infrastructure;
using PhysicalTherapyProjectV2.Services.Interfaces;

namespace PhysicalTherapyProjectV2.Controllers
{
    //[Authorize(Roles = "Administrator")]
    public class AdminController : Controller
    {
        private IPostService genericService;

        public AdminController(IPostService genericService)
        {
            this.genericService = genericService;
        }

        public IActionResult Index() => View();

        public async Task<IActionResult> ListArticleAsync() =>
            View(await genericService.GetAllByTypeAsync((int)PostTypes.Article));

        public IActionResult CreateArticle() => View();

        //[HttpPost]
        //public IActionResult ListArticle()
        //{

        //    return View();
        //}
    }
}
