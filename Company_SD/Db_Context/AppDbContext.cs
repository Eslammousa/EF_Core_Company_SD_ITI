using Company_SD.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Company_SD.Db_Context
{
    public class AppDBContext : DbContext
    {
        DbSet<Employee> Employees { get; set; }
        DbSet<Department> Departments { get; set; }
        DbSet<Location> Locations { get; set; }

        DbSet<Project> Projects { get; set; }

        //      DbSet<Dependent> Dependents { get; set; }

        DbSet<Work> Works { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            var Config = new ConfigurationBuilder()
            .AddJsonFile("AppSettings.json").Build();

            var ConnectionString = Config.GetSection("constr").Value;

            optionsBuilder.UseSqlServer(ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDBContext).Assembly);
        }

    }
}
