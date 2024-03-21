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
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) :base(options)
        {
        
        }

     
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           // modelBuilder.ApplyConfiguration<Department>(new Configurations.DepartmentConfigurations());

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Department> Departments { get; set; }


    }
}
