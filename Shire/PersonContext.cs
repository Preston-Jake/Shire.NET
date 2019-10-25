using Microsoft.EntityFrameworkCore;
using Shire;

namespace TestProject
{
    public class PersonContext : DbContext
    {
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1433; Database=PersonDB;User=sa; Password=reallyStrongPwd123");
        }
    }
}