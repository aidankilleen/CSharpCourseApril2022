using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulationTest
{
    class Person
    {
        /*
        public string _name;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        */

        public string Name { get; set; }



        



        private int _age;

        // This is a "property" 
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value > 0 && value <= 120)
                {
                    _age = value;
                } else
                {
                    //Console.WriteLine($"invalid age { value }");
                    throw new ArgumentException($"invalid age { value }");
                }
            }
        }



        /* we never create set methods in C# 
         * using this type of syntax!!!
        public void setAge(int age)
        {
            if (age > 0 && age < 110)
            {
                this.age = age;

            }
            else
            {
                Console.WriteLine($"Invalid age { age }");
            }
        }
        */

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Display()
        {
            Console.WriteLine($"Name:{Name}\nAge:{Age}");
        }
    }
}
