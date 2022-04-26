using System;
using System.Collections.Generic;
using System.Text;

namespace HrSystem
{
    class Trainer : Employee, ITeacher
    {
        public Trainer(string firstName, 
                        string lastName, 
                        string employeeId)
            : base(firstName, lastName, employeeId)
        {

        }

        public override void Display()
        {
            Console.WriteLine("Trainer:");
            base.Display();
        }

        public void Teach()
        {
            Console.WriteLine("Listen up, class is starting...");
        }
    }
}
