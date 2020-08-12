using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PhysicalTherapyProjectV2.Infrastructure;
using PhysicalTherapyProjectV2.Models;
using PhysicalTherapyProjectV2.Services.Interfaces;

namespace PhysicalTherapyProjectV2.Controllers
{
    public class ImageController : Controller
    {
        private readonly IGenericService<Image> imageService;
        public ImageController(IGenericService<Image> _imageService)
        {
            imageService = _imageService;
        }

        public async Task<IActionResult> Render(int id)
        {
            var image = await imageService.GetByIdAsync(id);

            if(image == null)
            {
                return NotFound();
            }

            return File(image.Content, "image/png");
     
        }

    }
}