using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MidProj.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
       [Required(ErrorMessage ="Please enter a comment.")]
       [MinLength(10,ErrorMessage ="Comment must be atleast 10 letters.")]
        public string CommentText { get; set; }
        public int AnimalId { get; set; }
        public virtual Animal animal { get; set; }

    }
}
