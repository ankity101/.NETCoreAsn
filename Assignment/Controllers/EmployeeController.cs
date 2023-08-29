using Assignment.Data;
using Assignment.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public EmployeeController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IActionResult Index()
        {
            List<Employee> employees = dbContext.employees.ToList();
            return View(employees);
        }

        public IActionResult Create() {
            return View();
        }

        [HttpPost]

        public IActionResult Create(Employee employee) 
        { 
            if(employee == null)
                return RedirectToAction("Index");
            int? id = employee.EmployeeId;
            if(id==null)
                return RedirectToAction("Index");
           Employee? empExisting =  dbContext.employees.Find(id);
            if(empExisting==null)
            {
                dbContext.employees.Add(employee);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            throw  new Exception("Employee Id can not be duplicate");
        }

        public IActionResult Edit(int? id)
        {
            Employee employee = dbContext.employees.Find(id);
            if(employee == null)
               RedirectToAction("Index");
            return View(employee);
        }

        [HttpPost]
        public IActionResult Edit(Employee employee)
        {
            if(employee == null)
                return RedirectToAction("Index");
            dbContext.employees.Update(employee);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
                return RedirectToAction("Index");
            Employee? employee = dbContext.employees.Find(id);
            if (employee == null)
                return RedirectToAction("Index");
            return View(employee);

        }

        [HttpPost]
        public IActionResult Delete(Employee? employee)
        {
            if(employee == null)
                return RedirectToAction("Index");
            dbContext.employees.Remove(employee);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
