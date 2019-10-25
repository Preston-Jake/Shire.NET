using System;
using Microsoft.EntityFrameworkCore;
using Shire.Models;

namespace Shire.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Person> People { get; set; }

    }
}
