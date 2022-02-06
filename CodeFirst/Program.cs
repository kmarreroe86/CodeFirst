using System;
using CodeFirst.Models;

namespace CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var context = new MyDbContext();
                var p = new Programme();
                p.Title = "B.Tech";
                p.Duration = 4;
                p.Fees = 50000;

                context.Programmes.Add(p);
                context.SaveChanges();
                Console.WriteLine("Database created");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

// How to set connectionString to .net core console application