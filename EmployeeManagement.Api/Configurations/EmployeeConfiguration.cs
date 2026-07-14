using Microsoft.EntityFrameworkCore;
using EmployeeManagement.Api.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmployeeManagement.Api.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.EmployeeCode).HasMaxLength(11).IsRequired();
            builder.Property(e => e.FirstName).HasMaxLength(121).IsRequired();
        }
    }
}
