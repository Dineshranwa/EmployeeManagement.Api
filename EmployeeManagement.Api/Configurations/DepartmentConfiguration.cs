using Microsoft.EntityFrameworkCore;
using EmployeeManagement.Api.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmployeeManagement.Api.Configurations
{
    public class DepartmentConfiguration :IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder) {
            builder.Property(e => e.DepartmentName).HasColumnType("Varchar(50)").IsRequired();
            builder.Property(e => e.Description).HasMaxLength(150).IsUnicode(false);
            builder.Property(e => e.CreatedDate).HasDefaultValueSql("GetDate()").HasColumnType("DateTime").IsRequired();
            builder.Property(e => e.ModifiedDate);
        }
    }
}
