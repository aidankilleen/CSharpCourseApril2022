using System;

namespace HrSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HR System");

            Person person = new Person("Alice", "Adams");
            person.Display();

            Employee employee = new Employee("Bob", "Brett", "E1235");
            employee.Display();

            Contractor contractor = new Contractor("Carol", "Conway", "CPL");
            contractor.Display();

            Manager manager = new Manager("Danielle", "Dunne", "E5432", 10);
            manager.Display();


            Console.WriteLine("==================================");
            Person[] people = new Person[]
            {
                person, 
                employee, 
                contractor, 
                manager
            };

            foreach (Person p in people)
            {
                p.Display();
            }













            
        }
    }   
}
