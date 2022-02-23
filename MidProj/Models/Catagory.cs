using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MidProj.Models
{
    public class Catagory
    { 
        public int CatagoryId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Animal> Animals { get; set; }
    }
}
