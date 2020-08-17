using Microsoft.AspNetCore.Mvc;
using PhysicalTherapyProject.Domain.Models;
using PhysicalTherapyProject.Persistance.Infrastructure.Interfaces;
using System.Threading.Tasks;

namespace PhysicalTherapyProjectV2.Controllers
{
    public class ImageController : Controller
    {
        private readonly IGenericRepository<Image> _imageRepository;
        public ImageController(IGenericRepository<Image> imageRepository)
        {
            _imageRepository = imageRepository;
        }

        public async Task<IActionResult> Render(int id)
        {
            var image = await _imageRepository.GetByIdAsync(id);

            if (image == null)
            {
                return NotFound();
            }

            return File(image.Content, "image/png");

        }

    }
}