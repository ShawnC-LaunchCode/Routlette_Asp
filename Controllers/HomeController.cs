using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Routlette_Asp.Models;
using Routlette_Asp.ViewModels;
using Routlette_Asp.Data;

namespace Routlette_Asp.Controllers
{
    

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            User temp = new User("Shawn", "1234");
            UserData.Add(temp);
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel loginViewModel)
        {
            if (UserData.UserAuth(loginViewModel.Username, loginViewModel.Password))
            {


                return View("/Roulette");
                //return Redirect("/Roulette");
            }
            else return Redirect("/Home");
        }


    }
}
