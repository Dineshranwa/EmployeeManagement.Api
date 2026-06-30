using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
namespace EmployeeManagement.Api.Data
{
    public class AppliactionDbContext : DbContext
    {  
        public AppliactionDbContext(DbContextOptions<AppliactionDbContext> options) : base(options) { 
        }
    }
}
