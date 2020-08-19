using PhysicalTherapyProject.Application.Infrastructure;
using PhysicalTherapyProject.Application.Infrastructure.Interfaces;
using PhysicalTherapyProject.Application.Models.ViewModels;
using PhysicalTherapyProject.Domain.Models;
using PhysicalTherapyProject.Persistance.Infrastructure.Interfaces;
using System.Collections.Generic;

namespace PhysicalTherapyProject.Application.Services
{
    public class PostService : IPostService
    {
        private readonly IPostRepository _postRepository;

        public PostService(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public void CreatePost(PostViewModel viewmodel)
        {
            ImageParser imageParser = new ImageParser();

            var imageList = imageParser.ConvertToBytes(viewmodel.Files);
            List<Image> images = new List<Image>();
            foreach (var image in imageList)
            {
                images.Add(new Image { Content = image });
            }
            viewmodel.Post.Images = images;
        }
    }
}
