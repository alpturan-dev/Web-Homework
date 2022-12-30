using Microsoft.EntityFrameworkCore;

namespace Web_Homework.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost,1433; Initial Catalog=DormitoryDB; User Id=SA;Password=Abudu321.;Encrypt=yes;TrustServerCertificate=true; Integrated Security=true;Trusted_Connection=false;MultipleActiveResultSets=True;");
        }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }

}