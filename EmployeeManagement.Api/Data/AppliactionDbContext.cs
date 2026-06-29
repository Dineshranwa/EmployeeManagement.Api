using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
namespace EmployeeManagement.Api.Data
{
    public class AppliactionDbContext : DbContext
    {// db context has been added here. finally thank you  
        public AppliactionDbContext(DbContextOptions<AppliactionDbContext> options) : base(options) { 
        }
    }
}
