using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AmazingInsta.App.Domain
{
    public class PostService : IPostService
    {
        private IPostRepository postRepository;

        public PostService(IPostRepository postRepository)
        {
            this.postRepository = postRepository;
        }

        public async Task AddPostAsync(Post post)
        {
            await postRepository.CreateAsync(post);
        }

        public async Task<IEnumerable<Post>> GetAllPostsAsync()
        {
            return await postRepository.ReadAllAsync();
        }
    }
}
