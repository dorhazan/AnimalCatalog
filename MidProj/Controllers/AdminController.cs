using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
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
    [Authorize(Roles = "Administrators")]

    public class AdminController : Controller
    {
        IRepository _myrepository;
        List<SelectListItem> _catagories;

        public AdminController(IRepository myrepository)
        {
            _myrepository = myrepository;
            _catagories = _myrepository.GetCatagories().Select(a => new SelectListItem(a.Name, a.CatagoryId.ToString())).ToList();
        }
        public IActionResult CreateAnimal()
        {

            ViewBag.catagories = _catagories;
            return View();
        }
        public IActionResult AddAnimal(Animal animal, IFormFile file)
        {
            if (ModelState.IsValid & file !=null)
            {
                _myrepository.AddNewAnimal(animal, file);
                return RedirectToAction("AnimalDetails", "Catalog", new { id = animal.AnimalId });
            }
            ViewBag.catagories = _catagories;
            return View("CreateAnimal");
        }
        public IActionResult Admin(int id)
        {
            ViewBag.id = id;
            ViewBag.Animals = _myrepository.GetAnimalbyCategoryID(id);
            return View(_myrepository.GetCatagories());
        }
        public IActionResult DeleteAnimal(int animalid)
        {
            Animal animal = _myrepository.GetAnimalbyAnimalID(animalid);
            _myrepository.DeleteAnimal(animal);
            return RedirectToAction("Admin", "Admin", new { id = animal.CatagoryId });
        }
        public IActionResult EditAnimal(int animalid)
        {
            ViewBag.catagories = _catagories;
            return View(_myrepository.GetAnimalbyAnimalID(animalid));
        }
        public IActionResult EditedAnimal(int animalid, Animal animal,IFormFile file)
        {
            if (ModelState.IsValid)
            {
                _myrepository.EditAnimal(animalid, animal, file);
                ViewBag.catagories = _catagories;
                return RedirectToAction("AnimalDetails", "Catalog", new { id = animal.AnimalId });
            }
            ViewBag.catagories = _catagories;
            return View("EditAnimal");
        }

    }
}

