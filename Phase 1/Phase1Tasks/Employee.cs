using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Text;
//Task 1.17
namespace Application
{
    public partial class Employee
    {
        public int EmployeeId { get; set; }
        private string name = string.Empty;
        public string Name
        {
            get => name;
            set
            {
                name = value;
                OnNameChanged();
            }
        }

        partial void OnNameChanged(); // Declaration of partial method
    }
}
