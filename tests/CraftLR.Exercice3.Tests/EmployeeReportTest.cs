using System;

using FluentAssertions;

using Xunit;


namespace CraftLR.Exercice3;

public class EmployeeReportTest
{
    private static EmployeeReport BuildEmployees()
    {
        return new EmployeeReport(new Employee("Max", 17), new Employee("Sepp", 18), new Employee("Nina", 15), new Employee("mike", 51));
    }

    [Fact]
    public void TestThatTheEmployeeReportShouldBeConstructedWithFourEmployees()
    {
        var report = BuildEmployees();
        report.Employees.Should().NotBeEmpty().And.HaveCount(4);
    }
}
