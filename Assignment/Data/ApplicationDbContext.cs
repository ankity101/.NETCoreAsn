using Assignment.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        private List<Organisation> GetOrganisations()
        {
            return Enumerable.Range(1, 20)
                .Select(index => new Organisation
                {
                    OrganisationId = index,
                    OrganisationName = $"Org{index}"
                })
                .ToList();
        }

        private List<Employee> GetEmployees()
        {
            return Enumerable.Range(1, 20) 
                .Select(index => new Employee
                {
                    EmployeeId = index,
                    FirstName = $"First{index}",
                    LastName = $"Last{index}",
                     Email= $"Email{index}@abc.com",
                     Phone = $"Phone{index}"
                })
                .ToList();
        }


        public DbSet<Organisation> organisations { get; set; }

        public DbSet<Employee> employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Organisation>().HasData(GetOrganisations());
            modelBuilder.Entity<Employee>().HasData(GetEmployees());
        }

    }
}
