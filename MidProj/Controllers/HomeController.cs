using Microsoft.AspNetCore.Mvc;
using MidProj.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MidProj.Controllers
{
    public class HomeController : Controller
    {
        IRepository _myrepository;
        public HomeController(IRepository myrepository)
        {
            _myrepository = myrepository;
        }
        public IActionResult Home()
        {
            return View(_myrepository.GetTwoPopularAnimals());
        }
    }
}
