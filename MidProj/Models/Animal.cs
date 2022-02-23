using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MidProj.Models
{
    public class Animal
    {
        public int AnimalId { get; set; }
        [Required(ErrorMessage = "Please enter Name.")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Please enter Age.")]
        [Range(1, 100, ErrorMessage = "Age must be between 1 and 100.")]
        public int? Age { get; set; }
        public string PictureName { get; set; }
        [Required(ErrorMessage = "Please enter Description.")]
        [MinLength(10,ErrorMessage ="Description must be atleast 10 letters.")]
        public string Description { get; set; }
        public int CatagoryId { get; set; }
        public virtual Catagory Catagory { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }


    }
}
