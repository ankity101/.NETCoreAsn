using Assignment.Data;
using Assignment.Models;
using Microsoft.AspNetCore.Authorization;
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

        [HttpGet]
        [HttpPost]
        public IActionResult IsEmailInUse(string email)
        {
            var user = dbContext.employees.FirstOrDefault(u => u.Email == email);

            if (user == null)
                return Json(true);
            return Json($"Email {email} is already in use");
        }
        public IActionResult Index()
        {
            List<Employee> employees = dbContext.employees.ToList();
            return View(employees);
        }

        public IActionResult Create() {
            List<Organisation> dept =dbContext.organisations.ToList();
            List<string> Departments = new List<string>();
            foreach(var x in dept)
            {
                Departments.Add(x.OrganisationName);
            }
            ViewBag.org = Departments;
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
            List<Organisation> dept = dbContext.organisations.ToList();
            List<string> Departments = new List<string>();
            foreach (var x in dept)
            {
                Departments.Add(x.OrganisationName);
            }
            ViewBag.org = Departments;

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

            List<Organisation> dept = dbContext.organisations.ToList();
            List<string> Departments = new List<string>();
            foreach (var x in dept)
            {
                Departments.Add(x.OrganisationName);
            }
            ViewBag.org = Departments;

            return View(employee);

        }

        [HttpPost]
        public IActionResult Delete(Employee? employee)
        {
            ModelState.Remove("Email");

            if (employee == null)
                return RedirectToAction("Index");
            dbContext.employees.Remove(employee);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
