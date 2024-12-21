using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{
    // Abstract base class representing an employee
    public abstract class Employee
    {
        // Properties for employee name and ID
        public string Name { get; set; }
        public int EmployeeId { get; set; }

        // Abstract method to calculate salary, to be implemented by derived classes
        public abstract decimal CalculateSalary();
    }

    // Class representing a full-time employee, derived from Employee
    public class FullTimeEmployee : Employee
    {
        // Property for monthly salary
        public decimal MonthlySalary { get; set; }

        // Override the CalculateSalary method to return the monthly salary
        public override decimal CalculateSalary()
        {
            return MonthlySalary;
        }
    }

    // Class representing a part-time employee, derived from Employee
    public class PartTimeEmployee : Employee
    {
        // Properties for hourly rate and hours worked
        public decimal HourlyRate { get; set; }
        public int HoursWorked { get; set; }

        // Override the CalculateSalary method to calculate salary based on hourly rate and hours worked
        public override decimal CalculateSalary()
        {
            return HourlyRate * HoursWorked;
        }
    }

    // Main program class
    class Abstraction
    {
        public static void Run()
        {
            // Create a full-time employee
            FullTimeEmployee fullTimeEmployee = new FullTimeEmployee
            {
                Name = "John Doe",
                EmployeeId = 1,
                MonthlySalary = 3000
            };

            // Create a part-time employee
            PartTimeEmployee partTimeEmployee = new PartTimeEmployee
            {
                Name = "Jane Smith",
                EmployeeId = 2,
                HourlyRate = 20,
                HoursWorked = 80
            };

            // Display the salaries of both employees
            Console.WriteLine($"{fullTimeEmployee.Name}'s Salary: {fullTimeEmployee.CalculateSalary()}");
            Console.WriteLine($"{partTimeEmployee.Name}'s Salary: {partTimeEmployee.CalculateSalary()}");
        }
    }
}
