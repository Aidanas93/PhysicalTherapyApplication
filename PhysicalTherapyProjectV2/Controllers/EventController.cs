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
    public class EventController : BasePostController
    {
        public EventController(IPostService _postService, IGenericService<Post> postGeneric) :
            base(_postService, postGeneric, (int)PostTypes.Event)
        { }
    }
}
