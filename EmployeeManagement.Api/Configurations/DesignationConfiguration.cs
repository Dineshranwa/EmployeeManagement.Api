using EmployeeManagement.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Identity.Client;

namespace EmployeeManagement.Api.Configurations
{
    public class DesignationConfiguration :IEntityTypeConfiguration<Designation>
    {
        public void Configure(EntityTypeBuilder<Designation> buikder) { 
        }

    }
}
