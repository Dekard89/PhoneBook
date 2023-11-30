using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using PhoneBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace PhoneBook.Domain
{
    public class ApplicationContext: DbContext

    {
         public DbSet<User> Users { get; set; }

         public DbSet<PhoneNumber> Numbers { get; set; }

       

        public ApplicationContext()
        {
            Database.Migrate();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=PhoneBookDB;Username=postgres;Password=696;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("PhoneBook");
            modelBuilder.Entity<PhoneNumber>().DeleteUsingStoredProcedure(CascadeDeleteConvention)
        }
       

    }
}
