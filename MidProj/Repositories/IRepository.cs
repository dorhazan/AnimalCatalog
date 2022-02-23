using Microsoft.AspNetCore.Http;
using MidProj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MidProj.Repositories
{
    public interface IRepository
    {
        IEnumerable<Animal> GetAnimals();
        IEnumerable<Catagory> GetCatagories();
        IEnumerable<Comment> GetComments();
        IEnumerable<Animal> GetAnimalbyCategoryID(int id);
        IEnumerable<Animal> GetTwoPopularAnimals();
        Animal GetAnimalbyAnimalID(int id);
        void AddNewAnimal(Animal animal,IFormFile file);
        void AddNewComment(int id, Comment comment);
        void DeleteAnimal(Animal animal);
        void EditAnimal(int animalid, Animal animal, IFormFile file);





    }
}
