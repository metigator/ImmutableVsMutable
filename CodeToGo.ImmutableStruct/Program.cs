using System;

namespace CodeToGo.ImmutableStruct
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var date1 = new Date(2022, 01, 01);

            //date1.Day = 40; // Error compile time

            Console.WriteLine($"{date1}");

            // var date2 = date1.AddDays(10); // immutable

            date1 = date1.AddDays(10); // immutable

            Console.WriteLine($"{date1}");

            Console.ReadKey();
        }
    }
}
