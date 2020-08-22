using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AmazingInsta.App.Application;
using AmazingInsta.App.Application.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AmazingInsta.App.UI.WebApp.Controllers
{
    public class SignInController : Controller
    {
        private readonly IAppService appService;

        public SignInController(IAppService appService)
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
        public ActionResult SignIn(SignInViewModel signInViewModel)
        {
            var token = appService.SignIn(signInViewModel.Username, signInViewModel.Password);
            HttpContext.Session.SetString("Token", token);
            return RedirectToAction("Index", "Posts");
        }

        // GET: SignInController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SignInController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SignInController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SignInController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
