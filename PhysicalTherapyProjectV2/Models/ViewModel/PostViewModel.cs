using Microsoft.AspNetCore.Http;
using PhysicalTherapyProject.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhysicalTherapyProjectV2.Models.ViewModel
{
    public class PostViewModel
    {
        public Post Post { get; set; }
        public IFormFileCollection Files { get; set; }

    }
}
