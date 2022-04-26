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


            Console.WriteLine("===============================");


            Trainer trainer = new Trainer("Eve", 
                                            "Evans", 
                                            "E11111");
            trainer.Display();
            trainer.Teach();


            Tutor tutor = new Tutor("Fred",
                                    "Fitzgerald",
                                    "CPL");

            tutor.Display();
            tutor.Teach();

            Console.WriteLine("==================================");

            ITeacher[] faculty = new ITeacher[]
            {
                trainer,
                tutor
            };

            foreach (ITeacher teacher in faculty)
            {
                teacher.Teach();
                Person pt = (Person)teacher;
                pt.Display();
            }
        }
    }   
}
