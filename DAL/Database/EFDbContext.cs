using ITI_Console_Day2EF.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_Console_Day2EF.DAL.Database
{
    public class EFDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-TBVH1HT\\MSSQLSERVER01;Database=EFITIDay1;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<dept>()
                .Property(b => b.id)
                .IsRequired();

            modelBuilder.Entity<dept>()
                .HasKey(b => b.id);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<dept> dept { get; set; }
    }
}
