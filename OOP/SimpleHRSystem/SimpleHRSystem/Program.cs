using System;
using System.Collections.Generic;

class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
    public double Salary { get; set; }
    public string Department { get; set; }
    public string JobTitle { get; set; }

    public Employee(string name, int age, double salary, string department, string jobTitle)
    {
        Name = name;
        Age = age;
        Salary = salary;
        Department = department;
        JobTitle = jobTitle;
    }

    public void PrintDetails()
    {
        Console.WriteLine("Name: {0}, Age: {1}, Salary: {2:C}, Department: {3}, Job Title: {4}", Name, Age, Salary, Department, JobTitle);
    }
}

class EmployeeManagementSystem
{
    private List<Employee> employees;

    public EmployeeManagementSystem()
    {
        employees = new List<Employee>();
    }

    public void AddEmployee(Employee employee)
    {
        employees.Add(employee);
        Console.WriteLine("{0} has been added to the system.", employee.Name);
    }

    public void RemoveEmployee(Employee employee)
    {
        employees.Remove(employee);
        Console.WriteLine("{0} has been removed from the system.", employee.Name);
    }

    public void UpdateEmployee(Employee employee, string name, int age, double salary, string department, string jobTitle)
    {
        employee.Name = name;
        employee.Age = age;
        employee.Salary = salary;
        employee.Department = department;
        employee.JobTitle = jobTitle;
        Console.WriteLine("{0}'s details have been updated.", employee.Name);
    }

    public void PrintEmployees()
    {
        Console.WriteLine("Employee Details:");
        foreach (Employee employee in employees)
        {
            employee.PrintDetails();
        }
    }

    public List<Employee> SearchEmployeesByName(string name)
    {
        List<Employee> matchedEmployees = new List<Employee>();
        foreach (Employee employee in employees)
        {
            if (employee.Name.Contains(name))
            {
                matchedEmployees.Add(employee);
            }
        }
        return matchedEmployees;
    }

    public List<Employee> GetEmployeesInDepartment(string department)
    {
        List<Employee> employeesInDepartment = new List<Employee>();
        foreach (Employee employee in employees)
        {
            if (employee.Department == department)
            {
                employeesInDepartment.Add(employee);
            }
        }
        return employeesInDepartment;
    }

    public List<Employee> GetEmployeesByJobTitle(string jobTitle)
    {
        List<Employee> employeesByJobTitle = new List<Employee>();
        foreach (Employee employee in employees)
        {
            if (employee.JobTitle == jobTitle)
            {
                employeesByJobTitle.Add(employee);
            }
        }
        return employeesByJobTitle;
    }

    public void PrintSalaryReport()
    {
        Console.WriteLine("Salary Report:");
        Console.WriteLine("-------------");

        Dictionary<string, double> departmentSalaries = new Dictionary<string, double>();
        foreach (Employee employee in employees)
        {
            if (departmentSalaries.ContainsKey(employee.Department))
            {
                departmentSalaries[employee.Department] += employee.Salary;
            }
            else
            {
                departmentSalaries[employee.Department] = employee.Salary;
            }
        }

        foreach (string department in departmentSalaries.Keys)
        {
            double totalSalary = departmentSalaries[department];
            int numEmployees = GetEmployeesInDepartment(department).Count;
            double averageSalary = totalSalary / numEmployees;

            Console.WriteLine("{0}: Total Salary - {1:C}, Average Salary - {2:C}", department, totalSalary, averageSalary);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a new employee management system object
        EmployeeManagementSystem empSystem = new EmployeeManagementSystem();

        // Add some employees to the system
        empSystem.AddEmployee(new Employee("John Doe", 30, 50000.00, "Engineering", "Software Developer"));
        empSystem.AddEmployee(new Employee("Jane Smith", 25, 40000.00, "Marketing", "Marketing Coordinator"));
        empSystem.AddEmployee(new Employee("Bob Johnson", 40, 60000.00, "Sales", "Sales Manager"));

        // Print the employee details
        empSystem.PrintEmployees();

        // Search for employees by name
        Console.WriteLine("\nSearching for employees by name:");
        List<Employee> matchedEmployees = empSystem.SearchEmployeesByName("John");
        foreach (Employee employee in matchedEmployees)
        {
            employee.PrintDetails();
        }

        // Get employees in a specific department
        Console.WriteLine("\nGetting employees in a specific department:");
        List<Employee> employeesInDepartment = empSystem.GetEmployeesInDepartment("Marketing");
        foreach (Employee employee in employeesInDepartment)
        {
            employee.PrintDetails();
        }

        // Get employees with aspecific job title
        Console.WriteLine("\nGetting employees with a specific job title:");
        List<Employee> employeesByJobTitle = empSystem.GetEmployeesByJobTitle("Sales Manager");
        foreach (Employee employee in employeesByJobTitle)
        {
            employee.PrintDetails();
        }

        // Update an employee's details and print the modified employee details
        Employee employeeToUpdate = new Employee("Bob Johnson", 40, 60000.00, "Sales", "Sales Manager");
        empSystem.UpdateEmployee(employeeToUpdate, "Robert Johnson", 41, 65000.00, "Sales", "Senior Sales Manager");
        Console.WriteLine("\nEmployee details after update:");
        empSystem.PrintEmployees();

        // Print a salary report
        empSystem.PrintSalaryReport();

        // Remove an employee and print the modified employee details
        Employee employeeToRemove = new Employee("Jane Smith", 25, 40000.00, "Marketing", "Marketing Coordinator");
        empSystem.RemoveEmployee(employeeToRemove);
        Console.WriteLine("\nEmployee details after removal:");
        empSystem.PrintEmployees();

        Console.ReadKey();
    }
}