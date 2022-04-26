using System;
using System.Collections.Generic;
using System.Text;

namespace HrSystem
{
    class Tutor : Contractor, ITeacher
    {
        public Tutor(string firstName, 
                        string lastName, 
                        string agency)
            : base(firstName, lastName, agency)
        {

        }

        public override void Display()
        {
            Console.WriteLine("Tutor:");
            base.Display();
        }

        public void Teach()
        {
            Console.WriteLine("Please sit down, class is starting");
        }

    }
}
