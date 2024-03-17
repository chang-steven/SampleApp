using NSubstitute;
using Microsoft.Extensions.Logging;
using SampleApp.Repositories;
using SampleApp.Models;
using SampleApp.Controllers;

namespace SampleApp.tests;

[TestFixture]
public class EmployeesControllerTests
{
    private readonly ILogger<EmployeesController> _logger;
    private readonly IEmployeeRepository _repository;

    public EmployeesControllerTests()
    {
        _logger = Substitute.For<ILogger<EmployeesController>>();
        _repository = Substitute.For<IEmployeeRepository>();
    }

    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void EmployeesController_GetEmployees_ReturnSuccess()
    {
        // Arrange
        var controller = new EmployeesController(_logger, _repository);

        // Act
        var result = controller.GetEmployees();

        // Assert
        Assert.That(_repository.ReceivedCalls().Count(), Is.EqualTo(1));
    }

    [Test]
    public void EmployeesController_PostEmployee_Return201()
    {
        // Arrange
        var controller = new EmployeesController(_logger, _repository);

        // Act
        var result = controller.PostEmployee(new Employee
        { ID = 1, FirstName = "John", LastName = "Doe", Address = "123 1st St.", RoleID = 1, PayPerHour = (decimal)10.50 });

        // Assert
        Assert.That(result.Id, Is.EqualTo(1));
    }

}