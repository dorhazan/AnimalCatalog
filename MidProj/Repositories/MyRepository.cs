using Microsoft.AspNetCore.Http;
using MidProj.Data;
using MidProj.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MidProj.Repositories
{
    public class MyRepository : IRepository
    {
        private ShopContext _context;
        public MyRepository(ShopContext context)
        {
            _context = context;
        }
        public IEnumerable<Animal> GetAnimals()
        {
            return _context.Animals.ToList();
        }
        public IEnumerable<Catagory> GetCatagories()
        {
            return _context.Catagories.ToList();
        }
        public IEnumerable<Comment> GetComments()
        {
            return _context.Comments.ToList();
        }
        public IEnumerable<Animal> GetAnimalbyCategoryID(int id)
        {
            return _context.Animals.Where(Animal => Animal.CatagoryId == id);
        }
        public Animal GetAnimalbyAnimalID(int id)
        {
            Animal animal = _context.Animals.FirstOrDefault(a => a.AnimalId == id);
            return animal;
        }
        public IEnumerable<Animal> GetTwoPopularAnimals()
        {
            IEnumerable<Animal> animals = _context.Animals.OrderBy(a => a.Comments.Count()).Reverse().ToList();
            return animals.Take(2);
        }

        public void AddNewAnimal(Animal animal, IFormFile file)
        {
            if (file != null)
            {
                animal.PictureName = file.FileName;
                string path = @"C:\Users\dorha\source\repos\MidProj\MidProj\wwwroot\images\" + file.FileName;
                var filestream = new FileStream(path, FileMode.Create);
                file.CopyToAsync(filestream);
                _context.Add(animal);
                _context.SaveChanges();
            }
        }

        public void AddNewComment(int id, Comment comment)
        {
            _context.Comments.Add(new Comment { CommentText = comment.CommentText, AnimalId = id });
            _context.SaveChanges();
        }
        public void DeleteAnimal(Animal animal)
        {
            _context.Animals.Remove(animal);
            _context.SaveChanges();
        }
        public void EditAnimal(int animalid, Animal animal, IFormFile file)
        {
            Animal oldanimal = GetAnimalbyAnimalID(animalid);
            if (file != null)
            {
                oldanimal.PictureName = file.FileName;
                string path = @"C:\Users\dorha\source\repos\MidProj\MidProj\wwwroot\images\" + file.FileName;
                var filestream = new FileStream(path, FileMode.Create);
                file.CopyToAsync(filestream);
            }
            oldanimal.Name = animal.Name;
            oldanimal.Age = animal.Age;
            oldanimal.CatagoryId = animal.CatagoryId;
            oldanimal.Description = animal.Description;
            _context.Animals.Update(oldanimal);
            _context.SaveChanges();

        }
    }
}
