using System;
using System.Collections.Generic;

namespace CraftLR.Exercice3;

public class EmployeeReport
{
    public EmployeeReport(params Employee[] employees)
    {
        Employees = employees;
    }

    public IEnumerable<string> Adults => null;

    public IEnumerable<Employee> Employees { get; }

}

