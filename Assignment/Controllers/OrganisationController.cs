using Assignment.Data;
using Assignment.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment.Controllers
{
    public class OrganisationController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public OrganisationController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IActionResult Index()
        {
             List<Organisation> objOrganisationList =  dbContext.organisations.ToList();
            return View(objOrganisationList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Create( Organisation organisation)
        {
            if (ModelState.IsValid)
            {
                dbContext.organisations.Add(organisation);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
