using EmployeeManagement.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
namespace EmployeeManagement.Api.Data
{
    public class AppliactionDbContext : DbContext
    {
        public AppliactionDbContext(DbContextOptions<AppliactionDbContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Designation> Designations { get; set; }
        public DbSet<Department> Departments { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employee>(entity =>
            {
                
                entity.Property(e => e.EmployeeCode).HasMaxLength(10).IsRequired();
                entity.Property(e => e.FirstName).HasMaxLength(100).IsRequired();
                entity.Property(e => e.LastName).HasMaxLength(100).IsRequired();
                entity.Property(e => e.Email).HasMaxLength(200).IsRequired();
                entity.Property(e => e.PhoneNumber).HasMaxLength(15).IsRequired();
                entity.Property(e => e.JoiningDate).IsRequired();
                entity.Property(e => e.DateOfLeaving);
                entity.Property(e => e.EmployementStatus).HasMaxLength(50);
                entity.Property(e => e.DepartmentId);
                entity.Property(e => e.DesignationId).HasMaxLength(200).IsRequired();
                entity.Property(e => e.IsActive).HasDefaultValue(false);
                entity.Property(e => e.CreatedDate).HasDefaultValue(DateTime.Now).IsRequired();
                entity.Property(e => e.ModifiedDate);


            });
        }
    }
}
