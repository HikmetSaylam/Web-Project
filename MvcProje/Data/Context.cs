using Microsoft.EntityFrameworkCore;
using MvcProje.Models.Entity;

namespace MvcProje.Data
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database = AnimalDb;Trusted_Connection=true");

        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ImageFile> ImageFiles { get; set; }

    }
}
