using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqAggregationInvestigation
{
    class Record
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Colour { get; set; }
        public int Quantity { get; set; }

        public override string ToString()
        {
            return $"{Id}\t{Name}\t{Colour}\t{Quantity}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Record> records = new List<Record>();


            records.Add(new Record { Id = 1, Name = "Alice", Colour = "Red", Quantity = 50 });
            records.Add(new Record { Id = 2, Name = "Bob", Colour = "Green", Quantity = 22 });
            records.Add(new Record { Id = 3, Name = "Carol", Colour = "Blue", Quantity = 21 });
            records.Add(new Record { Id = 4, Name = "Dan", Colour = "Red", Quantity = 98 });
            records.Add(new Record { Id = 5, Name = "Alice", Colour = "Red", Quantity = 50 });
            records.Add(new Record { Id = 6, Name = "Alice", Colour = "Orange", Quantity = 50 });
            records.Add(new Record { Id = 7, Name = "Alice", Colour = "Blue", Quantity = 50 });
            records.Add(new Record { Id = 8, Name = "Bob", Colour = "Green", Quantity = 11 });
            records.Add(new Record { Id = 9, Name = "Carol", Colour = "Blue", Quantity = 1 });
            records.Add(new Record { Id = 10, Name = "Dan", Colour = "Red", Quantity = 8 });
            records.Add(new Record { Id = 11, Name = "Alice", Colour = "Red", Quantity = 150 });
            records.Add(new Record { Id = 12, Name = "Alice", Colour = "Green", Quantity = 58 });
            records.Add(new Record { Id = 13, Name = "Carol", Colour = "Blue", Quantity = 21 });
            records.Add(new Record { Id = 14, Name = "Dan", Colour = "Red", Quantity = 98 });
            records.Add(new Record { Id = 15, Name = "Alice", Colour = "Green", Quantity = 50 });
            records.Add(new Record { Id = 16, Name = "Alice", Colour = "Orange", Quantity = 50 });
            records.Add(new Record { Id = 17, Name = "Alice", Colour = "Blue", Quantity = 50 });
            records.Add(new Record { Id = 18, Name = "Bob", Colour = "Green", Quantity = 11 });
            records.Add(new Record { Id = 19, Name = "Carol", Colour = "Green", Quantity = 1 });
            records.Add(new Record { Id = 20, Name = "Dan", Colour = "Red", Quantity = 8 });
            records.Add(new Record { Id = 21, Name = "Alice", Colour = "Green", Quantity = 150 });
            records.Add(new Record { Id = 22, Name = "Eve", Colour = "Green", Quantity = 58 });

            Console.WriteLine("Linq Aggregation");

            var res = from record in records
                      select record;

            foreach (Record r in res)
            {
                Console.WriteLine(r);
            }

            var agg = from record in records
                      group record by record.Name into g
                      select new
                      {
                          Name = g.Key,
                          Count = g.Count(),
                          Total = g.Sum(r => r.Quantity)
                      };

            foreach (var item in agg)
            {
                Console.WriteLine(item);
            }

            var agg2 = from record in records
                       group record by record.Colour into g
                       select new
                       {
                           Colour = g.Key,
                           Count = g.Count(),
                           Total = g.Sum(r => r.Quantity)
                       };

            foreach (var item in agg2)
            {
                Console.WriteLine(item);
            }


        }
    }
}
