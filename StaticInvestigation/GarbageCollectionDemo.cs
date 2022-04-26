using System;
using System.Collections.Generic;
using System.Text;

namespace StaticInvestigation
{
    class GarbageCollectionDemo
    {

        static void Main(string[] args)
        {
            int i = 0;
            while (i < 1000)
            {
                Message m = new Message($"Message {i}", $"This is message {i}");
                i++;
            }
        }
    }
}
