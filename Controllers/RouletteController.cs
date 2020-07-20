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
    public class RouletteController : Controller
    {
        public IActionResult Index()
        {
            //get what user is logged in

            //get that users info
            return View(); //pass that user to the view
        }

        
    }
}
