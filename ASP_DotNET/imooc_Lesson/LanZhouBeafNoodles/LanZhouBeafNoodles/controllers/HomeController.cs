﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LanZhouBeafNoodles.controllers
{
    //[Route("[controller]/[action]")]
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public string Index()
        {
            return "hello form home";
        }
        
        public string About()
        {
            return "Hello from About";
        }
    }
}
