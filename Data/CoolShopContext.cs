using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Data
{
    public class CompanyContext : DbContext
    {
        private const string ConnectionString = "Data Source=localhost;Database=Company;Integrated Security=true";

/*        public DbSet<Employee> Employees { get; set; }
        public DbSet<Project> Projects { get; set; }*/

        public CompanyContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlServer(ConnectionString)
                    .LogTo(Console.WriteLine, LogLevel.Information)
                    .EnableSensitiveDataLogging();
            }

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Employee>().Property(x => x.FirstName).IsRequired().HasColumnType("varchar(60)");

            base.OnModelCreating(modelBuilder);
        }
    }
}
