using AmazingInsta.App.Application.Models.ViewModels;
using AmazingInsta.App.Domain;
using AmazingInsta.Common.Domain.Services;
using IdentityModel.Client;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System;
using AmazingInsta.App.Infra.DataAccess.Repositories;

namespace AmazingInsta.App.Application
{
    public class AppService : IAppService
    {
        private ISerializerService serializeService;

        public AppService(ISerializerService serializeService)
        {
            this.serializeService = serializeService;
        }

        public async Task AddPostAsync(string token, Post postViewModel)
        {
            var postRepository = new PostRepository(serializeService, token);
            var postService = new PostService(postRepository);
            await postService.AddPostAsync(postViewModel);
        }

        public async Task<IEnumerable<Post>> GetAllPostsAsync(string token)
        {
            var postRepository = new PostRepository(serializeService, token);
            var postService = new PostService(postRepository);
            return await postService.GetAllPostsAsync();
        }

        public string SignIn(string username, string password)
        {
            return GetToken(username, password);
        }

        public bool SignUp()
        {
            throw new System.NotImplementedException();
        }

        private string GetToken(string username, string password)
        {
            var client = new HttpClient();
            var response = client.RequestPasswordTokenAsync(new PasswordTokenRequest
            {
                Address = "https://amazinginsta-gustavo-iammicroservice-identity.azurewebsites.net/connect/token",

                ClientId = "AmazingInstaWebApp_ClientId",

                UserName = username,
                Password = password
            }).Result;

            return response.AccessToken;
        }
    }
}
