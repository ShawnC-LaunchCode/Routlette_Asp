﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Routlette_Asp.Controllers
{
    public class AddUser : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}