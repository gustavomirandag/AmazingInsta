using AmazingInsta.App.Domain;
using AmazingInsta.Common.Domain.Repositories;
using AmazingInsta.Common.Domain.Services;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AmazingInsta.App.Infra.DataAccess.Repositories
{
    public class PostRepository : IPostRepository
    {
        private ISerializerService serializerService;
        private string token;

        public PostRepository(ISerializerService serializerService, string token)
        {
            this.serializerService = serializerService;
            this.token = token;
        }

        public Task CreateAsync(Post entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Post> ReadAll()
        {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Authorization", "bearer " + token);
            var result = httpClient.GetAsync("https://amazinginsta-postmicroservice-api-gustavo.azurewebsites.net/api/posts").Result;

            if (!result.IsSuccessStatusCode)
                return new List<Post>();

            var serializedPosts = result.Content.ReadAsStringAsync().Result;
            var posts = serializerService.Deserialize<IEnumerable<Post>>(serializedPosts);

            return posts;
        }

        public async Task<IEnumerable<Post>> ReadAllAsync()
        {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Authorization", "bearer " + token);
            var result = await httpClient.GetAsync("https://amazinginsta-postmicroservice-api-gustavo.azurewebsites.net/api/posts");

            if (!result.IsSuccessStatusCode)
                return new List<Post>();

            var serializedPosts = await result.Content.ReadAsStringAsync();
            var posts = serializerService.Deserialize<IEnumerable<Post>>(serializedPosts);

            return posts;
        }

        public Task<Post> ReadAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public void Update(Post entity)
        {
            throw new NotImplementedException();
        }
    }
}
