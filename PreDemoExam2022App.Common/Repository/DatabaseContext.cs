using Microsoft.EntityFrameworkCore;
using PreDemoExam2022App.Common.Model;

namespace PreDemoExam2022App.Common.Repository
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=PreDemoExam2022App;Trusted_Connection=True;");
        }
    }
}
