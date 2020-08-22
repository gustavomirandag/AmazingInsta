using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AmazingInsta.App.Application;
using AmazingInsta.App.Application.Models.Dtos;
using AmazingInsta.App.Application.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AmazingInsta.App.UI.WebApp.Controllers
{
    public class SignUpController : Controller
    {
        private readonly IAppService appService;

        public SignUpController(IAppService appService)
        {
            this.appService = appService;
        }



        // GET: SignInController
        public ActionResult Index()
        {
            return View();
        }

        // POST: SignInController/SignIn
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignIn(SignUpViewModel signUpViewModel)
        {
            appService.SignUp(signUpViewModel);
            return RedirectToAction("Index", "SignIn");
        }
    }
}
