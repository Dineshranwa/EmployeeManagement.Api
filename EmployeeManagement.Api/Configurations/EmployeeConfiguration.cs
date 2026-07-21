using EmployeeManagement.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace EmployeeManagement.Api.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {

                builder.Property(e => e.EmployeeCode).HasMaxLength(10).IsRequired();
                builder.Property(e => e.FirstName).HasMaxLength(100).IsRequired();
                builder.Property(e => e.LastName).HasMaxLength(100).IsRequired();
                builder.Property(e => e.Email).HasMaxLength(200).IsRequired();
                builder.Property(e => e.PhoneNumber).HasMaxLength(15).IsRequired();
                builder.Property(e => e.JoiningDate).IsRequired();
                builder.Property(e => e.DateOfLeaving);
                builder.Property(e => e.EmployementStatus).HasMaxLength(50);
                builder.Property(e => e.DepartmentId);
                builder.Property(e => e.DesignationId);
                builder.Property(e => e.IsActive).HasDefaultValue(false);
                builder.Property(e => e.CreatedDate).HasDefaultValueSql("GETDATE()").IsRequired();
                builder.Property(e => e.ModifiedDate);


            
        }
    }
}
