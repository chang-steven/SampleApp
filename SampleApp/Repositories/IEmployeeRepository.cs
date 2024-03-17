using System;
using SampleApp.Models;
namespace SampleApp.Repositories
{
	public interface IEmployeeRepository
	{
        Task<int> Add(Employee employee);
		Task<ICollection<Employee>> GetEmployees();
		Task<Employee> GetEmployee(int id);
	}
}

