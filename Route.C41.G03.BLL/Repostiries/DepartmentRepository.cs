using Microsoft.EntityFrameworkCore;
using Route.C41.G03.BLL.Interfaces;
using Route.C41.G03.DAL.data;
using Route.C41.G03.DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Route.C41.G03.BLL.Repostiries
{
    public class DepartmentRepository : IDepartmentRepository
    {
         private readonly ApplicationDbContext _dbContext;
        public DepartmentRepository(ApplicationDbContext dbContext)
        {
            //_dbContext =  new ApplicationDbContext(new Microsoft.EntityFrameworkCore.DbContextOptions<ApplicationDbContext>)
             
             _dbContext = dbContext;
        
        }

        public int Add(Department entity)
        {
            _dbContext.Departments.Add(entity);
           return _dbContext.SaveChanges(); 
        }

        public int Delete(Department entity)
        {
           _dbContext.Departments.Remove(entity);
            return _dbContext.SaveChanges();
        }

        public int Update(Department entity)
        {
           _dbContext.Departments.Update(entity);
           return  _dbContext.SaveChanges();
        }
        public Department Get(int id)
        {
            return _dbContext.Find<Department>(id);
        }

        public IEnumerable<Department> GetAll()
        {
            return _dbContext.Departments.AsNoTracking().ToList();
        }

    }
}
