using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TheLifeTimeTalents.Controllers
{
    public class TalentController : Controller
    {
        // GET: /<controller>/
        public IActionResult AddTalent()
        {
            return View();
        }

        public IActionResult ViewTalents()
        {
            return View();
        }

        public IActionResult EditTalent()
        {
            return View();
        }

    }
}
