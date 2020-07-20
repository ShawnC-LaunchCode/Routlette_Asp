using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Routlette_Asp.Data;
using Routlette_Asp.Models;
using Routlette_Asp.ViewModels;


namespace Routlette_Asp.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            List<User> users = new List<User>(UserData.GetAll());

            return View(users);
        }

       
        public IActionResult Add()
        {
            AddUserViewModel addUserViewModel = new AddUserViewModel();
            return View(addUserViewModel);
        }


        [HttpPost]
        public IActionResult Add(AddUserViewModel addUserViewModel)
        {
            if (ModelState.IsValid)
            {
                User newUser = new User
                {
                    Username = addUserViewModel.Username,
                    Password = addUserViewModel.Password
                };

                UserData.Add(newUser);

               

                return Redirect("/Roulette");
            }
                return View(addUserViewModel);
        }
    }
}
