﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Routlette_Asp.Models;
using Routlette_Asp.ViewModels;

namespace Routlette_Asp.Controllers
{
    

    public class HomeController : Controller
    {
        private List<User> users = new List<User>();
        
        
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            users.Add(new User("Shawn", "1234"));

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

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(User newUser, string repeatPassword)
        {                
            users.Add(newUser);
            return Redirect("/Home/Index");
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel loginViewModel)
        {

            if (loginViewModel.Username == "Shawn" )
            {


                return Redirect("/roulette/index");
            }
            else return Redirect("/");
        }


    }
}
