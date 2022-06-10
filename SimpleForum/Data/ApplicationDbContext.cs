using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SimpleForum.Models;

namespace SimpleForum.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        DbSet<ApplicationUser> ApplicationUsers { get; set; }
        DbSet<Contribution> Contributions { get; set; }
        DbSet<Forum> Forums { get; set; }
    }
}