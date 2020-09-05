using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AmazingInsta.Microservices.PostMicroservice.Domain.AggregatesModel.PostAggregate
{
    public class PostService : IPostService
    {
        private IPostRepository postRepository;

        public PostService(IPostRepository postRepository)
        {
            this.postRepository = postRepository;
        }

        public Post CreatePost(Guid profileId, string message, string photoUrl)
        {
            var post = new Post
            {
                Id = Guid.NewGuid(),
                PublishDateTime = DateTime.Now,
                Message = message,
                PhotoUrl = photoUrl,
                ProfileId = profileId
            };

            return post;
        }

        public async Task<bool> ProcessPostAsync(Post post)
        {
            //Verify if Post has not allowed content.
            //return false if it contains not allowed content.

            await postRepository.CreateAsync(post);
            return await postRepository.SaveChangesAsync() > 0;
        }
    }
}
