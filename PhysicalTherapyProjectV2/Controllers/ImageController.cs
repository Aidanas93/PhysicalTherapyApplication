using Microsoft.AspNetCore.Mvc;
using PhysicalTherapyProject.Domain.Models;
using PhysicalTherapyProjectV2.Services.Interfaces;
using System.Threading.Tasks;

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

            if (image == null)
            {
                return NotFound();
            }

            return File(image.Content, "image/png");

        }

    }
}