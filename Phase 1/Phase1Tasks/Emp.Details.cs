using System;
using System.Collections.Generic;
using System.Text;
//Task 1.17
namespace Application
{
    public partial class Employee
    {
        public string Department { get; set; } = string.Empty;

        public void DisplayDetails()
        {
            Console.WriteLine($"Employee ID: {EmployeeId}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Department: {Department}");
        }

        partial void OnNameChanged()
        {
            Console.WriteLine($"Name changed to: {Name}");
        }
    }
}
