using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using contactii2.Models;

namespace contactii2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<contactii2.Models.Contact> Contact { get; set; } = default!;
        public DbSet<contactii2.Models.Categorie> Categorie { get; set; } = default!;
    }
}
