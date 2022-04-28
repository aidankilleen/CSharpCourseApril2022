using System;
using System.Collections.Generic;
using System.Text;

namespace NewishFeatures
{
    class Result
    {
        public int Sum { get; set; }
        public double Average { get; set; }
    }
    class TupleTest
    {
        static Result DoCalculation(int[] list)
        {

            int total = 0;
            double average = 0;
            foreach (int i in list)
            {
                total += i;
            }
            average = total / list.Length;
            Result r = new Result { Sum = total, Average = average };

            return r;
        }

        static (int Sum, double Average) DoCalculations(int[] list)
        {
            int total = 0;
            double average = 0;
            foreach (int i in list)
            {
                total += i;
            }
            average = total / list.Length;

            return (total, average);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Tuple Test");

            int[] list = { 1, 2, 3, 4, 5 };

            Result r = DoCalculation(list);

            Console.WriteLine($"The sum is { r.Sum }, the average is { r.Average }");
            (int Sum, double Average) results = DoCalculations(list);

            Console.WriteLine($"The sum is { results.Sum }, the average is { results.Average }");


            int a = 10;
            int b = 20;

            Console.WriteLine($"a = {a}    b = {b}");


            (a, b) = (b, a);


            Console.WriteLine($"a = {a}    b = {b}");



        }
    }
}
