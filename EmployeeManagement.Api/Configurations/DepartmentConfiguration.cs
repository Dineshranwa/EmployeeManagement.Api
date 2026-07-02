using Microsoft.EntityFrameworkCore;
using EmployeeManagement.Api.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmployeeManagement.Api.Configurations
{
    public class DepartmentConfiguration :IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder) { 
        }
    }
}
