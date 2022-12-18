using Entity_first.Core.Classes;
using Microsoft.EntityFrameworkCore;

namespace Entity_first.Entity
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            object value = optionsBuilder.UseSqlServer(@"Server=Victus;Database=BsuDb;Trusted_Connection=True;");
        }

        public DbSet<Employee> employees { get; set; }
    }
}

