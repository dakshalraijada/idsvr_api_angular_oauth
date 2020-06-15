using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Template.Core;

namespace Template.Data
{
    public class TemplateDbContext : IdentityDbContext<User, IdentityRole<int>, int>
    {
        public TemplateDbContext(DbContextOptions<TemplateDbContext> options)
           : base(options)
        {
        }
    }
}
