using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Snake.Models;

namespace Snake.Data
{
    public class AppDbContex : IdentityDbContext<Users>
    {
        public AppDbContex(DbContextOptions options) : base(options)
        {
        }

        protected AppDbContex()
        {
        }
    }
}
