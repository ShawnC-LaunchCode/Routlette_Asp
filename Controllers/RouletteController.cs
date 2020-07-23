using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Roulette_Asp.Data;
using Roulette_Asp.Models;
using Roulette_Asp.ViewModels;

namespace Roulette_Asp.Controllers
{
    public class RouletteController : Controller
    {
        public IActionResult Index()
        {
            //get what user is logged in
            
            //get that users info
            return View(ViewBag.user); //pass that user to the view
        }

        
    }
}
