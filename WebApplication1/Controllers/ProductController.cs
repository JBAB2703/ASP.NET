﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            //return this.Content("Hello <b>World<b>!");
            return View();
        }
    }
}