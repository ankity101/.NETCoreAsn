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


        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var org = dbContext.organisations.FirstOrDefault(c => c.OrganisationId == id);
            if (org == null)
                return NotFound();
            return View(org);
        }

        [HttpPost]
        public IActionResult Edit(Organisation? org)
        {
            if (org.OrganisationId == null || org.OrganisationId == 0)
            {
                return View();
            }
            dbContext.organisations.Update(org);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            Organisation org = dbContext.organisations.FirstOrDefault(x => x.OrganisationId == id);
            if (org == null)
                return NotFound();
            return View(org);
        }

        [HttpPost]
        public IActionResult Delete(Organisation org)
        {
            if (org == null)
            {
                return View("Index");
            }
            dbContext.organisations.Remove(org);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }


        }
}
