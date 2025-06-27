using System.ComponentModel.DataAnnotations;

namespace Snake.ViewModels
{
    public class ChangePasswordViewModel
    {

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress]
        
        public string Email { get; set; }
        
        [Required(ErrorMessage = "Password is required.")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Your password must be between 5 and 20 characters")]
        [DataType(DataType.Password)]
        [Display(Name = "New Password")]
        [Compare("ConfirmNewPassword", ErrorMessage = "Passwords are not matching")]
        
        public string NewPassword { get; set; }

        [Required(ErrorMessage = "Confirm Password is required.")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm New Password")]
        
        public string ConfirmNewPassword { get; set; }
    }
}
