using Microsoft.EntityFrameworkCore;
using MiniAPIEntity.Models;
namespace MiniAPIEntity.Data
{
    public class OfficeDb : DbContext
    {
        public OfficeDb(DbContextOptions<OfficeDb> options): base(options)
        {

        }
        public DbSet<Employee> Employees => Set<Employee>();
    }
}
