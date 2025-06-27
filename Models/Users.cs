using Microsoft.AspNetCore.Identity;

namespace Snake.Models
{
    public class Users : IdentityUser
    {
        public int score { get; set; }

    }
}
