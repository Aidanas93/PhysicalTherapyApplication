using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PhysicalTherapyProjectV2.Infrastructure;
using PhysicalTherapyProjectV2.Models;
using PhysicalTherapyProjectV2.Services.Interfaces;

namespace PhysicalTherapyProjectV2.Controllers
{
    public class HomeController : Controller
    {
        private IPostService genericService;

        public HomeController(IPostService genericService)
        {
            this.genericService = genericService;
        }

        public async Task<IActionResult> Index() => View(await genericService.GetAllByTypeAsync((int)PostTypes.Article));

        public IActionResult Privacy() => View();

        public IActionResult AboutUs() => View();

        public IActionResult Partnership() => View();

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
