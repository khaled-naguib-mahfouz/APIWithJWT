using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace APIWithJWT.Models
{
    public class Context:IdentityDbContext<ApplicationUser>
    {
        public Context(DbContextOptions<Context> options)
      : base(options)
        {
        }
    }
}
