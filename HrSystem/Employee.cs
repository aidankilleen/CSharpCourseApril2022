using System;
using System.Collections.Generic;
using System.Text;

namespace HrSystem
{
    class Employee : Person
    {
        public string EmployeeId { get; set; }

        public Employee(string firstName, 
                        string lastName, 
                        string employeeId)
            : base(firstName, lastName)
        {
            EmployeeId = employeeId;
        }

        public override void Display()
        {
            Console.WriteLine("Employee:");
            base.Display();
            Console.WriteLine($"EmployeeId:{ EmployeeId }");
        }
    }
}
