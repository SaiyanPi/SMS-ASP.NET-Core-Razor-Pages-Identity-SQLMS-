using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SMS.Model;
using SMS.Model.Class1;
using SMS.Model.Class2;

namespace SMS.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<Classes> ClassesList { get; set; }
        public DbSet<Class1> ClassOne { get; set; }
        public DbSet<Class2> ClassTwo { get; set; }
    }
}
