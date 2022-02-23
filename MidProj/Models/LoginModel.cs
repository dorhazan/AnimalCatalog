using System.ComponentModel.DataAnnotations;

namespace MidProj.Models
{
    public class LoginModel
    {

        [Required(ErrorMessage = "Please enter Username.")]
        [MinLength(6, ErrorMessage = "Username must be atleast 6 letters.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter your Password.")]
        [RegularExpression(@"^.*(?=.{8,})(?=.*[\d])(?=.*[\W]).*$",ErrorMessage = "Password Must contain at least 8 characters, one upper case letter, one lower case letter and one symbol or special character.")]
        public string Password { get; set; }
    }
}