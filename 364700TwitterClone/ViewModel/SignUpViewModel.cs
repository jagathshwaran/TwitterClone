using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace DataLayer.ViewModel
{
    public class SignUpViewModel
    {
        [Required(ErrorMessage = "Please Enter User Name")]
        [Remote("IsAlreadyExists", "TwitterClone", HttpMethod = "POST", ErrorMessage = "UserId already exists.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please Enter Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please Enter Full Name")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Please Enter valid Email")]
        [EmailAddress]
        public string Email { get; set; }

        public bool isRegistered { get; set; } = false;
    }
}



