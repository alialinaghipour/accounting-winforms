using DataLayer.Models;
using Microsoft.EntityFrameworkCore;
namespace DataLayer
{
    public class ApplicationDbContext
        : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer("Server=.;Database=AccountingDb;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Accounting> Accountings { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<MyProfile> MyProfiles { get; set; }
    }
}
