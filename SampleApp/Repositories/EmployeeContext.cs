using Microsoft.EntityFrameworkCore;
using SampleApp.Models;

namespace SampleApp.Repositories
{
	public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options)
            : base(options)
            { }

        public DbSet<Employee> Employees { get; set; } = null!;
    }
}

