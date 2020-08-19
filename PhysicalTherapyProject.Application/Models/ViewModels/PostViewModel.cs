using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using PhysicalTherapyProject.Domain.Models;
using System.Collections.Generic;

namespace PhysicalTherapyProject.Application.Models.ViewModels
{
    public class PostViewModel
    {
        public Post Post { get; set; }
        public int[] TagsId { get; set; }
        public IList<SelectListItem> Tags { get; set; }
        public IFormFileCollection Files { get; set; }
        public string CurrentView { get; set; }
    }
}
