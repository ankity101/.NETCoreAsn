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

        public DbSet<Organisation> organisations { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Organisation>().HasData(GetOrganisations());
        }

    }
}
