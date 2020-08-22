using AmazingInsta.App.Application.Models.Dtos;
using AmazingInsta.App.Application.Models.ViewModels;
using AmazingInsta.App.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AmazingInsta.App.Application
{
    public interface IAppService
    {
        string SignIn(string username, string password);
        bool SignUp(SignUpViewModel signUpViewModel);
        Task AddPostAsync(string token, Post postViewModel);
        Task<IEnumerable<Post>> GetAllPostsAsync(string token);
    }
}
