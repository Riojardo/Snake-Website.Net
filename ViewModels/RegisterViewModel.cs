using System.ComponentModel.DataAnnotations;

namespace Snake.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "Password is required.")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Your password must be between 5 and 20 characters")]
        [DataType(DataType.Password)]
        [Compare("ConfirmPassword", ErrorMessage = "Passwords are not matching")]
        public string Password { get; set; }
       
        [Required(ErrorMessage = "Confirm Password is required.")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
