using System;
using Microsoft.EntityFrameworkCore;
using SampleApp.Models;

namespace SampleApp.Repositories
{
	public class EmployeeRepository : IEmployeeRepository
	{
        private readonly EmployeeContext _employeeContext;

        public EmployeeRepository(EmployeeContext employeeContext)
		{
            _employeeContext = employeeContext;
		}

        public async Task<int> Add(Employee employee)
        {
            _employeeContext.Employees.Add(employee);
            await _employeeContext.SaveChangesAsync();
            return employee.ID;
        }

        public async Task<Employee> GetEmployee(int id)
        {
            return await _employeeContext.Employees.FindAsync(id);
        }

        public async Task<ICollection<Employee>> GetEmployees()
        {
            return await _employeeContext.Employees.ToListAsync();
        }
    }
}

