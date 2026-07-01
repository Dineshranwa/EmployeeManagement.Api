using EmployeeManagement.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
namespace EmployeeManagement.Api.Data
{
    public class AppliactionDbContext : DbContext
    {  
        public AppliactionDbContext(DbContextOptions<AppliactionDbContext> options) : base(options) { 
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Designation> Designations { get; set; }
        public DbSet<Department> Departments{ get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employee>(entity =>{
                entity.Property(e =>e.FirstName ).HasMaxLength(121).IsRequired();
            });
        }
    }
}
