using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LanZhouBeafNoodles.controllers
{   [Route("admin/[controller]/[action]")]
    public class UserController : Controller
    {
        // GET: /<controller>/
        public IList<String> Index()
        {
            return new List<string> { "小明", "小莉", "小张", "小赵" };
        }
    }
}
