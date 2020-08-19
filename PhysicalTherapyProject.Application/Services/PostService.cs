using PhysicalTherapyProject.Application.Infrastructure;
using PhysicalTherapyProject.Application.Infrastructure.Interfaces;
using PhysicalTherapyProject.Application.Models.ViewModels;
using PhysicalTherapyProject.Domain.Models;
using PhysicalTherapyProject.Persistance.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PhysicalTherapyProject.Application.Services
{
    public class PostService : IPostService
    {
        private readonly IPostRepository _postRepository;
        private readonly IGenericRepository<Tag> _tagRepository;
        public string ServiceMessage { get; private set; }
        public PostService(IPostRepository postRepository, IGenericRepository<Tag> tagRepository)
        {
            _postRepository = postRepository;
            _tagRepository = tagRepository;
        }

        public async Task CreatePostAsync(PostViewModel viewmodel)
        {
            AddImagesToPost(viewmodel);
            await AddTagsToPostAsync(viewmodel);
            if (viewmodel.Post.Id == 0)
            {

                var created_ent = await _postRepository.InsertAsync(viewmodel.Post);
                ServiceMessage = $"Straipsnis: '{created_ent}' buvo sukurtas!";
            }
            else
            {
                var updated_ent = await _postRepository.UpdateAsync(viewmodel.Post);
                ServiceMessage = $"Straipsnis: '{updated_ent}' buvo redaguotas!";
            }
        }

        private static void AddImagesToPost(PostViewModel viewmodel)
        {
            if (viewmodel.Files == null)
                return;

            ImageParser imageParser = new ImageParser();
            var imageList = imageParser.ConvertToBytes(viewmodel.Files);
            List<Image> images = new List<Image>();
            foreach (var image in imageList)
            {
                images.Add(new Image { Content = image });
            }
            viewmodel.Post.Images = images;
        }

        private async Task AddTagsToPostAsync(PostViewModel viewmodel)
        {
            if (viewmodel.TagsId != null)
            {
                var tags = await GetTagsAsync(viewmodel.TagsId);

                foreach (var tag in tags)
                {
                    PostTag postTag = new PostTag()
                    {
                        TagId = tag.Id,
                        PostId = viewmodel.Post.Id,
                        Tag = tag,
                        Post = viewmodel.Post
                    };
                    viewmodel.Post.PostTags.Add(postTag);
                }
            }
        }

        private async Task<List<Tag>> GetTagsAsync(int[] tagsId)
        {
            List<Tag> tags = new List<Tag>();
            foreach (var tagId in tagsId)
            {
                tags.Add(await _tagRepository.GetByIdAsync(tagId));
            }

            return tags;
        }
    }
}
