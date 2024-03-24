using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using Route.C41.G03.BLL.Interfaces;
using Route.C41.G03.BLL.Repostiries;
using Route.C41.G03.DAL.models;
using System;

namespace Route.C41.G03.PL.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentRepository _departmentRepo;
        private readonly IWebHostEnvironment _env;

        public DepartmentController(IDepartmentRepository departmentRepo, IWebHostEnvironment env)
        { 
          _departmentRepo = departmentRepo;
            _env = env;
        }

        public IActionResult Index()
        {
            var department =_departmentRepo.GetAll();
            return View( department);
        }

       // [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(Department department)
        {
            if(ModelState.IsValid) 
            {
                var count = _departmentRepo.Add(department);
                if (count > 0)
                    return RedirectToAction(nameof(Index));
            }
            return View(department);
        }

       // [HttpGet]
        public IActionResult Details(int? id,string ViewName= "Details") 
        {
            if (id is null)
                return BadRequest();

            var department = _departmentRepo.Get(id.Value);

            if (id is null)
                return NotFound();

            return View(ViewName,department);

        }


       // [HttpGet]
        public IActionResult Edit(int? id)
        {

            return Details(id,"Edit");

          //  if (id is null)
          //      return BadRequest();
          //
          //  var department = _departmentRepo.Get(id.Value);
          //
          //  if (id is null)
          //      return NotFound();
          //
          //  return View(department);
        }

        [HttpPost]
        public IActionResult Edit(Department department)
        {
            if (!ModelState.IsValid)
            
                return View(department);

            try
            {
                _departmentRepo.Update(department);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                //1. log Exception
                //2. Friendly Message
                if (_env.IsDevelopment())
                  ModelState.AddModelError(string.Empty, ex.Message);
                else
                    ModelState.AddModelError(string.Empty, "An error has occured during update department");
                return View(department);
            }


        }
    }
}
