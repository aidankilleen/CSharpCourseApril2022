using System;
using System.Collections.Generic;
using System.Text;

namespace NewishFeatures
{



    class NamedAndDefaultParameters
    {

        static void showInfo(string name = "Fred", string address = "Dublin")
        {
            Console.WriteLine($"Name:{ name }\nAddress:{ address }");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Named and Default Parameters");

            showInfo("Aidan", "Cork"); // normal call 

            showInfo("Aidan"); // default address

            showInfo(); // default name and address

            showInfo(address:"Cork", name:"Aidan"); // named parameters

            showInfo(address: "Dublin"); // named parameter with default name
        }
    }
}
