using Banking_Management_System.Models;
using Microsoft.EntityFrameworkCore;

namespace Banking_Management_System.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Bank>banks { get; set; }
        public DbSet<User>users { get; set; }
    }
}
