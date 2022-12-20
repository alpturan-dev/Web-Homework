using Microsoft.EntityFrameworkCore;

namespace Web_Homework.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=SA; database=DormitoryDB; integrated security=true");
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Person> People { get; set; }
    }
}
