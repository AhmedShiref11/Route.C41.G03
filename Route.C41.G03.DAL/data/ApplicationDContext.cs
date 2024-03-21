using Microsoft.EntityFrameworkCore;
using Route.C41.G03.DAL.data.Configurations;
using Route.C41.G03.DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Route.C41.G03.DAL.data
{
    internal class ApplicationDContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        
           =>optionsBuilder.UseSqlServer("Server=.; Database = MVCApllication; Trusted_Connection=True; MultipleActiveResultSets=True");
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           // modelBuilder.ApplyConfiguration<Department>(new Configurations.DepartmentConfigurations());

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Department> Departments { get; set; }


    }
}
