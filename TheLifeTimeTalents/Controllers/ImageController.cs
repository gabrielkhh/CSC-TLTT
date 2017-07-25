using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TheLifeTimeTalents.Controllers
{
    public class ImageController : Controller
    {
        // GET: /<controller>/
        public IActionResult Upload()
        {
            return View();
        }

        public IActionResult Gallery()
        {
            return View();
        }
    }
}
