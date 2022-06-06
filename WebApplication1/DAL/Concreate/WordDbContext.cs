using Microsoft.EntityFrameworkCore;
using WebApplication1.Entities;

namespace WebApplication1.DAL.Concreate
{
    public class WordDbContext : DbContext
    {
        public DbSet<Word> Words { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new WordConfig());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=gunun_sozu;");
        }
    }
}
