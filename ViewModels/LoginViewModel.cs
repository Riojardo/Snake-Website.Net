using System.ComponentModel.DataAnnotations;

namespace Snake.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "An Email is required.")]

        public string Email { get; set; }

        [Required(ErrorMessage = "A Password is required.")]
        [DataType(DataType.Password)]   
        public string Password { get; set; }

/*      [Required(ErrorMessage = "Please confirm Password.")]
        [DataType(DataType.Password)]

        public string ConfirmPassword { get; set; }*/

        [Display(Name = "Remember Me")]
        public bool RememberMe { get; set; }
    }
}
