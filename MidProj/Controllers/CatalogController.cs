using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MidProj.Models;
using MidProj.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MidProj.Controllers
{
    public class CatalogController : Controller
    {

        IRepository _myrepository;

        public CatalogController(IRepository myrepository)
        {

            _myrepository = myrepository;
        }
        public IActionResult Catalog(int id)
        {
            ViewBag.id = id;
            ViewBag.Animals = _myrepository.GetAnimalbyCategoryID(id);
            return View(_myrepository.GetCatagories());
        }
        public IActionResult AnimalDetails(int id)
        {
            ViewBag.AnimalSelected = _myrepository.GetAnimalbyAnimalID(id);
            return View();
        }
        public IActionResult AddComment(int id,Comment comment)
        {

             _myrepository.AddNewComment(id,comment);
            return RedirectToAction("AnimalDetails", new { id = id });
        }
    }
}
