﻿using System;

namespace EncapsulationTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Encapsulation Test");

            Person p = new Person("Alice", 21);

            p.Display();

            p.Name = "Alison";
            //p.setAge(-1000);

            p.Age = -1000;

            p.Display();

        }
    }
}
